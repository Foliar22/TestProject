
namespace TestProject
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonRollUp = new System.Windows.Forms.Button();
            this.confirmPassField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.buttonHidePass = new System.Windows.Forms.PictureBox();
            this.buttonOpenPass = new System.Windows.Forms.PictureBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.lableRegistr = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOpenPass)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mainPanel.Controls.Add(this.buttonRollUp);
            this.mainPanel.Controls.Add(this.confirmPassField);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.userSurnameField);
            this.mainPanel.Controls.Add(this.userNameField);
            this.mainPanel.Controls.Add(this.buttonHidePass);
            this.mainPanel.Controls.Add(this.buttonOpenPass);
            this.mainPanel.Controls.Add(this.buttonRegistration);
            this.mainPanel.Controls.Add(this.passBox);
            this.mainPanel.Controls.Add(this.loginField);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(this.lableRegistr);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(621, 496);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // buttonRollUp
            // 
            this.buttonRollUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRollUp.FlatAppearance.BorderSize = 0;
            this.buttonRollUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRollUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRollUp.Location = new System.Drawing.Point(556, 2);
            this.buttonRollUp.Name = "buttonRollUp";
            this.buttonRollUp.Size = new System.Drawing.Size(28, 27);
            this.buttonRollUp.TabIndex = 19;
            this.buttonRollUp.Text = "_";
            this.buttonRollUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRollUp.UseVisualStyleBackColor = true;
            this.buttonRollUp.Click += new System.EventHandler(this.buttonRollUp_Click);
            this.buttonRollUp.MouseEnter += new System.EventHandler(this.buttonRollUp_MouseEnter);
            this.buttonRollUp.MouseLeave += new System.EventHandler(this.buttonRollUp_MouseLeave);
            // 
            // confirmPassField
            // 
            this.confirmPassField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPassField.Location = new System.Drawing.Point(38, 363);
            this.confirmPassField.Name = "confirmPassField";
            this.confirmPassField.Size = new System.Drawing.Size(459, 32);
            this.confirmPassField.TabIndex = 18;
            this.confirmPassField.UseSystemPasswordChar = true;
            this.confirmPassField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmPassField_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Подтвердите пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Имя";
            // 
            // userSurnameField
            // 
            this.userSurnameField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSurnameField.Location = new System.Drawing.Point(38, 232);
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(459, 32);
            this.userSurnameField.TabIndex = 14;
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userSurnameField_KeyPress);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.Location = new System.Drawing.Point(38, 170);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(459, 32);
            this.userNameField.TabIndex = 13;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameField_KeyPress);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // buttonHidePass
            // 
            this.buttonHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHidePass.Image = global::TestProject.Properties.Resources.eye_closed;
            this.buttonHidePass.Location = new System.Drawing.Point(542, 295);
            this.buttonHidePass.Name = "buttonHidePass";
            this.buttonHidePass.Size = new System.Drawing.Size(33, 32);
            this.buttonHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonHidePass.TabIndex = 12;
            this.buttonHidePass.TabStop = false;
            this.buttonHidePass.Click += new System.EventHandler(this.buttonHidePass_Click);
            // 
            // buttonOpenPass
            // 
            this.buttonOpenPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenPass.Image = global::TestProject.Properties.Resources.eye_open;
            this.buttonOpenPass.Location = new System.Drawing.Point(503, 295);
            this.buttonOpenPass.Name = "buttonOpenPass";
            this.buttonOpenPass.Size = new System.Drawing.Size(33, 32);
            this.buttonOpenPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonOpenPass.TabIndex = 11;
            this.buttonOpenPass.TabStop = false;
            this.buttonOpenPass.Click += new System.EventHandler(this.buttonOpenPass_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.White;
            this.buttonRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.Location = new System.Drawing.Point(38, 432);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(235, 52);
            this.buttonRegistration.TabIndex = 10;
            this.buttonRegistration.Text = "Зарегистрироваться";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBox.Location = new System.Drawing.Point(38, 295);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(459, 32);
            this.passBox.TabIndex = 5;
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passBox_KeyPress);
            this.passBox.Leave += new System.EventHandler(this.passBox_Leave);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(38, 107);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(459, 32);
            this.loginField.TabIndex = 4;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(590, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 24);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // lableRegistr
            // 
            this.lableRegistr.AutoSize = true;
            this.lableRegistr.Dock = System.Windows.Forms.DockStyle.Top;
            this.lableRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableRegistr.Location = new System.Drawing.Point(0, 0);
            this.lableRegistr.Name = "lableRegistr";
            this.lableRegistr.Size = new System.Drawing.Size(223, 39);
            this.lableRegistr.TabIndex = 0;
            this.lableRegistr.Text = "Регистрация";
            this.lableRegistr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 496);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonOpenPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label lableRegistr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.PictureBox buttonOpenPass;
        private System.Windows.Forms.PictureBox buttonHidePass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox confirmPassField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRollUp;
    }
}