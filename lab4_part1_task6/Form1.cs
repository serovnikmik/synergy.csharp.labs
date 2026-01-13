using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab4_part1_task6
{
    public partial class Form1 : Form
    {
        private Label labelTitle;
        private Label labelA;
        private TextBox txtNumberA;
        private Label labelB;
        private TextBox txtNumberB;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblResult;
        private Label labelError;

        public Form1()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Вариант 6. Серов. Группа VДБИ-201";
            this.Size = new Size(450, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            labelTitle = new Label();
            labelTitle.Text = "Лабораторная 4. Среднее арифметическое";
            labelTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            labelTitle.Location = new Point(20, 20);
            labelTitle.Size = new Size(400, 30);
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            labelA = new Label();
            labelA.Text = "Число A:";
            labelA.Location = new Point(20, 70);
            labelA.Size = new Size(100, 25);
            labelA.Font = new Font("Arial", 10);

            txtNumberA = new TextBox();
            txtNumberA.Name = "txtNumberA";
            txtNumberA.Location = new Point(120, 70);
            txtNumberA.Size = new Size(200, 25);
            txtNumberA.Font = new Font("Arial", 10);

            labelB = new Label();
            labelB.Text = "Число B:";
            labelB.Location = new Point(20, 110);
            labelB.Size = new Size(100, 25);
            labelB.Font = new Font("Arial", 10);

            txtNumberB = new TextBox();
            txtNumberB.Name = "txtNumberB";
            txtNumberB.Location = new Point(120, 110);
            txtNumberB.Size = new Size(200, 25);
            txtNumberB.Font = new Font("Arial", 10);

            btnCalculate = new Button();
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Text = "Вычислить среднее";
            btnCalculate.Location = new Point(20, 150);
            btnCalculate.Size = new Size(150, 35);
            btnCalculate.Font = new Font("Arial", 10);
            btnCalculate.Click += btnCalculate_Click;

            btnClear = new Button();
            btnClear.Name = "btnClear";
            btnClear.Text = "Очистить";
            btnClear.Location = new Point(180, 150);
            btnClear.Size = new Size(100, 35);
            btnClear.Font = new Font("Arial", 10);
            btnClear.Click += btnClear_Click;

            lblResult = new Label();
            lblResult.Name = "lblResult";
            lblResult.Text = "";
            lblResult.Location = new Point(20, 200);
            lblResult.Size = new Size(400, 40);
            lblResult.Font = new Font("Arial", 12, FontStyle.Bold);
            lblResult.ForeColor = Color.Blue;
            lblResult.AutoSize = false;
            lblResult.TextAlign = ContentAlignment.MiddleLeft;

            labelError = new Label();
            labelError.Text = "";
            labelError.Location = new Point(20, 250);
            labelError.Size = new Size(400, 40);
            labelError.Font = new Font("Arial", 10);
            labelError.ForeColor = Color.Red;
            labelError.AutoSize = false;
            labelError.TextAlign = ContentAlignment.TopLeft;

            this.Controls.Add(labelTitle);
            this.Controls.Add(labelA);
            this.Controls.Add(txtNumberA);
            this.Controls.Add(labelB);
            this.Controls.Add(txtNumberB);
            this.Controls.Add(btnCalculate);
            this.Controls.Add(btnClear);
            this.Controls.Add(lblResult);
            this.Controls.Add(labelError);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            lblResult.Text = "";

            string inputA = txtNumberA.Text.Trim();
            string inputB = txtNumberB.Text.Trim();

            if (string.IsNullOrEmpty(inputA) || string.IsNullOrEmpty(inputB))
            {
                labelError.Text = "Ошибка: оба поля должны быть заполнены";
                return;
            }

            if (!double.TryParse(inputA, out double a))
            {
                labelError.Text = "Ошибка: число A должно быть числом";
                return;
            }

            if (!double.TryParse(inputB, out double b))
            {
                labelError.Text = "Ошибка: число B должно быть числом";
                return;
            }

            try
            {
                double average = (a + b) / 2.0;
                lblResult.Text = $"Среднее: {average:F2}";
            }
            catch (Exception ex)
            {
                labelError.Text = $"Ошибка вычисления: {ex.Message}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberA.Text = "";
            txtNumberB.Text = "";
            lblResult.Text = "";
            labelError.Text = "";
        }
    }
}