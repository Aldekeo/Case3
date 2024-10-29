using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        double value = 0;
        string operation = "";
        double MemValue = 0;

        int themeoperator = 0;

        //Обработка вывода нажатия цифер
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Добавляем цифру из текста кнопки к отображаемому значению
                textBox1.Text += button.Text;
            }
        }

        //Удаление содержимого окна
        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            value = 0;
            operation = "";
        }

        //Запись выполняемой операции и числа до него
        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                operation = button.Text;
                value = double.Parse(textBox1.Text);
                textBox1.Text = null;
            }
        }

        //Обработка "равно"
        private void itog_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        if (double.Parse(textBox1.Text) != 0)
                        {
                            textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка расчетов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = null;
                            value = 0;
                            operation = "";
                        }
                        break;
                }

                //Сброс
                operation = "";
            }
        }

        //Font newFont = new Font("Arial", 102, FontStyle.Bold);

        //Обработка кнопки для смены шрифтов
        private void SF_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                //Запоминаем шрифт
                Font selectedFont = fontDialog.Font;

                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    control.Font = selectedFont;
                }
            }
        }

        //Очистка ячейки памяти
        private void Mclear_Click(object sender, EventArgs e)
        {
            MemValue = 0;
        }

        //Вызов числа из памяти
        private void Mrecall_Click(object sender, EventArgs e)
        {
            textBox1.Text = MemValue.ToString();
        }

        //Сохранения числа в память
        private void Msave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Нельзя сохранить пустое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MemValue = double.Parse(textBox1.Text);
            }
        }
    }
}
