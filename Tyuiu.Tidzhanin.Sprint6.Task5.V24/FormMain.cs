using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.NargondoTI.Sprint6.Task5.V24.Lib;

namespace Tyuiu.NargondoTI.Sprint6.Task5.V24
{
    public partial class FormMain : Form
    {
        private DataService ds;
        private double[] zeros = Array.Empty<double>();

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Укажем точный путь к файлу
                string path = $@"C:\Users\{Environment.UserName}\source\repos\Tyuiu.Tidzhanin.Sprint6\Sprint6Task5\InPutFileTask5V24.txt";


                // Загружаем данные
                double[] allNumbers = ds.LoadFromDataFile(path);

                // Очищаем таблицы
                dataGridViewAll.Rows.Clear();
                dataGridViewZeros.Rows.Clear();

                // Если файл пустой
                if (allNumbers.Length == 0)
                {
                    MessageBox.Show("Файл пустой.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Добавляем все значения в первую таблицу
                foreach (double val in allNumbers)
                {
                    dataGridViewAll.Rows.Add(Math.Round(val, 3));
                }

                // Ищем нулевые значения
                zeros = allNumbers.Where(val => Math.Abs(val) < 1e-10).ToArray();

                // Добавляем только нулевые значения во вторую таблицу
                foreach (double val in zeros)
                {
                    dataGridViewZeros.Rows.Add(Math.Round(val, 3));
                }

                // Если нет нулевых значений, показываем сообщение
                if (zeros.Length == 0)
                {
                    MessageBox.Show("В файле нет чисел равных 0.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Обновляем график
                pictureBoxChart.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int x = 20, y = 20;

            if (zeros.Length == 0)
            {
                // Если нет нулевых значений, показываем сообщение
                g.DrawString("Нет нулевых элементов для отображения",
                            new Font("Arial", 12, FontStyle.Bold),
                            Brushes.Red, x, y);
                return;
            }

            int barHeight = 20;
            int maxWidth = pictureBoxChart.Width - 100;

            // Рисуем диаграмму для нулевых значений
            g.DrawString($"Количество нулевых элементов: {zeros.Length}",
                        new Font("Arial", 10, FontStyle.Bold),
                        Brushes.Black, x, y);
            y += 30;

            // Рисуем столбцы для каждого нулевого элемента
            for (int i = 0; i < zeros.Length; i++)
            {
                int barWidth = 50; // фиксированная ширина для нулей
                g.FillRectangle(Brushes.LightBlue, x, y, barWidth, barHeight);
                g.DrawRectangle(Pens.Black, x, y, barWidth, barHeight);
                g.DrawString($"0 (элемент {i + 1})", this.Font, Brushes.Black, x + barWidth + 5, y);
                y += barHeight + 5;
            }
        }
    
            
        

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 Sprint6, вариант 24 выполнен студентом Нгаргондо Тиджани", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}