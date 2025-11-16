using System;
using System.Windows.Forms;
using Tyuiu.NargondoTI.Sprint6.Task3.V2.Lib;

namespace Tyuiu.NargondoTI.Sprint6.Task3.V2
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matrix = new int[5, 5] {
                    { -12, -4, -20, 5, -5 },
                    { 2, 15, 1, -20, 7 },
                    { 15, -15, 2, 11, 5 },
                    { -19, -9, 16, 0, 1 },
                    { 17, 16, 5, 12, -8 }
                };

                int[,] resultMatrix = ds.Calculate(matrix);

                // Настраиваем DataGridView
                dataGridViewResult.ColumnCount = 5;
                dataGridViewResult.RowCount = 5;
                dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Заполняем заголовки столбцов
                for (int i = 0; i < 5; i++)
                {
                    dataGridViewResult.Columns[i].HeaderText = $"Столбец {i + 1}";
                }

                // Заполняем данные
                for (int i = 0; i < 5; i++)
                {
                    dataGridViewResult.Rows[i].HeaderCell.Value = $"Строка {i + 1}";
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridViewResult.Rows[i].Cells[j].Value = resultMatrix[i, j];
                    }
                }

                dataGridViewResult.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 Sprint6, вариант 2 выполнен студентом Нгаргондо Тиджани", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}