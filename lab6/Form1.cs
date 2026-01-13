using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab6_Serov
{
    public partial class Form1 : Form
    {
        private TextBox textBoxText;
        private Label lblChars;
        private Label lblLetters;
        private Label lblWords;
        private Label lblLines;
        private Label lblExtra;

        private TextBox textBoxLetter;
        private TextBox textBoxPattern;
        private CheckBox checkBoxCaseSensitive;

        private Button btnCountChars;
        private Button btnCountLetters;
        private Button btnCountWords;
        private Button btnCountLines;
        private Button btnCountLetter;
        private Button btnCountPattern;
        private Button btnToLower;
        private Button btnToUpper;
        private Button btnRemove;
        private Button btnClear;
        private Button btnOpenFile;
        private Button btnSaveFile;

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;

        public Form1()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Текстовый калькулятор - Серов";
            this.Size = new System.Drawing.Size(700, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            int xPos = 20;
            int yPos = 20;

            textBoxText = new TextBox();
            textBoxText.Location = new System.Drawing.Point(xPos, yPos);
            textBoxText.Size = new System.Drawing.Size(450, 300);
            textBoxText.Multiline = true;
            textBoxText.ScrollBars = ScrollBars.Vertical;
            textBoxText.Font = new System.Drawing.Font("Arial", 10);
            textBoxText.Text = "Введите текст здесь...";

            xPos = 500;
            yPos = 20;

            lblChars = new Label();
            lblChars.Location = new System.Drawing.Point(xPos, yPos);
            lblChars.Size = new System.Drawing.Size(150, 25);
            lblChars.Text = "Символов: 0";
            yPos += 30;

            lblLetters = new Label();
            lblLetters.Location = new System.Drawing.Point(xPos, yPos);
            lblLetters.Size = new System.Drawing.Size(150, 25);
            lblLetters.Text = "Букв: 0";
            yPos += 30;

            lblWords = new Label();
            lblWords.Location = new System.Drawing.Point(xPos, yPos);
            lblWords.Size = new System.Drawing.Size(150, 25);
            lblWords.Text = "Слов: 0";
            yPos += 30;

            lblLines = new Label();
            lblLines.Location = new System.Drawing.Point(xPos, yPos);
            lblLines.Size = new System.Drawing.Size(150, 25);
            lblLines.Text = "Строк: 0";
            yPos += 30;

            lblExtra = new Label();
            lblExtra.Location = new System.Drawing.Point(xPos, yPos);
            lblExtra.Size = new System.Drawing.Size(150, 40);
            lblExtra.Text = "";
            yPos += 50;

            checkBoxCaseSensitive = new CheckBox();
            checkBoxCaseSensitive.Location = new System.Drawing.Point(xPos, yPos);
            checkBoxCaseSensitive.Size = new System.Drawing.Size(150, 25);
            checkBoxCaseSensitive.Text = "Учитывать регистр";
            checkBoxCaseSensitive.Checked = false;
            yPos += 30;

            xPos = 20;
            yPos = 330;

            btnCountChars = new Button();
            btnCountChars.Text = "Символы";
            btnCountChars.Location = new System.Drawing.Point(xPos, yPos);
            btnCountChars.Size = new System.Drawing.Size(80, 30);
            btnCountChars.Click += btnCountChars_Click;
            xPos += 90;

            btnCountLetters = new Button();
            btnCountLetters.Text = "Буквы";
            btnCountLetters.Location = new System.Drawing.Point(xPos, yPos);
            btnCountLetters.Size = new System.Drawing.Size(80, 30);
            btnCountLetters.Click += btnCountLetters_Click;
            xPos += 90;

            btnCountWords = new Button();
            btnCountWords.Text = "Слова";
            btnCountWords.Location = new System.Drawing.Point(xPos, yPos);
            btnCountWords.Size = new System.Drawing.Size(80, 30);
            btnCountWords.Click += btnCountWords_Click;
            xPos += 90;

            btnCountLines = new Button();
            btnCountLines.Text = "Строки";
            btnCountLines.Location = new System.Drawing.Point(xPos, yPos);
            btnCountLines.Size = new System.Drawing.Size(80, 30);
            btnCountLines.Click += btnCountLines_Click;
            xPos += 90;

            xPos = 20;
            yPos = 370;

            Label labelLetter = new Label();
            labelLetter.Text = "Буква:";
            labelLetter.Location = new System.Drawing.Point(xPos, yPos);
            labelLetter.Size = new System.Drawing.Size(50, 25);
            xPos += 60;

            textBoxLetter = new TextBox();
            textBoxLetter.Location = new System.Drawing.Point(xPos, yPos);
            textBoxLetter.Size = new System.Drawing.Size(50, 25);
            xPos += 60;

            btnCountLetter = new Button();
            btnCountLetter.Text = "Найти букву";
            btnCountLetter.Location = new System.Drawing.Point(xPos, yPos);
            btnCountLetter.Size = new System.Drawing.Size(100, 25);
            btnCountLetter.Click += btnCountLetter_Click;
            xPos += 110;

            btnToLower = new Button();
            btnToLower.Text = "В нижний регистр";
            btnToLower.Location = new System.Drawing.Point(xPos, yPos);
            btnToLower.Size = new System.Drawing.Size(130, 25);
            btnToLower.Click += btnToLower_Click;
            xPos += 140;

            btnToUpper = new Button();
            btnToUpper.Text = "В верхний регистр";
            btnToUpper.Location = new System.Drawing.Point(xPos, yPos);
            btnToUpper.Size = new System.Drawing.Size(130, 25);
            btnToUpper.Click += btnToUpper_Click;

            xPos = 20;
            yPos = 405;

            Label labelPattern = new Label();
            labelPattern.Text = "Подстрока:";
            labelPattern.Location = new System.Drawing.Point(xPos, yPos);
            labelPattern.Size = new System.Drawing.Size(70, 25);
            xPos += 80;

            textBoxPattern = new TextBox();
            textBoxPattern.Location = new System.Drawing.Point(xPos, yPos);
            textBoxPattern.Size = new System.Drawing.Size(100, 25);
            xPos += 110;

            btnCountPattern = new Button();
            btnCountPattern.Text = "Найти подстроку";
            btnCountPattern.Location = new System.Drawing.Point(xPos, yPos);
            btnCountPattern.Size = new System.Drawing.Size(120, 25);
            btnCountPattern.Click += btnCountPattern_Click;
            xPos += 130;

            btnRemove = new Button();
            btnRemove.Text = "Удалить";
            btnRemove.Location = new System.Drawing.Point(xPos, yPos);
            btnRemove.Size = new System.Drawing.Size(80, 25);
            btnRemove.Click += btnRemove_Click;

            xPos = 20;
            yPos = 440;

            btnClear = new Button();
            btnClear.Text = "Очистить";
            btnClear.Location = new System.Drawing.Point(xPos, yPos);
            btnClear.Size = new System.Drawing.Size(80, 30);
            btnClear.Click += btnClear_Click;
            xPos += 90;

            btnOpenFile = new Button();
            btnOpenFile.Text = "Открыть файл";
            btnOpenFile.Location = new System.Drawing.Point(xPos, yPos);
            btnOpenFile.Size = new System.Drawing.Size(100, 30);
            btnOpenFile.Click += btnOpenFile_Click;
            xPos += 110;

            btnSaveFile = new Button();
            btnSaveFile.Text = "Сохранить в файл";
            btnSaveFile.Location = new System.Drawing.Point(xPos, yPos);
            btnSaveFile.Size = new System.Drawing.Size(120, 30);
            btnSaveFile.Click += btnSaveFile_Click;

            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Открыть текстовый файл";

            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.Title = "Сохранить в файл";

            this.Controls.Add(textBoxText);
            this.Controls.Add(lblChars);
            this.Controls.Add(lblLetters);
            this.Controls.Add(lblWords);
            this.Controls.Add(lblLines);
            this.Controls.Add(lblExtra);
            this.Controls.Add(checkBoxCaseSensitive);

            this.Controls.Add(labelLetter);
            this.Controls.Add(textBoxLetter);
            this.Controls.Add(labelPattern);
            this.Controls.Add(textBoxPattern);

            this.Controls.Add(btnCountChars);
            this.Controls.Add(btnCountLetters);
            this.Controls.Add(btnCountWords);
            this.Controls.Add(btnCountLines);
            this.Controls.Add(btnCountLetter);
            this.Controls.Add(btnCountPattern);
            this.Controls.Add(btnToLower);
            this.Controls.Add(btnToUpper);
            this.Controls.Add(btnRemove);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnOpenFile);
            this.Controls.Add(btnSaveFile);
        }

        private void btnCountChars_Click(object sender, EventArgs e)
        {
            try
            {
                int count = textBoxText.Text.Length;
                lblChars.Text = $"Символов: {count}";
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка подсчёта символов: {ex.Message}");
            }
        }

        private void btnCountLetters_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                foreach (char c in textBoxText.Text)
                {
                    if (char.IsLetter(c))
                        count++;
                }
                lblLetters.Text = $"Букв: {count}";
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка подсчёта букв: {ex.Message}");
            }
        }

        private void btnCountWords_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBoxText.Text.Trim();
                if (string.IsNullOrEmpty(text))
                {
                    lblWords.Text = "Слов: 0";
                    return;
                }

                char[] separators = new char[] { ' ', '\t', '\r', '\n' };
                string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                lblWords.Text = $"Слов: {words.Length}";
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка подсчёта слов: {ex.Message}");
            }
        }

        private void btnCountLines_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBoxText.Text;
                if (string.IsNullOrEmpty(text))
                {
                    lblLines.Text = "Строк: 0";
                    return;
                }

                int lines = textBoxText.Lines.Length;
                if (lines == 1 && string.IsNullOrEmpty(textBoxText.Lines[0]))
                    lines = 0;

                lblLines.Text = $"Строк: {lines}";
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка подсчёта строк: {ex.Message}");
            }
        }

        private void btnCountLetter_Click(object sender, EventArgs e)
        {
            try
            {
                string letter = textBoxLetter.Text;
                if (string.IsNullOrEmpty(letter) || letter.Length != 1)
                {
                    ShowError("Введите одну букву для поиска");
                    return;
                }

                string text = textBoxText.Text;
                int count = 0;

                if (checkBoxCaseSensitive.Checked)
                {
                    foreach (char c in text)
                    {
                        if (c == letter[0])
                            count++;
                    }
                }
                else
                {
                    char target = char.ToLower(letter[0]);
                    foreach (char c in text)
                    {
                        if (char.ToLower(c) == target)
                            count++;
                    }
                }

                lblExtra.Text = $"Буква '{letter}': {count} раз";
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка поиска буквы: {ex.Message}");
            }
        }

        private void btnCountPattern_Click(object sender, EventArgs e)
        {
            try
            {
                string pattern = textBoxPattern.Text;
                if (string.IsNullOrEmpty(pattern))
                {
                    ShowError("Введите подстроку для поиска");
                    return;
                }

                string text = textBoxText.Text;
                int count = 0;
                StringComparison comparison = checkBoxCaseSensitive.Checked
                    ? StringComparison.Ordinal
                    : StringComparison.OrdinalIgnoreCase;

                int startIndex = 0;
                while (true)
                {
                    int pos = text.IndexOf(pattern, startIndex, comparison);
                    if (pos == -1) break;

                    count++;
                    startIndex = pos + pattern.Length;
                }

                lblExtra.Text = $"Подстрока '{pattern}': {count} раз";
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка поиска подстроки: {ex.Message}");
            }
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxText.Text = textBoxText.Text.ToLower();
                lblExtra.Text = "Текст преобразован в нижний регистр";
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка преобразования: {ex.Message}");
            }
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxText.Text = textBoxText.Text.ToUpper();
                lblExtra.Text = "Текст преобразован в верхний регистр";
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка преобразования: {ex.Message}");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string toRemove = textBoxPattern.Text;
                if (string.IsNullOrEmpty(toRemove))
                {
                    ShowError("Введите подстроку для удаления");
                    return;
                }

                string text = textBoxText.Text;
                string result;

                if (toRemove.Length == 1)
                {
                    if (checkBoxCaseSensitive.Checked)
                    {
                        result = text.Replace(toRemove, "");
                    }
                    else
                    {
                        char charToRemove = toRemove[0];
                        result = Regex.Replace(text, charToRemove.ToString(), "",
                            RegexOptions.IgnoreCase);
                    }
                }
                else
                {
                    if (checkBoxCaseSensitive.Checked)
                    {
                        result = text.Replace(toRemove, "");
                    }
                    else
                    {
                        result = Regex.Replace(text, Regex.Escape(toRemove), "",
                            RegexOptions.IgnoreCase);
                    }
                }

                textBoxText.Text = result;
                lblExtra.Text = $"Удалено: '{toRemove}'";
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка удаления: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxText.Text = "";
            lblChars.Text = "Символов: 0";
            lblLetters.Text = "Букв: 0";
            lblWords.Text = "Слов: 0";
            lblLines.Text = "Строк: 0";
            lblExtra.Text = "";
            textBoxLetter.Text = "";
            textBoxPattern.Text = "";
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string content = File.ReadAllText(filePath);
                    textBoxText.Text = content;
                    lblExtra.Text = $"Загружен файл: {Path.GetFileName(filePath)}";
                }
            }
            catch (IOException ex)
            {
                ShowError($"Ошибка чтения файла: {ex.Message}");
            }
            catch (UnauthorizedAccessException)
            {
                ShowError("Нет доступа к файлу");
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка: {ex.Message}");
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, textBoxText.Text);
                    lblExtra.Text = $"Сохранено в: {Path.GetFileName(filePath)}";
                }
            }
            catch (IOException ex)
            {
                ShowError($"Ошибка сохранения файла: {ex.Message}");
            }
            catch (UnauthorizedAccessException)
            {
                ShowError("Нет доступа для сохранения файла");
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка: {ex.Message}");
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}