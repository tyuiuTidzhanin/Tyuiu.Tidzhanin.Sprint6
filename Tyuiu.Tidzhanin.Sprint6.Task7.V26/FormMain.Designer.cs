namespace Tyuiu.Tidzhanin.Sprint6.Task7.V26
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelOut;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewIn = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut = new System.Windows.Forms.DataGridView();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelIn = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();
            this.SuspendLayout();

            // dataGridViewIn
            this.dataGridViewIn.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewIn.Size = new System.Drawing.Size(350, 260);

            // dataGridViewOut
            this.dataGridViewOut.Location = new System.Drawing.Point(400, 60);
            this.dataGridViewOut.Size = new System.Drawing.Size(350, 260);

            // buttonOpen
            this.buttonOpen.Location = new System.Drawing.Point(20, 20);
            this.buttonOpen.Size = new System.Drawing.Size(140, 30);
            this.buttonOpen.Text = "Выбрать файл";
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);

            // buttonProcess
            this.buttonProcess.Location = new System.Drawing.Point(180, 20);
            this.buttonProcess.Size = new System.Drawing.Size(140, 30);
            this.buttonProcess.Text = "Обработать";
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);

            // buttonInfo
            this.buttonInfo.Location = new System.Drawing.Point(750, 20);
            this.buttonInfo.Size = new System.Drawing.Size(30, 30);
            this.buttonInfo.Text = "?";
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);

            // labelIn
            this.labelIn.Location = new System.Drawing.Point(20, 40);
            this.labelIn.AutoSize = true;
            this.labelIn.Text = "Входная матрица";

            // labelOut
            this.labelOut.Location = new System.Drawing.Point(400, 40);
            this.labelOut.AutoSize = true;
            this.labelOut.Text = "Результат";

            // FormMain
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.dataGridViewIn);
            this.Controls.Add(this.dataGridViewOut);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.labelOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Text = "Спринт 6 | Таск 7 | Вариант 26 | Нгаргондо Т.";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
