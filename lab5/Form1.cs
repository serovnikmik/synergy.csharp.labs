using System;
using System.Windows.Forms;

namespace lab5_Serov
{
    public partial class Form1 : Form
    {
        private double firstArgument;
        private double secondArgument;
        private bool point = true;

        private enum Actions
        {
            Plus,
            Minus,
            Multiply,
            Divide
        }

        private Actions action;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Калькулятор - Серов";
            this.Size = new System.Drawing.Size(350, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(20, 20);
            textBox1.Size = new System.Drawing.Size(290, 30);
            textBox1.Font = new System.Drawing.Font("Arial", 14);
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.ReadOnly = true;

            string[] buttonLabels =
            {
                "7", "8", "9", "/", "C",
                "4", "5", "6", "*", "±",
                "1", "2", "3", "-", "",
                "0", ",", "=", "+", ""
            };

            int xPos = 20;
            int yPos = 70;
            int buttonWidth = 50;
            int buttonHeight = 50;
            int spacing = 10;

            for (int i = 0; i < buttonLabels.Length; i++)
            {
                if (buttonLabels[i] != "")
                {
                    Button btn = new Button();
                    btn.Text = buttonLabels[i];
                    btn.Location = new System.Drawing.Point(xPos, yPos);
                    btn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                    btn.Font = new System.Drawing.Font("Arial", 12);

                    switch (buttonLabels[i])
                    {
                        case "0": btn.Click += button0_Click; break;
                        case "1": btn.Click += button1_Click; break;
                        case "2": btn.Click += button2_Click; break;
                        case "3": btn.Click += button3_Click; break;
                        case "4": btn.Click += button4_Click; break;
                        case "5": btn.Click += button5_Click; break;
                        case "6": btn.Click += button6_Click; break;
                        case "7": btn.Click += button7_Click; break;
                        case "8": btn.Click += button8_Click; break;
                        case "9": btn.Click += button9_Click; break;
                        case "+": btn.Click += buttonPlus_Click; break;
                        case "-": btn.Click += buttonMinus_Click; break;
                        case "*": btn.Click += buttonMultiply_Click; break;
                        case "/": btn.Click += buttonDivide_Click; break;
                        case "=": btn.Click += buttonEquals_Click; break;
                        case ",": btn.Click += buttonPoint_Click; break;
                        case "±": btn.Click += buttonSign_Click; break;
                        case "C": btn.Click += buttonClear_Click; break;
                    }

                    this.Controls.Add(btn);
                }

                xPos += buttonWidth + spacing;

                if ((i + 1) % 5 == 0)
                {
                    xPos = 20;
                    yPos += buttonHeight + spacing;
                }
            }

            this.Controls.Add(textBox1);
        }

        private TextBox textBox1;

        private bool TryGetArgument(out double value)
        {
            value = 0;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Введите число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string input = textBox1.Text.Replace('.', ',');

            try
            {
                value = Convert.ToDouble(input);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private double Solution(Actions ac, double a, double b)
        {
            switch (ac)
            {
                case Actions.Plus:
                    return a + b;
                case Actions.Minus:
                    return a - b;
                case Actions.Multiply:
                    return a * b;
                case Actions.Divide:
                    if (b == 0)
                    {
                        MessageBox.Show("Деление на ноль невозможно", "Ошибка",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                    return a / b;
                default:
                    return 0;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (TryGetArgument(out firstArgument))
            {
                action = Actions.Plus;
                point = true;
                textBox1.Text = "";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (TryGetArgument(out firstArgument))
            {
                action = Actions.Minus;
                point = true;
                textBox1.Text = "";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (TryGetArgument(out firstArgument))
            {
                action = Actions.Multiply;
                point = true;
                textBox1.Text = "";
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (TryGetArgument(out firstArgument))
            {
                action = Actions.Divide;
                point = true;
                textBox1.Text = "";
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (point)
            {
                textBox1.Text += ",";
                point = false;
            }
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (TryGetArgument(out double value))
            {
                value = -value;
                textBox1.Text = value.ToString();
                point = !textBox1.Text.Contains(",");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            firstArgument = 0;
            secondArgument = 0;
            point = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (TryGetArgument(out secondArgument))
            {
                double result = Solution(action, firstArgument, secondArgument);
                textBox1.Text = result.ToString();
                point = true;
            }
        }
    }
}