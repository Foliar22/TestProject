using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TestProject.DataBase;

namespace TestProject.Forms
{
    public partial class SaveForm : Form
    {
        public static string userId { get; set; }
        private string location{ get; set; }
        public static string userLogin { get; set; }

        private DBconnection db = new DBconnection();
        private SqlDataAdapter adapter = null;
        private SqlCommandBuilder sqbBuilder = null;
        private DataSet dataSet = null;
        public SaveForm()
        {
            InitializeComponent();
            #region LocationSearch
            location = AppDomain.CurrentDomain.BaseDirectory;
            if (location.EndsWith(@"bin\Debug\"))
            {
                location = location.Replace("bin\\Debug\\", "");
            }
            else if (location.EndsWith(@"bin\Release\"))
            {
                location = location.Replace("bin\\Release\\", "");
            }
            else
            {
                location = location;
            }
            #endregion
            labelUserLogin.Text = userLogin;


        }

        #region ButtonSettings
        private void buttonStart_Click(object sender, EventArgs e)
        {
            db.connection.Open();
            LoadData();
            db.connection.Close();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            db.connection.Open();
            ReloadData();
            db.connection.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxHtml.Items.Clear();
            listBoxResult.Items.Clear();
        }
        #endregion

        private void LoadData()
        {
           
            try
            {

                adapter = new SqlDataAdapter("Select *,'Open' as [Open], 'Delete' as [Delete] from UserStory where IdUser = @userId", db.connection);
                adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);
                sqbBuilder = new SqlCommandBuilder(adapter);

                sqbBuilder.GetDeleteCommand();

                dataSet = new DataSet();
                adapter.Fill(dataSet, "UserStory");
                dataGridViewSave.DataSource = dataSet.Tables["UserStory"];
                for (int i = 0; i < dataGridViewSave.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewSave.ColumnCount; j++)
                    {
                        dataGridViewSave.Rows[i].Cells[j].ReadOnly = true;

                    }
                }

                for (int i = 0; i < dataGridViewSave.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell(); //Если вызывать экземпляр этого класса до цикла, то будет ошибка
                    dataGridViewSave[dataGridViewSave.Columns.Count - 2, i] = linkCell; //Так же, если не сделать два цикла для этого, то тоже будет ошибка 


                }

                for (int i = 0; i < dataGridViewSave.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridViewSave[dataGridViewSave.Columns.Count - 1, i] = linkCell;

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void ReloadData()
        {
            
            try
            {
                dataSet.Tables["UserStory"].Clear();
                adapter.Fill(dataSet, "UserStory");
                dataGridViewSave.DataSource = dataSet.Tables["UserStory"];
                for (int i = 0; i < dataGridViewSave.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewSave.ColumnCount; j++)
                    {
                        dataGridViewSave.Rows[i].Cells[j].ReadOnly = true;

                    }
                }

                for (int i = 0; i < dataGridViewSave.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell(); //Если вызывать экземпляр этого класса до цикла, то будет ошибка
                    dataGridViewSave[dataGridViewSave.Columns.Count - 2, i] = linkCell; //Так же, если не сделать два цикла для этого, то тоже будет ошибка 


                }

                for (int i = 0; i < dataGridViewSave.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridViewSave[dataGridViewSave.Columns.Count - 1, i] = linkCell;

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridViewSave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            db.connection.Open();
            try
            {
                if(e.ColumnIndex == dataGridViewSave.Columns.Count - 2)//Open
                {
                    listBoxResult.Items.Clear();
                    listBoxHtml.Items.Clear();
                    int rowIndex = e.RowIndex;
                    string pathOpenHtml = location;
                    string pathOpenResul = location;
                    var path = dataSet.Tables["UserStory"].Rows[rowIndex][5];
                    var htmlName = dataSet.Tables["UserStory"].Rows[rowIndex][3];
                    var resultName = dataSet.Tables["UserStory"].Rows[rowIndex][4];
                    pathOpenHtml += path.ToString();
                    pathOpenHtml += @"\" + htmlName.ToString();
                    pathOpenResul += path.ToString();
                    pathOpenResul += @"\" + resultName.ToString();
                    if (htmlName.ToString() != "")
                    {
                        using (FileStream fileStreamHtml = new FileStream(pathOpenHtml, FileMode.Open))
                        {
                            using (StreamReader streamReaderHtml = new StreamReader(fileStreamHtml))
                            {
                                while (!streamReaderHtml.EndOfStream)
                                {
                                    listBoxHtml.Items.Add(streamReaderHtml.ReadLine());

                                }

                            }
                        }
                        using (FileStream fileStreamResult = new FileStream(pathOpenResul, FileMode.Open))
                        {
                            using (StreamReader streamReaderResult = new StreamReader(fileStreamResult))
                            {
                                while (!streamReaderResult.EndOfStream)
                                {
                                    listBoxResult.Items.Add(streamReaderResult.ReadLine());

                                }

                            }
                        }
                        if (listBoxHtml.Items.Count <= 1)
                        {
                            if ((MessageBox.Show("Возможно страница плохо сохранилась. \nВы хотите открыть файл с содержимым?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                            {
                                Process.Start(pathOpenHtml);
                            }
                        }
                    }
                    else
                    {
                        using (FileStream fileStreamResult = new FileStream(pathOpenResul, FileMode.Open))
                        {
                            using (StreamReader streamReaderResult = new StreamReader(fileStreamResult))
                            {
                                while (!streamReaderResult.EndOfStream)
                                {
                                    listBoxResult.Items.Add(streamReaderResult.ReadLine());

                                }

                            }
                        }
                    }


                }
                else if(e.ColumnIndex == dataGridViewSave.Columns.Count - 1)//Delete
                {
                    if((MessageBox.Show("Удалить данные?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;
                        string pathDel = location;
                        var path = dataSet.Tables["UserStory"].Rows[rowIndex][5];
                        var htmlName = dataSet.Tables["UserStory"].Rows[rowIndex][3];
                        var resultName = dataSet.Tables["UserStory"].Rows[rowIndex][4];
                        pathDel += path.ToString();
                        if(htmlName.ToString() != "")
                        {
                            pathDel += @"\" + htmlName.ToString();
                            File.Delete(pathDel);
                            pathDel = location + path.ToString() + @"\" + resultName.ToString();
                            File.Delete(pathDel);
                        }
                        else
                        {
                            pathDel += @"\" + resultName.ToString();
                            File.Delete(pathDel);
                        }
                        dataSet.Tables["UserStory"].Rows[rowIndex].Delete();

                        adapter.Update(dataSet, "UserStory");
                    }

                    
                }
                db.connection.Close();
                ReloadData();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
