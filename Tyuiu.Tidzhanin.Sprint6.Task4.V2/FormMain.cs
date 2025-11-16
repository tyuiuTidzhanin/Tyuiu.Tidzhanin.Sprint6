using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Tyuiu.NargondoTI.Sprint6.Task4.V2.Lib;

namespace Tyuiu.NargondoTI.Sprint6.Task4.V2
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
                int start = -5;
                int stop = 5;

                double[] results = ds.GetMassFunction(start, stop);

                // Вывод в textBox
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("***************************");
                sb.AppendLine("*     x      *    f(x)    *");
                sb.AppendLine("***************************");

                for (int i = 0; i < results.Length; i++)
                {
                    sb.AppendLine($"*    {start + i,2}     *  {results[i],8:F2}  *");
                }

                sb.AppendLine("***************************");
                textBoxResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V2.txt";
                File.WriteAllText(path, textBoxResult.Text);

                MessageBox.Show($"Файл сохранен успешно!\nПуть: {path}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 Sprint6, вариант 2 выполнен студентом Нгаргондо Тиджани", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}