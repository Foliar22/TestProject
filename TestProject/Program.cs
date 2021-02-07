using System;
using System.Windows.Forms;
using TestProject.Forms;

namespace TestProject
{
    static class Program
    {
        static string result { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        Start:
            #region LoginRegion
            using (var autoForm = new LoginForm())
            {

                if (autoForm.ShowDialog() != DialogResult.OK)
                {
                    return;

                }

            }
        #endregion

        startChoice:
            #region CoustomMessageBox
            using (var question = new CustomMessageBox())
            {
                var dialogResult = question.ShowDialog();

                if (dialogResult == DialogResult.Yes)
                {
                    result = dialogResult.ToString();
                    question.Close();
                    goto end;
                }
                else if (dialogResult == DialogResult.No)
                {
                    result = dialogResult.ToString();
                    question.Close();
                    goto end;
                }
                else if(dialogResult == DialogResult.OK)
                {
                    result = dialogResult.ToString();
                    question.Close();
                    goto end;
                }
                else if (dialogResult == DialogResult.Abort)
                {
                    question.Close();
                    goto Start;
                }

            }
        #endregion

        end:
            #region EndRegion
            switch (result)
            {
                case "Yes":
                    using (var habrPars = new HabrParserForm())
                    {
                        if (habrPars.ShowDialog() == DialogResult.Cancel)
                        {
                            habrPars.Close();
                            goto startChoice;
                        }
                    }
                    break;
                case "No":
                    using (var agilityPars = new AgilityParserForm())
                    {
                        if (agilityPars.ShowDialog() == DialogResult.Cancel)
                        {
                            agilityPars.Close();
                            goto startChoice;
                        }
                    }
                    break;
                case "OK":
                    using(var saveData = new SaveForm())
                    {
                        if (saveData.ShowDialog() == DialogResult.Cancel)
                        {
                            saveData.Close();
                            goto startChoice;
                        }
                    }
                    break;
            }
            #endregion





        }



    }
}
