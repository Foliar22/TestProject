using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using TestProject.Core;
using TestProject.DataBase;

namespace TestProject.Forms
{
    public partial class AgilityParserForm : Form
    {
        public static string userLogin { get; set; }
        public static string userId { get; set; }
        private static string savePath { get; set; }
        private  string randomNameFile { get; set; }
        private string randomHtmlFileName { get; set; }

        public AgilityParserForm()
        {

            InitializeComponent();

            #region StartSettings
            urlField.Text = "Введите url";
            urlField.ForeColor = Color.Gray;
            labelUser.Visible = true;
            labelUser.Text = userLogin;
            buttonSave.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder);
            #endregion

          



        }


        #region FieldSetting
        private void urlField_Enter(object sender, EventArgs e)
        {
            if(urlField.Text == "Введите url")
            {
                urlField.ForeColor = Color.Black;
                urlField.Text = "";
            }
        }

        private void urlField_Leave(object sender, EventArgs e)
        {
            if(urlField.Text == "")
            {
                urlField.ForeColor = Color.Gray;
                urlField.Text = "Введите url";
            }
        }

        #endregion

        #region Buttons
        private void buttonStart_Click(object sender, EventArgs e)
        {
            listItem.Items.Clear();
            urlField.Enabled = false;
            AgilityParser agilityParser = new AgilityParser();
            listItem.Items.AddRange(agilityParser.AgilityPars(urlField.Text));
            buttonSave.Enabled = true;
            buttonSave.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listItem.Items.Clear();
            urlField.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveData();
            buttonSave.Enabled = false;
            urlField.Enabled = true;
            buttonSave.BackColor = Color.FromKnownColor(KnownColor.ActiveBorder);
            MessageBox.Show("Сохранение завершено");
        }

        #endregion


        private async void SaveData()
        {
            #region Connection
            DBconnection db = new DBconnection();
            await db.connection.OpenAsync();
            #endregion
            randomNameFile = string.Format(@"{0}.txt", Guid.NewGuid());
            randomHtmlFileName = string.Format(@"{0}.txt", Guid.NewGuid());
            try
            {
                string dbSavePath;
                string filePath = savePath + @"\" + randomNameFile;
                string HtmlPath = savePath + @"\" + randomHtmlFileName;

                if (savePath.EndsWith(@"UserStory\" + userLogin))
                {
                    dbSavePath = @"UserStory\" + userLogin;
                }
                else
                {
                    dbSavePath = @"Debug\" + @"UserStory\" + userLogin;
                }
                using (FileStream fileStreamResult = new FileStream(filePath, FileMode.Append))
                {
                    using (StreamWriter streamWriterResult = new StreamWriter(fileStreamResult))
                    {
                        for (int i = 0; i < listItem.Items.Count; i++)
                        {
                            streamWriterResult.WriteLine(listItem.Items[i].ToString());
                        }
                    }
                }
                using (FileStream fileStreamHtml = new FileStream(HtmlPath, FileMode.Append))
                {
                    using (StreamWriter streamWriterHtml = new StreamWriter(fileStreamHtml))
                    {
                        using (HttpClientHandler hdl = new HttpClientHandler { AllowAutoRedirect = false, AutomaticDecompression = System.Net.DecompressionMethods.Deflate | System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.None })
                        {
                            using (var clnt = new HttpClient(hdl))
                            {
                                using (HttpResponseMessage resp = clnt.GetAsync(urlField.Text).Result)
                                {
                                    var html = resp.Content.ReadAsStringAsync().Result;
                                    streamWriterHtml.Write(html);
                                    html = null;
                                    GC.Collect();
                                }
                            }
                        }

                    }
                }
                GC.Collect();
                SqlCommand command = new SqlCommand("INSERT INTO [UserStory] (IdUser,DateTime,HtmlName,ResultTxtName,Path,Url) VALUES(@IdUser,@DateTime,@HtmlName,@ResultTxtName,@Path,@Url)", db.connection);
                command.Parameters.AddWithValue("IdUser", userId);
                command.Parameters.AddWithValue("DateTime", DateTime.Now);
                command.Parameters.AddWithValue("HtmlName", randomHtmlFileName);
                command.Parameters.AddWithValue("ResultTxtName", randomNameFile);
                command.Parameters.AddWithValue("Path", dbSavePath);
                command.Parameters.AddWithValue("Url", urlField.Text);
                await command.ExecuteNonQueryAsync();
                db.connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        private void AgilityParserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AgilityParserForm_Load(object sender, EventArgs e)
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
