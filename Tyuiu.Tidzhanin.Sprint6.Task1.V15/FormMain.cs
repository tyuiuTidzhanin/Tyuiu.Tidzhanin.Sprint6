using System;
using System.Text;
using System.Windows.Forms;
using Tyuiu.NargondoTI.Sprint6.Task1.V15.Lib;

namespace Tyuiu.NargondoTI.Sprint6.Task1.V15
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
                int start = -5; // диапазон фиксирован
                int stop = 5;

                double[] results = ds.GetMassFunction(start, stop);

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

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Sprint6, вариант 15 выполнен студентом Нгаргондо Тиджани", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}