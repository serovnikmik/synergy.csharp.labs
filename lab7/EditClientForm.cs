using System;
using System.Windows.Forms;

namespace lab7_Serov
{
    public partial class EditClientsForm : Form
    {
        private string connectionString;

        private TextBox txtId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAge;
        private Button btnClear;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnClose;

        public EditClientsForm(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Редактирование клиентов - Серов";
            this.Size = new System.Drawing.Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            int xPos = 20;
            int yPos = 20;

            Label lblId = new Label();
            lblId.Text = "ID (для удаления):";
            lblId.Location = new System.Drawing.Point(xPos, yPos);
            lblId.Size = new System.Drawing.Size(150, 25);
            yPos += 30;

            txtId = new TextBox();
            txtId.Location = new System.Drawing.Point(xPos, yPos);
            txtId.Size = new System.Drawing.Size(200, 25);
            yPos += 40;

            Label lblFirstName = new Label();
            lblFirstName.Text = "Имя:";
            lblFirstName.Location = new System.Drawing.Point(xPos, yPos);
            lblFirstName.Size = new System.Drawing.Size(150, 25);
            yPos += 30;

            txtFirstName = new TextBox();
            txtFirstName.Location = new System.Drawing.Point(xPos, yPos);
            txtFirstName.Size = new System.Drawing.Size(200, 25);
            yPos += 40;

            Label lblLastName = new Label();
            lblLastName.Text = "Фамилия:";
            lblLastName.Location = new System.Drawing.Point(xPos, yPos);
            lblLastName.Size = new System.Drawing.Size(150, 25);
            yPos += 30;

            txtLastName = new TextBox();
            txtLastName.Location = new System.Drawing.Point(xPos, yPos);
            txtLastName.Size = new System.Drawing.Size(200, 25);
            yPos += 40;

            Label lblAge = new Label();
            lblAge.Text = "Возраст:";
            lblAge.Location = new System.Drawing.Point(xPos, yPos);
            lblAge.Size = new System.Drawing.Size(150, 25);
            yPos += 30;

            txtAge = new TextBox();
            txtAge.Location = new System.Drawing.Point(xPos, yPos);
            txtAge.Size = new System.Drawing.Size(200, 25);
            yPos += 50;

            btnClear = new Button();
            btnClear.Text = "Очистить";
            btnClear.Location = new System.Drawing.Point(xPos, yPos);
            btnClear.Size = new System.Drawing.Size(90, 30);
            btnClear.Click += BtnClear_Click;
            xPos += 100;

            btnInsert = new Button();
            btnInsert.Text = "Добавить";
            btnInsert.Location = new System.Drawing.Point(xPos, yPos);
            btnInsert.Size = new System.Drawing.Size(90, 30);
            btnInsert.Click += BtnInsert_Click;
            xPos += 100;

            btnDelete = new Button();
            btnDelete.Text = "Удалить";
            btnDelete.Location = new System.Drawing.Point(xPos, yPos);
            btnDelete.Size = new System.Drawing.Size(90, 30);
            btnDelete.Click += BtnDelete_Click;

            xPos = 20;
            yPos += 50;

            btnClose = new Button();
            btnClose.Text = "Закрыть";
            btnClose.Location = new System.Drawing.Point(xPos, yPos);
            btnClose.Size = new System.Drawing.Size(90, 30);
            btnClose.Click += (s, e) => this.Close();

            this.Controls.Add(lblId);
            this.Controls.Add(txtId);
            this.Controls.Add(lblFirstName);
            this.Controls.Add(txtFirstName);
            this.Controls.Add(lblLastName);
            this.Controls.Add(txtLastName);
            this.Controls.Add(lblAge);
            this.Controls.Add(txtAge);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnInsert);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClose);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0 || age > 150)
            {
                MessageBox.Show("Введите корректный возраст (1-150)", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Clients (FirstName, LastName, Age) 
                        VALUES (@firstName, @lastName, @age)";

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                        command.Parameters.AddWithValue("@lastName", txtLastName.Text);
                        command.Parameters.AddWithValue("@age", age);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Клиент успешно добавлен", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BtnClear_Click(null, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                DeleteById();
            }
            else
            {
                DeleteByFields();
            }
        }

        private void DeleteById()
        {
            if (!int.TryParse(txtId.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Введите корректный ID", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Clients WHERE Id = @id";

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Удалено {rowsAffected} запись(ей)", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BtnClear_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Запись с указанным ID не найдена", "Информация",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteByFields()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Для удаления по полям заполните Имя, Фамилию и Возраст", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Введите корректный возраст", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        DELETE FROM Clients 
                        WHERE FirstName = @firstName 
                        AND LastName = @lastName 
                        AND Age = @age";

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                        command.Parameters.AddWithValue("@lastName", txtLastName.Text);
                        command.Parameters.AddWithValue("@age", age);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Удалено {rowsAffected} запись(ей)", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BtnClear_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Записи с указанными данными не найдены", "Информация",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}