using System;
using System.Data;
using System.Windows.Forms;

namespace lab7_Serov
{
    public partial class TableViewForm : Form
    {
        private string connectionString;
        private string tableName;

        private DataGridView dataGridView1;
        private Label lblQuery;
        private Button btnShowAll;
        private Button btnEdit;
        private Button btnClose;
        private ComboBox comboField;
        private TextBox txtFilterValue;
        private Button btnFilter;
        private CheckedListBox checkedListBoxColumns;
        private Button btnVerticalSlice;

        public TableViewForm(string connectionString, string tableName)
        {
            this.connectionString = connectionString;
            this.tableName = tableName;

            InitializeComponents();
            LoadTableColumns();
            ShowAllData();
        }

        private void InitializeComponents()
        {
            this.Text = $"Просмотр таблицы: {tableName} - Серов";
            this.Size = new System.Drawing.Size(900, 680);
            this.StartPosition = FormStartPosition.CenterScreen;

            int xPos = 20;
            int yPos = 20;

            lblQuery = new Label();
            lblQuery.Location = new System.Drawing.Point(xPos, yPos);
            lblQuery.Size = new System.Drawing.Size(850, 30);
            lblQuery.Text = "Запрос:";
            yPos += 40;

            dataGridView1 = new DataGridView();
            dataGridView1.Location = new System.Drawing.Point(xPos, yPos);
            dataGridView1.Size = new System.Drawing.Size(850, 300);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            yPos += 320;

            btnShowAll = new Button();
            btnShowAll.Text = "Просмотр всей таблицы";
            btnShowAll.Location = new System.Drawing.Point(xPos, yPos);
            btnShowAll.Size = new System.Drawing.Size(150, 30);
            btnShowAll.Click += BtnShowAll_Click;
            xPos += 160;

            btnEdit = new Button();
            btnEdit.Text = "Изменить";
            btnEdit.Location = new System.Drawing.Point(xPos, yPos);
            btnEdit.Size = new System.Drawing.Size(100, 30);
            btnEdit.Click += BtnEdit_Click;
            xPos += 110;

            btnClose = new Button();
            btnClose.Text = "Закрыть";
            btnClose.Location = new System.Drawing.Point(xPos, yPos);
            btnClose.Size = new System.Drawing.Size(100, 30);
            btnClose.Click += (s, e) => this.Close();

            xPos = 20;
            yPos += 40;

            Label lblHorizontal = new Label();
            lblHorizontal.Text = "Горизонтальный срез (WHERE):";
            lblHorizontal.Location = new System.Drawing.Point(xPos, yPos);
            lblHorizontal.Size = new System.Drawing.Size(200, 25);
            xPos += 210;

            comboField = new ComboBox();
            comboField.Location = new System.Drawing.Point(xPos, yPos);
            comboField.Size = new System.Drawing.Size(150, 25);
            xPos += 160;

            txtFilterValue = new TextBox();
            txtFilterValue.Location = new System.Drawing.Point(xPos, yPos);
            txtFilterValue.Size = new System.Drawing.Size(150, 25);
            xPos += 160;

            btnFilter = new Button();
            btnFilter.Text = "Фильтровать";
            btnFilter.Location = new System.Drawing.Point(xPos, yPos);
            btnFilter.Size = new System.Drawing.Size(100, 25);
            btnFilter.Click += BtnFilter_Click;

            xPos = 20;
            yPos += 40;

            Label lblVertical = new Label();
            lblVertical.Text = "Вертикальный срез (столбцы):";
            lblVertical.Location = new System.Drawing.Point(xPos, yPos);
            lblVertical.Size = new System.Drawing.Size(200, 25);
            yPos += 30;

            checkedListBoxColumns = new CheckedListBox();
            checkedListBoxColumns.Location = new System.Drawing.Point(xPos, yPos);
            checkedListBoxColumns.Size = new System.Drawing.Size(200, 100);
            yPos += 110;

            btnVerticalSlice = new Button();
            btnVerticalSlice.Text = "Показать выбранные столбцы";
            btnVerticalSlice.Location = new System.Drawing.Point(xPos, yPos);
            btnVerticalSlice.Size = new System.Drawing.Size(200, 30);
            btnVerticalSlice.Click += BtnVerticalSlice_Click;

            this.Controls.Add(lblQuery);
            this.Controls.Add(dataGridView1);
            this.Controls.Add(btnShowAll);
            this.Controls.Add(btnEdit);
            this.Controls.Add(btnClose);
            this.Controls.Add(lblHorizontal);
            this.Controls.Add(comboField);
            this.Controls.Add(txtFilterValue);
            this.Controls.Add(btnFilter);
            this.Controls.Add(lblVertical);
            this.Controls.Add(checkedListBoxColumns);
            this.Controls.Add(btnVerticalSlice);
        }

        private void LoadTableColumns()
        {
            try
            {
                using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = $"PRAGMA table_info({tableName})";

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string columnName = reader["name"].ToString();
                            comboField.Items.Add(columnName);
                            checkedListBoxColumns.Items.Add(columnName, true);
                        }
                    }

                    if (comboField.Items.Count > 0)
                        comboField.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки столбцов: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecuteQuery(string query)
        {
            try
            {
                lblQuery.Text = $"Запрос: {query}";

                using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (var adapter = new System.Data.SQLite.SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAllData()
        {
            string query = $"SELECT * FROM {tableName}";
            ExecuteQuery(query);
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            if (comboField.SelectedItem == null || string.IsNullOrEmpty(txtFilterValue.Text))
            {
                MessageBox.Show("Выберите поле и введите значение для фильтрации", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string field = comboField.SelectedItem.ToString();
            string value = txtFilterValue.Text;

            string query = $"SELECT * FROM {tableName} WHERE {field} = @value";
            ExecuteQueryWithParameter(query, field, value);
        }

        private void ExecuteQueryWithParameter(string query, string paramName, string paramValue)
        {
            try
            {
                lblQuery.Text = $"Запрос: {query.Replace("@value", paramValue)}";

                using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@value", paramValue);

                        using (var adapter = new System.Data.SQLite.SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVerticalSlice_Click(object sender, EventArgs e)
        {
            string columns = "";
            for (int i = 0; i < checkedListBoxColumns.Items.Count; i++)
            {
                if (checkedListBoxColumns.GetItemChecked(i))
                {
                    if (columns.Length > 0) columns += ", ";
                    columns += checkedListBoxColumns.Items[i].ToString();
                }
            }

            if (string.IsNullOrEmpty(columns))
            {
                MessageBox.Show("Выберите хотя бы один столбец", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"SELECT {columns} FROM {tableName}";
            ExecuteQuery(query);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (tableName == "Clients")
            {
                var editForm = new EditClientsForm(connectionString);
                editForm.ShowDialog();
                ShowAllData();
            }
            else if (tableName == "Products")
            {
                var editForm = new EditProductsForm(connectionString);
                editForm.ShowDialog();
                ShowAllData();
            }
        }
    }
}