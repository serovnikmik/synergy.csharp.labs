using System;
using System.Windows.Forms;

namespace lab7_Serov
{
    public partial class EditProductsForm : Form
    {
        private string connectionString;

        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnClear;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnClose;

        public EditProductsForm(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Редактирование товаров - Серов";
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

            Label lblName = new Label();
            lblName.Text = "Название:";
            lblName.Location = new System.Drawing.Point(xPos, yPos);
            lblName.Size = new System.Drawing.Size(150, 25);
            yPos += 30;

            txtName = new TextBox();
            txtName.Location = new System.Drawing.Point(xPos, yPos);
            txtName.Size = new System.Drawing.Size(200, 25);
            yPos += 40;

            Label lblPrice = new Label();
            lblPrice.Text = "Цена:";
            lblPrice.Location = new System.Drawing.Point(xPos, yPos);
            lblPrice.Size = new System.Drawing.Size(150, 25);
            yPos += 30;

            txtPrice = new TextBox();
            txtPrice.Location = new System.Drawing.Point(xPos, yPos);
            txtPrice.Size = new System.Drawing.Size(200, 25);
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
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.Controls.Add(lblPrice);
            this.Controls.Add(txtPrice);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnInsert);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClose);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string priceText = txtPrice.Text.Replace(',', '.');
            if (!decimal.TryParse(priceText, out decimal price) || price <= 0)
            {
                MessageBox.Show("Введите корректную цену", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Products (Name, Price) 
                        VALUES (@name, @price)";

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@price", price);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Товар успешно добавлен", "Успех",
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

                    string query = "DELETE FROM Products WHERE Id = @id";

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
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Для удаления по полям заполните Название и Цену", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string priceText = txtPrice.Text.Replace(',', '.');
            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Введите корректную цену", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        DELETE FROM Products 
                        WHERE Name = @name 
                        AND Price = @price";

                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@price", price);

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