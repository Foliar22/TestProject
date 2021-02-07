using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TestProject.DataBase;

namespace TestProject
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            #region StartSetting
            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;
            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;
            if(passBox.UseSystemPasswordChar == true)
            {
                buttonHidePass.BackColor = Color.White;

            }
            
            #endregion

        }


        #region Buttons
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Registrations();
            MessageBox.Show("Регестрация успешна");
            this.Close();
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
            buttonHidePass.BackColor = Color.LightSteelBlue;
            passBox.UseSystemPasswordChar = false;
            confirmPassField.UseSystemPasswordChar = false;

        }

        private void buttonHidePass_Click(object sender, EventArgs e)
        {
            buttonHidePass.BackColor = Color.White;
            buttonOpenPass.BackColor = Color.LightSteelBlue;
            passBox.UseSystemPasswordChar = true;
            confirmPassField.UseSystemPasswordChar = true;
        }
        #endregion


        #region FormTransfer
        Point lastPoint;
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Opacity = 0.1;
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }

        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }

        #endregion


        #region FieldSettings
        private void userNameField_Enter(object sender, EventArgs e)
        {
            if(userNameField.Text== "Введите имя")
            {
                userNameField.ForeColor = Color.Black;
                userNameField.Text = "";
                

            }
            
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if(userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;

            }
            else if (userNameField.Text.Length > 50)
            {
               
                MessageBox.Show("Имя длинее 50 символов");
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.ForeColor = Color.Black;
                userSurnameField.Text = "";
            }

        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
                
            }
            else if (userSurnameField.Text.Length > 50)
            {
                MessageBox.Show("Фамилия длинее 50 символов");
            }

        }

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
            DBconnection db = new DBconnection();
            SqlDataReader sqlReader = null;
            db.connection.Open();
            SqlCommand command = new SqlCommand("select * from [user] where [Login] = @uL ", db.connection);
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginField.Text;
            sqlReader = command.ExecuteReader();
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
            else if (loginField.Text.Length > 50)
            {
                buttonRegistration.Enabled = false;
                MessageBox.Show("Длинна логина больше 50 символов");

            }
            else if (sqlReader.HasRows == true)
            {
                sqlReader.Close();
                db.connection.Close();
                MessageBox.Show("Логин занят");
                buttonRegistration.Visible = false;
            }
            else
            {

                buttonRegistration.Visible = true;
            }

            sqlReader.Close();
            db.connection.Close();
        }

        private void passBox_Leave(object sender, EventArgs e)
        {
            if (passBox.Text.Length <= 3)
            {
                MessageBox.Show("Длинна пароля меньше 4-рех символов");
                buttonRegistration.Visible = false;
            }
            else if (passBox.Text.Length > 50)
            {
                MessageBox.Show("Длинна пароля больше 50 символов");
            }
            else
            {
                buttonRegistration.Visible = true;
            }
        }

        #endregion


        #region KeyPressSettings
        private void userNameField_KeyPress(object sender, KeyPressEventArgs e)
        {

            string Symbol = e.KeyChar.ToString();

            if (!(Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void userSurnameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!(Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void passBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
        private void confirmPassField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }

        }

        #endregion




        private async void Registrations()
        {
            DBconnection db = new DBconnection();
            await db.connection.OpenAsync();
            if (passBox.Text == confirmPassField.Text)
            {
                if (loginField.Text != "Введите логин")
                {
                    if (userNameField.Text != "Введите имя")
                    {
                        if (userSurnameField.Text != "Введите фамилию")
                        {


                            try
                            {
                                SqlCommand command = new SqlCommand("INSERT INTO [user] (Login, Password, Name, Surname) VALUES(@Login, @Password, @Name, @Surname)", db.connection);
                                command.Parameters.AddWithValue("Login", loginField.Text);
                                command.Parameters.AddWithValue("Password", passBox.Text);
                                command.Parameters.AddWithValue("Name", userNameField.Text);
                                command.Parameters.AddWithValue("Surname", userSurnameField.Text);
                                await command.ExecuteNonQueryAsync();
                                db.connection.Close();


                            }
                            catch (System.Reflection.TargetInvocationException)
                            {
                                MessageBox.Show("Логин занят");

                            }




                        }
                        else
                        {
                            MessageBox.Show("Фамилия не введена");
                            db.connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Имя не введено");
                        db.connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Логин не введен");
                    db.connection.Close();
                }

            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
                db.connection.Close();
            }
        }

    }
}
