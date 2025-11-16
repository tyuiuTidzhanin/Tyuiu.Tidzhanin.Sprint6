using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.NargondoTI.Sprint6.Task0.V25
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxResult;
        private Button buttonExecute;
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
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            SuspendLayout();

            // pictureBoxFormula
            // 
            string username = Environment.UserName;
            string imagePath = $"C:\\Users\\{username}\\source\\repos\\Tyuiu.NargondoTI.Sprint6\\img\\task0.png";
            pictureBoxFormula.ImageLocation = imagePath;
            pictureBoxFormula.Location = new Point(20, 20);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(400, 50);
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
            textBoxResult.Size = new Size(400, 80);
            textBoxResult.TabIndex = 1;

            // buttonExecute
            // 
            buttonExecute.Location = new Point(240, 180);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(90, 25);
            buttonExecute.TabIndex = 2;
            buttonExecute.Text = "Выполнить";
            buttonExecute.Click += buttonExecute_Click;

            // buttonInfo
            // 
            buttonInfo.Location = new Point(340, 180);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(30, 25);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "?";
            buttonInfo.Click += buttonInfo_Click;

            // FormMain
            // 
            ClientSize = new Size(450, 220);
            Controls.Add(pictureBoxFormula);
            Controls.Add(textBoxResult);
            Controls.Add(buttonExecute);
            Controls.Add(buttonInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Task 0 | Нгаргондо Т. | Вариант 25";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}