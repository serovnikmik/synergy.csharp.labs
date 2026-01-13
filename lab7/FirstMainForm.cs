using System;
using System.IO;
using System.Windows.Forms;

namespace lab7_Serov
{
    public partial class FirstMainForm : Form
    {
        private string connectionString;
        private Label lblDbPath;
        private Button btnClients;
        private Button btnProducts;
        private Button btnChooseDb;

        public FirstMainForm()
        {
            InitializeComponents();
            InitializeDatabase();
        }

        private void InitializeComponents()
        {
            this.Text = "Главное меню - Серов";
            this.Size = new System.Drawing.Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblDbPath = new Label();
            lblDbPath.Location = new System.Drawing.Point(20, 20);
            lblDbPath.Size = new System.Drawing.Size(350, 30);
            lblDbPath.Text = "База данных не выбрана";

            btnChooseDb = new Button();
            btnChooseDb.Text = "Выбрать базу данных";
            btnChooseDb.Location = new System.Drawing.Point(20, 60);
            btnChooseDb.Size = new System.Drawing.Size(150, 40);
            btnChooseDb.Click += BtnChooseDb_Click;

            btnClients = new Button();
            btnClients.Text = "Клиенты";
            btnClients.Location = new System.Drawing.Point(20, 120);
            btnClients.Size = new System.Drawing.Size(150, 60);
            btnClients.Font = new System.Drawing.Font("Arial", 12);
            btnClients.Click += BtnClients_Click;

            btnProducts = new Button();
            btnProducts.Text = "Товары";
            btnProducts.Location = new System.Drawing.Point(200, 120);
            btnProducts.Size = new System.Drawing.Size(150, 60);
            btnProducts.Font = new System.Drawing.Font("Arial", 12);
            btnProducts.Click += BtnProducts_Click;

            this.Controls.Add(lblDbPath);
            this.Controls.Add(btnChooseDb);
            this.Controls.Add(btnClients);
            this.Controls.Add(btnProducts);
        }

        private void InitializeDatabase()
        {
            string defaultDb = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.db");
            connectionString = $"Data Source={defaultDb};Version=3;";

            try
            {
                CreateTablesIfNotExist();
                lblDbPath.Text = $"Текущая БД: {Path.GetFileName(defaultDb)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации БД: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTablesIfNotExist()
        {
            using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
            {
                connection.Open();

                string createClients = @"
                    CREATE TABLE IF NOT EXISTS Clients (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT NOT NULL,
                        LastName TEXT NOT NULL,
                        Age INTEGER NOT NULL
                    )";

                string createProducts = @"
                    CREATE TABLE IF NOT EXISTS Products (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Price REAL NOT NULL
                    )";

                using (var command = new System.Data.SQLite.SQLiteCommand(createClients, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (var command = new System.Data.SQLite.SQLiteCommand(createProducts, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void BtnChooseDb_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SQLite базы данных (*.db, *.sqlite, *.sqlite3)|*.db;*.sqlite;*.sqlite3|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Выберите файл базы данных";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    connectionString = $"Data Source={openFileDialog.FileName};Version=3;";
                    CreateTablesIfNotExist();
                    lblDbPath.Text = $"Текущая БД: {Path.GetFileName(openFileDialog.FileName)}";
                    MessageBox.Show("База данных успешно подключена", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка подключения к БД: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            var form = new TableViewForm(connectionString, "Clients");
            form.Show();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            var form = new TableViewForm(connectionString, "Products");
            form.Show();
        }
    }
}