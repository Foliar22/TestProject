using TestProject.Core;
using TestProject.Habra;
using System;
using System.Windows.Forms;
using TestProject.DataBase;
using System.Data.SqlClient;
using System.IO;

namespace TestProject
{
    public partial class HabrParserForm : Form
    {
        public static string userLogin { get; set; }
        public static string userId { get; set; }
        public static string idPage { get; set; }
        private static string savePath { get; set; }


        
        
        ParserWorker<string[]> parser;
        public HabrParserForm()
        {

            InitializeComponent();
            parser = new ParserWorker<string[]>(new HabraParser());



            #region Label          
            labelUser.Visible = true;
            labelUser.Text = userLogin;
            #endregion

            try
            {
                parser.OnComleted += Parser_OnComleted;
                parser.OnNewData += Parser_OnNewData;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        #region Buttons
        public void ButtonStart_Click(object sender, EventArgs e)
        {

            parser.Settings = new HabraSettings((int)NumericStart.Value, (int)NumericEnd.Value);
            ListTitles.Items.Clear();
            parser.Start();
            labelidPage.Visible = true;

        }

        public void ButtonSrop_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            buttonSave.Enabled = false;

            ListTitles.Items.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveData();
            buttonSave.Enabled = false;
            MessageBox.Show("Сохранение завершено");
        }
        #endregion



        
        public void Parser_OnComleted(object obj)
        {
            MessageBox.Show("All works done!");
            buttonSave.Enabled = true;
        }
        public void Parser_OnNewData(object arg1, string[] newData)
        {
            if (ListTitles.Items.Count > 0)
            {

                for (int i = 0; i < ListTitles.Items.Count; i++)
                {

                    for (int j = 0; j < newData.Length; j++)
                    {
                        string[] itemsSplit = ListTitles.Items[i].ToString().Replace("Слово: ", "").Replace("Количество Повторов: ", "").Split(new Char[] { ' ' });
                        string[] dataSplit = newData[j].Replace("Слово: ", "").Replace("Количество Повторов: ", "").Split(new Char[] { ' ' });
                        if (String.Equals(itemsSplit[0], dataSplit[0]))
                        {
                            int sum = Convert.ToInt32(itemsSplit[1]) + Convert.ToInt32(dataSplit[1]);
                            ListTitles.Items[i] = "Слово: " + itemsSplit[0] + " Количество Повторов: " + sum + "";

                        }


                    }
                }
            }
            else
            {
                ListTitles.Items.AddRange(newData);
            }
            labelidPage.Text = idPage;

        }

        private void HabrParserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void SaveData()
        {
            #region Connection
            DBconnection db = new DBconnection();
            await db.connection.OpenAsync();
            #endregion

            string randomNamefile = string.Format(@"{0}.txt", Guid.NewGuid());
            string dbSavePath;
            string filePath = savePath + @"\" + randomNamefile;
            if (savePath.EndsWith(@"UserStory\" + userLogin))
            {
                dbSavePath = @"UserStory\" + userLogin;
            }
            else
            {
                dbSavePath = @"Debug\" + @"UserStory\" + userLogin;
            }
            using (FileStream fs = new FileStream(filePath, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    for (int i = 0; i < ListTitles.Items.Count; i++)
                    {
                        sw.WriteLine(ListTitles.Items[i].ToString());
                    }
                }
            }

            SqlCommand command = new SqlCommand("INSERT INTO [UserStory] (IdUser,DateTime,ResultTxtName,Path,LastPages) VALUES(@IdUser,@DateTime,@ResultTxtName,@Path,@LastPages)", db.connection);
            command.Parameters.AddWithValue("IdUser", userId);
            command.Parameters.AddWithValue("DateTime", DateTime.Now);
            command.Parameters.AddWithValue("ResultTxtName", randomNamefile);
            command.Parameters.AddWithValue("Path", dbSavePath);
            command.Parameters.AddWithValue("LastPages", idPage);

            await command.ExecuteNonQueryAsync();

            db.connection.Close();
            GC.Collect();
        }

        private void HabrParserForm_Load(object sender, EventArgs e)
        {
            #region CreateDir
            string location = AppDomain.CurrentDomain.BaseDirectory;
            if (location.EndsWith(@"bin\Debug\"))
            {
                location = location.Replace("bin\\Debug\\", "");
                location += "UserStory\\";
                if (Directory.Exists(location + "\\" + userLogin) == false)
                {
                    Directory.CreateDirectory(location + "\\" + userLogin);
                }
                savePath = location + userLogin;
                location = null;
                GC.Collect();
            }
            else if (location.EndsWith(@"bin\Release\"))
            {
                location = location.Replace("bin\\Release\\", "");
                location += "UserStory\\";
                if (Directory.Exists(location + "\\" + userLogin) == false)
                {
                    Directory.CreateDirectory(location + "\\" + userLogin);
                }
                savePath = location + userLogin;
                location = null;
                GC.Collect();
            }
            else
            {
                if (Directory.Exists(location + "UserStory") == false)
                {
                    Directory.CreateDirectory(location + "UserStory");

                }
                location += "UserStory\\";
                if (Directory.Exists(location + "\\" + userLogin) == false)
                {
                    Directory.CreateDirectory(location + "\\" + userLogin);
                }
                savePath = location + userLogin;
                location = null;
                GC.Collect();

            }
            #endregion
        }
    }
}
