using System;
using System.Windows.Forms;
using Tyuiu.NargondoTI.Sprint6.Task6.V13.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.NargondoTI.Sprint6.Task6.V13
{
    public partial class FormMain : Form
    {
        string selectedPath = "";
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedPath = ofd.FileName;
                textBoxIn.Text = System.IO.File.ReadAllText(selectedPath);
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedPath))
            {
                MessageBox.Show("Сначала выберите файл!");
                return;
            }

            textBoxOut.Text = ds.CollectTextFromFile(selectedPath);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6, Вариант 13 — выполнено студентом Нгаргондо Т.", "Информация");
        }
    }
}
