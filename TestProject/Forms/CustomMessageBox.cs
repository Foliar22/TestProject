using System;
using System.Drawing;
using System.Windows.Forms;
using TestProject.Forms;

namespace TestProject
{
    public partial class CustomMessageBox : Form
    {
        public static string userLogin { get; set; }
        public static string userId { get; set; }
        public CustomMessageBox()
        {
            InitializeComponent();
        }



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

       


        private void buttonHabrPars_Click(object sender, EventArgs e)
        {
            HabrParserForm.userId = userId;
            HabrParserForm.userLogin = userLogin;
            DialogResult = DialogResult.Yes;

        }

        private void buttonUniqHTML_Click(object sender, EventArgs e)
        {
            AgilityParserForm.userId = userId;
            AgilityParserForm.userLogin = userLogin;
            DialogResult = DialogResult.No;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            SaveForm.userId = userId;
            SaveForm.userLogin = userLogin;
            DialogResult = DialogResult.OK;
        }
    }
}
