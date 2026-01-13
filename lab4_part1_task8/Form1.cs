using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab4_part1_task8
{
    public partial class Form1 : Form
    {
        private Label labelTitle;
        private Label labelSize;
        private NumericUpDown numSize;
        private Button btnGenerate;
        private DataGridView dataGridView1;
        private Button btnCalculate;
        private Button btnClear;
        private ListBox listBoxResult;
        private Label lblCount;
        private Label labelError;
        private Random random;

        public Form1()
        {
            random = new Random();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Вариант 8. Серов. Группа VДБИ-201";
            this.Size = new Size(700, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            labelTitle = new Label();
            labelTitle.Text = "Лабораторная 4. Положительные на главной диагонали";
            labelTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            labelTitle.Location = new Point(20, 20);
            labelTitle.Size = new Size(650, 30);
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            labelSize = new Label();
            labelSize.Text = "Размер квадратной матрицы:";
            labelSize.Location = new Point(20, 70);
            labelSize.Size = new Size(180, 25);
            labelSize.Font = new Font("Arial", 10);

            numSize = new NumericUpDown();
            numSize.Name = "numSize";
            numSize.Location = new Point(210, 70);
            numSize.Size = new Size(100, 25);
            numSize.Minimum = 2;
            numSize.Maximum = 10;
            numSize.Value = 5;
            numSize.Font = new Font("Arial", 10);

            btnGenerate = new Button();
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Text = "Сгенерировать матрицу";
            btnGenerate.Location = new Point(320, 70);
            btnGenerate.Size = new Size(150, 25);
            btnGenerate.Font = new Font("Arial", 10);
            btnGenerate.Click += btnGenerate_Click;

            dataGridView1 = new DataGridView();
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Location = new Point(20, 110);
            dataGridView1.Size = new Size(450, 300);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            btnCalculate = new Button();
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Text = "Найти положительные";
            btnCalculate.Location = new Point(20, 420);
            btnCalculate.Size = new Size(150, 35);
            btnCalculate.Font = new Font("Arial", 10);
            btnCalculate.Click += btnCalculate_Click;

            btnClear = new Button();
            btnClear.Name = "btnClear";
            btnClear.Text = "Очистить";
            btnClear.Location = new Point(180, 420);
            btnClear.Size = new Size(100, 35);
            btnClear.Font = new Font("Arial", 10);
            btnClear.Click += btnClear_Click;

            listBoxResult = new ListBox();
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Location = new Point(500, 110);
            listBoxResult.Size = new Size(170, 200);
            listBoxResult.Font = new Font("Arial", 10);

            lblCount = new Label();
            lblCount.Name = "lblCount";
            lblCount.Text = "";
            lblCount.Location = new Point(500, 320);
            lblCount.Size = new Size(170, 40);
            lblCount.Font = new Font("Arial", 11, FontStyle.Bold);
            lblCount.ForeColor = Color.Blue;
            lblCount.AutoSize = false;
            lblCount.TextAlign = ContentAlignment.MiddleLeft;

            labelError = new Label();
            labelError.Text = "";
            labelError.Location = new Point(20, 470);
            labelError.Size = new Size(650, 40);
            labelError.Font = new Font("Arial", 10);
            labelError.ForeColor = Color.Red;
            labelError.AutoSize = false;
            labelError.TextAlign = ContentAlignment.TopLeft;

            this.Controls.Add(labelTitle);
            this.Controls.Add(labelSize);
            this.Controls.Add(numSize);
            this.Controls.Add(btnGenerate);
            this.Controls.Add(dataGridView1);
            this.Controls.Add(btnCalculate);
            this.Controls.Add(btnClear);
            this.Controls.Add(listBoxResult);
            this.Controls.Add(lblCount);
            this.Controls.Add(labelError);

            GenerateMatrix((int)numSize.Value);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateMatrix((int)numSize.Value);
            listBoxResult.Items.Clear();
            lblCount.Text = "";
            labelError.Text = "";
        }

        private void GenerateMatrix(int size)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < size; i++)
            {
                dataGridView1.Columns.Add($"col{i}", "");
                dataGridView1.Columns[i].Width = 40;
            }

            for (int i = 0; i < size; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = 25;

                for (int j = 0; j < size; j++)
                {
                    int value = random.Next(-10, 11);
                    dataGridView1.Rows[i].Cells[j].Value = value;
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            lblCount.Text = "";
            labelError.Text = "";

            int size = (int)numSize.Value;

            if (dataGridView1.Rows.Count < size || dataGridView1.Columns.Count < size)
            {
                labelError.Text = "Ошибка: матрица не сгенерирована";
                return;
            }

            try
            {
                int count = 0;

                for (int i = 0; i < size; i++)
                {
                    var cellValue = dataGridView1.Rows[i].Cells[i].Value;

                    if (cellValue == null)
                    {
                        labelError.Text = $"Ошибка: ячейка [{i},{i}] пустая";
                        return;
                    }

                    if (!int.TryParse(cellValue.ToString(), out int value))
                    {
                        labelError.Text = $"Ошибка: ячейка [{i},{i}] не число";
                        return;
                    }

                    if (value > 0)
                    {
                        listBoxResult.Items.Add($"a[{i},{i}] = {value}");
                        count++;
                    }
                }

                lblCount.Text = $"Найдено: {count} положительных";
            }
            catch (Exception ex)
            {
                labelError.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            lblCount.Text = "";
            labelError.Text = "";
        }
    }
}