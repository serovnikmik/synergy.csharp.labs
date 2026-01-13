using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab4_part1_task1
{
    public partial class Form1 : Form
    {
        private Label labelTitle;
        private Label labelInstruction;
        private TextBox textBoxNumber;
        private Button buttonCalculate;
        private Button buttonClear;
        private Label labelResult;
        private Label labelError;

        public Form1()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Вариант 1. Serov. Группа VДБИ-201";
            this.Size = new Size(450, 380);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            labelTitle = new Label();
            labelTitle.Text = "Лабораторная 4. Сумма четных цифр числа";
            labelTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            labelTitle.Location = new Point(20, 20);
            labelTitle.Size = new Size(400, 30);
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            labelInstruction = new Label();
            labelInstruction.Text = "Введите целое число:";
            labelInstruction.Location = new Point(20, 70);
            labelInstruction.Size = new Size(200, 25);
            labelInstruction.Font = new Font("Arial", 10);

            textBoxNumber = new TextBox();
            textBoxNumber.Location = new Point(20, 100);
            textBoxNumber.Size = new Size(250, 25);
            textBoxNumber.Font = new Font("Arial", 10);

            buttonCalculate = new Button();
            buttonCalculate.Text = "Вычислить сумму";
            buttonCalculate.Location = new Point(20, 140);
            buttonCalculate.Size = new Size(150, 35);
            buttonCalculate.Font = new Font("Arial", 10);
            buttonCalculate.Click += buttonCalculate_Click;

            buttonClear = new Button();
            buttonClear.Text = "Очистить";
            buttonClear.Location = new Point(180, 140);
            buttonClear.Size = new Size(100, 35);
            buttonClear.Font = new Font("Arial", 10);
            buttonClear.Click += buttonClear_Click;

            labelResult = new Label();
            labelResult.Text = "";
            labelResult.Location = new Point(20, 190);
            labelResult.Size = new Size(400, 50);
            labelResult.Font = new Font("Arial", 11, FontStyle.Bold);
            labelResult.ForeColor = Color.Blue;
            labelResult.AutoSize = false;
            labelResult.TextAlign = ContentAlignment.TopLeft;

            labelError = new Label();
            labelError.Text = "";
            labelError.Location = new Point(20, 250);
            labelError.Size = new Size(400, 40);
            labelError.Font = new Font("Arial", 10);
            labelError.ForeColor = Color.Red;
            labelError.AutoSize = false;
            labelError.TextAlign = ContentAlignment.TopLeft;

            this.Controls.Add(labelTitle);
            this.Controls.Add(labelInstruction);
            this.Controls.Add(textBoxNumber);
            this.Controls.Add(buttonCalculate);
            this.Controls.Add(buttonClear);
            this.Controls.Add(labelResult);
            this.Controls.Add(labelError);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            labelResult.Text = "";

            string input = textBoxNumber.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                labelError.Text = "Ошибка: поле не может быть пустым";
                return;
            }

            if (!long.TryParse(input, out long number))
            {
                labelError.Text = "Ошибка: введите целое число (до 19 цифр)";
                return;
            }

            long sum = 0;
            long temp = Math.Abs(number);

            while (temp > 0)
            {
                long digit = temp % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                temp /= 10;
            }

            string numberStr = number.ToString();
            if (numberStr.Length > 20)
            {
                labelResult.Text = $"Число: {numberStr.Substring(0, 20)}...\n" +
                                   $"Сумма чётных цифр: {sum}";
            }
            else
            {
                labelResult.Text = $"Число: {number}\n" +
                                   $"Сумма чётных цифр: {sum}";
            }

            if (numberStr.Length > 15)
            {
                labelResult.Font = new Font("Arial", 10, FontStyle.Bold);
            }
            else
            {
                labelResult.Font = new Font("Arial", 11, FontStyle.Bold);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNumber.Text = "";
            labelResult.Text = "";
            labelError.Text = "";
            labelResult.Font = new Font("Arial", 11, FontStyle.Bold);
        }
    }
}