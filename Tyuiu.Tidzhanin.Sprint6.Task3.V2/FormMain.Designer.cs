using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.NargondoTI.Sprint6.Task3.V2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTask;
        private TextBox textBoxTask;
        private DataGridView dataGridViewResult;
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
            labelTask = new Label();
            textBoxTask = new TextBox();
            dataGridViewResult = new DataGridView();
            buttonExecute = new Button();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();

            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(20, 20);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(78, 15);
            labelTask.TabIndex = 0;
            labelTask.Text = "Условие:";
            labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Bold);

            // textBoxTask
            // 
            textBoxTask.Location = new Point(20, 45);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.ScrollBars = ScrollBars.Vertical;
            textBoxTask.Size = new Size(400, 80);
            textBoxTask.TabIndex = 1;
            textBoxTask.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0.\r\n\r\nИсходный массив:\r\n-12  -4 -20   5  -5\r\n  2  15   1 -20   7\r\n 15 -15   2  11   5\r\n-19  -9  16   0   1\r\n 17  16   5  12  -8";

            // dataGridViewResult
            // 
            dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewResult.AllowUserToDeleteRows = false;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(20, 140);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.Size = new Size(400, 150);
            dataGridViewResult.TabIndex = 2;

            // buttonExecute
            // 
            buttonExecute.Location = new Point(240, 300);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(90, 25);
            buttonExecute.TabIndex = 3;
            buttonExecute.Text = "Выполнить";
            buttonExecute.Click += buttonExecute_Click;

            // buttonInfo
            // 
            buttonInfo.Location = new Point(340, 300);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(30, 25);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "?";
            buttonInfo.Click += buttonInfo_Click;

            // FormMain
            // 
            ClientSize = new Size(450, 340);
            Controls.Add(labelTask);
            Controls.Add(textBoxTask);
            Controls.Add(dataGridViewResult);
            Controls.Add(buttonExecute);
            Controls.Add(buttonInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Task 3 | Нгаргондо Т. | Вариант 2";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}