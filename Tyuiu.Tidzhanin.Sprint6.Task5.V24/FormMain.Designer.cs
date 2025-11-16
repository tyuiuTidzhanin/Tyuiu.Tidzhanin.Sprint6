using System.Windows.Forms;
using System.Drawing;

namespace Tyuiu.NargondoTI.Sprint6.Task5.V24
{
    partial class FormMain
    {
        private Button buttonLoad;
        private Button buttonInfo;
        private DataGridView dataGridViewAll;
        private DataGridView dataGridViewZeros;
        private PictureBox pictureBoxChart;
        private Label labelAll;
        private Label labelZeros;

        private void InitializeComponent()
        {
            this.buttonLoad = new Button();
            this.buttonInfo = new Button();
            this.dataGridViewAll = new DataGridView();
            this.dataGridViewZeros = new DataGridView();
            this.pictureBoxChart = new PictureBox();
            this.labelAll = new Label();
            this.labelZeros = new Label();

            // buttonLoad
            this.buttonLoad.Text = "Загрузить данные";
            this.buttonLoad.Location = new Point(20, 20);
            this.buttonLoad.Size = new Size(160, 30);
            this.buttonLoad.Click += new EventHandler(this.buttonLoad_Click);

            // buttonInfo
            this.buttonInfo.Text = "?";
            this.buttonInfo.Location = new Point(190, 20);
            this.buttonInfo.Size = new Size(30, 30);
            this.buttonInfo.Click += new EventHandler(this.buttonInfo_Click);

            // dataGridViewAll
            this.dataGridViewAll.Location = new Point(20, 80);
            this.dataGridViewAll.Size = new Size(260, 250);
            this.dataGridViewAll.ColumnCount = 1;
            this.dataGridViewAll.Columns[0].HeaderText = "Все числа";

            // dataGridViewZeros
            this.dataGridViewZeros.Location = new Point(300, 80);
            this.dataGridViewZeros.Size = (Size)new Point(260, 250);
            this.dataGridViewZeros.ColumnCount = 1;
            this.dataGridViewZeros.Columns[0].HeaderText = "Элементы = 0";

            // labelAll
            this.labelAll.Location = new Point(20, 60);
            this.labelAll.Text = "Все элементы из файла";
            this.labelAll.AutoSize = true;

            // labelZeros
            this.labelZeros.Location = new Point(300, 60);
            this.labelZeros.Text = "Элементы равные 0";
            this.labelZeros.AutoSize = true;

            // pictureBoxChart
            this.pictureBoxChart.Location = new Point(580, 60);
            this.pictureBoxChart.Size = new Size(400, 270);
            this.pictureBoxChart.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBoxChart.Paint += new PaintEventHandler(this.pictureBoxChart_Paint);

            // FormMain
            this.ClientSize = new Size(1000, 370);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.dataGridViewZeros);
            this.Controls.Add(this.pictureBoxChart);
            this.Controls.Add(this.labelAll);
            this.Controls.Add(this.labelZeros);
            this.Text = "Спринт 6 | Таск 5 | Вариант 24 | Нгаргондо Т.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
    }
}