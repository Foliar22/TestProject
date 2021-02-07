
namespace TestProject
{
    partial class CustomMessageBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.buttonUniqHTML = new System.Windows.Forms.Button();
            this.buttonHabrPars = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.buttonSaveData);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(this.buttonUniqHTML);
            this.mainPanel.Controls.Add(this.buttonHabrPars);
            this.mainPanel.Controls.Add(this.labelQuestion);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(550, 283);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Или посмотреть сохраненные данные";
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.AutoSize = true;
            this.buttonSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveData.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSaveData.FlatAppearance.BorderSize = 2;
            this.buttonSaveData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonSaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveData.Location = new System.Drawing.Point(133, 196);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(281, 75);
            this.buttonSaveData.TabIndex = 4;
            this.buttonSaveData.Text = "Посмотреть сохраненные данные";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(527, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 19);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // buttonUniqHTML
            // 
            this.buttonUniqHTML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUniqHTML.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUniqHTML.FlatAppearance.BorderSize = 2;
            this.buttonUniqHTML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonUniqHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUniqHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUniqHTML.Location = new System.Drawing.Point(297, 61);
            this.buttonUniqHTML.Name = "buttonUniqHTML";
            this.buttonUniqHTML.Size = new System.Drawing.Size(208, 75);
            this.buttonUniqHTML.TabIndex = 2;
            this.buttonUniqHTML.Text = "Парсер произвольной страницы";
            this.buttonUniqHTML.UseVisualStyleBackColor = true;
            this.buttonUniqHTML.Click += new System.EventHandler(this.buttonUniqHTML_Click);
            // 
            // buttonHabrPars
            // 
            this.buttonHabrPars.AutoSize = true;
            this.buttonHabrPars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHabrPars.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHabrPars.FlatAppearance.BorderSize = 2;
            this.buttonHabrPars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonHabrPars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHabrPars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHabrPars.Location = new System.Drawing.Point(37, 61);
            this.buttonHabrPars.Name = "buttonHabrPars";
            this.buttonHabrPars.Size = new System.Drawing.Size(208, 75);
            this.buttonHabrPars.TabIndex = 1;
            this.buttonHabrPars.Text = "Хабр";
            this.buttonHabrPars.UseVisualStyleBackColor = true;
            this.buttonHabrPars.Click += new System.EventHandler(this.buttonHabrPars_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(31, 9);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(474, 33);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Какой парсер вы хотите открыть?";
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 283);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonHabrPars;
        private System.Windows.Forms.Button buttonUniqHTML;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveData;
    }
}