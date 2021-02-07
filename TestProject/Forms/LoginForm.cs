using TestProject.DataBase;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            #region StartSettings
            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;
            if (passField.UseSystemPasswordChar == true)
            {
                buttonHidePass.BackColor = Color.White;

            }
            #endregion
        }

        #region Buttons
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;
            if(Authorization(loginUser, passUser)== true)
            {
                MessageBox.Show("Добро пожаловать " + loginUser + "!");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Пользователь не найден или введен не верный пароль.", "Оповещение!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }
        private void buttonRollUp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonRollUp_MouseEnter(object sender, EventArgs e)
        {
            buttonRollUp.ForeColor = Color.White;
        }

        private void buttonRollUp_MouseLeave(object sender, EventArgs e)
        {
            buttonRollUp.ForeColor = Color.Black;
        }


        private void buttonOpenPass_Click(object sender, EventArgs e)
        {
            buttonOpenPass.BackColor = Color.White;
            buttonHidePass.BackColor = Color.FromArgb(244, 139, 15);
            passField.UseSystemPasswordChar = false;
        }

        private void buttonHidePass_Click(object sender, EventArgs e)
        {
            buttonHidePass.BackColor = Color.White;
            buttonOpenPass.BackColor = Color.FromArgb(244, 139, 15);
            passField.UseSystemPasswordChar = true;
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {

            RegisterForm regForm = new RegisterForm();
            regForm.Show();


        }

        #endregion


        #region Formtransfer
        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Opacity = 0.1;
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                
            }
            
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            
            lastPoint = new Point(e.X, e.Y);
            
        }

        private void labelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Opacity = 0.1;
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }

        private void labelTop_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }

        #endregion


        #region FieldSettings
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.ForeColor = Color.Black;
                loginField.Text = "";
            }

        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }

        }
        #endregion




        private bool Authorization(string loginUser,string passUser)
        {
            try
            {
                DBconnection db = new DBconnection();
                SqlDataReader sqlReader = null;
                db.connection.Open();
                SqlCommand command = new SqlCommand("select * from [user] where [Login] = @uL and [Password] = @uP", db.connection);
                command.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                sqlReader = command.ExecuteReader();
                sqlReader.Read();
                if (sqlReader.HasRows == true)
                {
                    CustomMessageBox.userId = sqlReader.GetValue(0).ToString();
                    sqlReader.Close();
                    db.connection.Close();
                    CustomMessageBox.userLogin = loginUser;
                    return true;
                }
                else
                {
                    sqlReader.Close();
                    db.connection.Close();
                    return false;
                        
                }
               
            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }








    }
}
