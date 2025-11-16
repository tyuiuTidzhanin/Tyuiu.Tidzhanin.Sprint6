using System;
using System.IO;
using System.Windows.Forms;

namespace Tyuiu.NargondoTI.Sprint6.Task4.V2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxResult;
        private Button buttonExecute;
        private Button buttonSave;
        private Button buttonInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBoxFormula = new PictureBox();
            textBoxResult = new TextBox();
            buttonExecute = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            SuspendLayout();

            // pictureBoxFormula
            // 
            string username = Environment.UserName;
            string imagePath = Path.Combine($"C:\\Users\\{username}", "source", "repos", "Tyuiu.Tidzhanin.Sprint6", "img", "task4.png");
            pictureBoxFormula.ImageLocation = imagePath;
            pictureBoxFormula.Location = new Point(20, 20);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(600, 50);
            pictureBoxFormula.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula.TabIndex = 0;
            pictureBoxFormula.TabStop = false;

            // textBoxResult
            // 
            textBoxResult.Location = new Point(20, 90);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(600, 200);
            textBoxResult.TabIndex = 1;
            textBoxResult.Font = new Font("Courier New", 9f);

            // buttonExecute
            // 
            buttonExecute.Location = new Point(420, 300);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(90, 25);
            buttonExecute.TabIndex = 2;
            buttonExecute.Text = "Выполнить";
            buttonExecute.Click += buttonExecute_Click;

            // buttonSave
            // 
            buttonSave.Location = new Point(520, 300);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(90, 25);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.Click += buttonSave_Click;

            // buttonInfo
            // 
            buttonInfo.Location = new Point(620, 300);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(30, 25);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "?";
            buttonInfo.Click += buttonInfo_Click;

            // FormMain
            // 
            ClientSize = new Size(670, 340);
            Controls.Add(pictureBoxFormula);
            Controls.Add(textBoxResult);
            Controls.Add(buttonExecute);
            Controls.Add(buttonSave);
            Controls.Add(buttonInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Task 4 | Нгаргондо Т. | Вариант 2";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}