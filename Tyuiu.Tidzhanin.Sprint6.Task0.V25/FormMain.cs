using System;
using System.Text;
using System.Windows.Forms;
using Tyuiu.NargondoTI.Sprint6.Task0.V25.Lib;

namespace Tyuiu.NargondoTI.Sprint6.Task0.V25
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
                int x = 3; // заданное значение x
                double result = ds.Calculate(x);

                textBoxResult.Text = $"Результат при x = {x}: {result:F3}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 Sprint6, вариант 25 выполнен студентом Нгаргондо Тиджани", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}