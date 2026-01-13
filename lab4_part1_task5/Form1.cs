using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab4_part1_task5
{
    public partial class Form1 : Form
    {
        private Label labelTitle;
        private GroupBox groupBoxSize;
        private Label labelRows;
        private NumericUpDown numRows;
        private Label labelCols;
        private NumericUpDown numCols;
        private Button btnCreate;
        private DataGridView dataGridView1;
        private Button btnFind;
        private Button btnClear;
        private GroupBox groupBoxResult;
        private Label labelValue;
        private TextBox txtValue;
        private Label labelPosition;
        private TextBox txtPosition;
        private Label labelAbsValue;
        private TextBox txtAbsValue;
        private Label labelError;
        private Random random;

        public Form1()
        {
            random = new Random();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Вариант 5. Серов. Группа VДБИ-201";
            this.Size = new Size(800, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            labelTitle = new Label();
            labelTitle.Text = "Лабораторная 4. Наибольший по модулю элемент";
            labelTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            labelTitle.Location = new Point(20, 20);
            labelTitle.Size = new Size(750, 30);
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            groupBoxSize = new GroupBox();
            groupBoxSize.Text = "Размер матрицы";
            groupBoxSize.Location = new Point(20, 70);
            groupBoxSize.Size = new Size(350, 100);
            groupBoxSize.Font = new Font("Arial", 10, FontStyle.Bold);

            labelRows = new Label();
            labelRows.Text = "Строки:";
            labelRows.Location = new Point(20, 30);
            labelRows.Size = new Size(80, 25);
            labelRows.Font = new Font("Arial", 10);

            numRows = new NumericUpDown();
            numRows.Name = "numRows";
            numRows.Location = new Point(100, 30);
            numRows.Size = new Size(80, 25);
            numRows.Minimum = 2;
            numRows.Maximum = 10;
            numRows.Value = 4;
            numRows.Font = new Font("Arial", 10);

            labelCols = new Label();
            labelCols.Text = "Столбцы:";
            labelCols.Location = new Point(200, 30);
            labelCols.Size = new Size(80, 25);
            labelCols.Font = new Font("Arial", 10);

            numCols = new NumericUpDown();
            numCols.Name = "numCols";
            numCols.Location = new Point(280, 30);
            numCols.Size = new Size(80, 25);
            numCols.Minimum = 2;
            numCols.Maximum = 10;
            numCols.Value = 5;
            numCols.Font = new Font("Arial", 10);

            btnCreate = new Button();
            btnCreate.Name = "btnCreate";
            btnCreate.Text = "Создать матрицу";
            btnCreate.Location = new Point(100, 65);
            btnCreate.Size = new Size(150, 25);
            btnCreate.Font = new Font("Arial", 10);
            btnCreate.Click += btnCreate_Click;

            groupBoxSize.Controls.Add(labelRows);
            groupBoxSize.Controls.Add(numRows);
            groupBoxSize.Controls.Add(labelCols);
            groupBoxSize.Controls.Add(numCols);
            groupBoxSize.Controls.Add(btnCreate);

            dataGridView1 = new DataGridView();
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Location = new Point(20, 180);
            dataGridView1.Size = new Size(500, 300);
            dataGridView1.Font = new Font("Arial", 10);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            btnFind = new Button();
            btnFind.Name = "btnFind";
            btnFind.Text = "Найти максимальный по модулю";
            btnFind.Location = new Point(20, 490);
            btnFind.Size = new Size(220, 35);
            btnFind.Font = new Font("Arial", 9);
            btnFind.Click += btnFind_Click;

            btnClear = new Button();
            btnClear.Name = "btnClear";
            btnClear.Text = "Очистить";
            btnClear.Location = new Point(250, 490);
            btnClear.Size = new Size(100, 35);
            btnClear.Font = new Font("Arial", 10);
            btnClear.Click += btnClear_Click;

            groupBoxResult = new GroupBox();
            groupBoxResult.Text = "Результат";
            groupBoxResult.Location = new Point(530, 180);
            groupBoxResult.Size = new Size(240, 250);
            groupBoxResult.Font = new Font("Arial", 10, FontStyle.Bold);

            labelValue = new Label();
            labelValue.Text = "Значение:";
            labelValue.Location = new Point(10, 30);
            labelValue.Size = new Size(100, 25);
            labelValue.Font = new Font("Arial", 10);

            txtValue = new TextBox();
            txtValue.Name = "txtValue";
            txtValue.Location = new Point(120, 30);
            txtValue.Size = new Size(100, 25);
            txtValue.Font = new Font("Arial", 10);
            txtValue.ReadOnly = true;

            labelPosition = new Label();
            labelPosition.Text = "Позиция:";
            labelPosition.Location = new Point(10, 70);
            labelPosition.Size = new Size(100, 25);
            labelPosition.Font = new Font("Arial", 10);

            txtPosition = new TextBox();
            txtPosition.Name = "txtPosition";
            txtPosition.Location = new Point(120, 70);
            txtPosition.Size = new Size(100, 25);
            txtPosition.Font = new Font("Arial", 10);
            txtPosition.ReadOnly = true;

            labelAbsValue = new Label();
            labelAbsValue.Text = "Модуль:";
            labelAbsValue.Location = new Point(10, 110);
            labelAbsValue.Size = new Size(100, 25);
            labelAbsValue.Font = new Font("Arial", 10);

            txtAbsValue = new TextBox();
            txtAbsValue.Name = "txtAbsValue";
            txtAbsValue.Location = new Point(120, 110);
            txtAbsValue.Size = new Size(100, 25);
            txtAbsValue.Font = new Font("Arial", 10);
            txtAbsValue.ReadOnly = true;

            groupBoxResult.Controls.Add(labelValue);
            groupBoxResult.Controls.Add(txtValue);
            groupBoxResult.Controls.Add(labelPosition);
            groupBoxResult.Controls.Add(txtPosition);
            groupBoxResult.Controls.Add(labelAbsValue);
            groupBoxResult.Controls.Add(txtAbsValue);

            labelError = new Label();
            labelError.Text = "";
            labelError.Location = new Point(20, 540);
            labelError.Size = new Size(750, 40);
            labelError.Font = new Font("Arial", 10);
            labelError.ForeColor = Color.Red;
            labelError.AutoSize = false;
            labelError.TextAlign = ContentAlignment.TopLeft;

            this.Controls.Add(labelTitle);
            this.Controls.Add(groupBoxSize);
            this.Controls.Add(dataGridView1);
            this.Controls.Add(btnFind);
            this.Controls.Add(btnClear);
            this.Controls.Add(groupBoxResult);
            this.Controls.Add(labelError);

            CreateMatrix((int)numRows.Value, (int)numCols.Value);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateMatrix((int)numRows.Value, (int)numCols.Value);
            ClearResults();
            labelError.Text = "";
        }

        private void CreateMatrix(int rows, int cols)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < cols; i++)
            {
                dataGridView1.Columns.Add($"col{i}", "");
                dataGridView1.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = 25;

                for (int j = 0; j < cols; j++)
                {
                    int value = random.Next(-20, 21);
                    dataGridView1.Rows[i].Cells[j].Value = value;
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ClearResults();
            labelError.Text = "";

            int rows = dataGridView1.Rows.Count;
            int cols = dataGridView1.Columns.Count;

            if (rows == 0 || cols == 0)
            {
                labelError.Text = "Ошибка: матрица не создана";
                return;
            }

            try
            {
                double maxAbsValue = -1;
                double foundValue = 0;
                int foundRow = -1;
                int foundCol = -1;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        var cellValue = dataGridView1.Rows[i].Cells[j].Value;

                        if (cellValue == null)
                        {
                            labelError.Text = $"Ошибка: ячейка [{i},{j}] пустая";
                            return;
                        }

                        if (!double.TryParse(cellValue.ToString(), out double value))
                        {
                            labelError.Text = $"Ошибка: ячейка [{i},{j}] не число";
                            return;
                        }

                        double absValue = Math.Abs(value);

                        if (absValue > maxAbsValue)
                        {
                            maxAbsValue = absValue;
                            foundValue = value;
                            foundRow = i;
                            foundCol = j;
                        }
                    }
                }

                if (foundRow != -1 && foundCol != -1)
                {
                    txtValue.Text = foundValue.ToString();
                    txtPosition.Text = $"[{foundRow},{foundCol}]";
                    txtAbsValue.Text = maxAbsValue.ToString();
                }
                else
                {
                    labelError.Text = "Не найдено элементов";
                }
            }
            catch (Exception ex)
            {
                labelError.Text = $"Ошибка: {ex.Message}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearResults();
            labelError.Text = "";
        }

        private void ClearResults()
        {
            txtValue.Text = "";
            txtPosition.Text = "";
            txtAbsValue.Text = "";
        }
    }
}