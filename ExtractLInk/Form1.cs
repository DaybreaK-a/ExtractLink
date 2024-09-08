using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace URLParser
{
    public partial class Form1 : Form
    {
        // Словарь известных протоколов и портов
        private readonly Dictionary<string, int> knownProtocols = new Dictionary<string, int>
        {
            { "http", 80 },
            { "https", 443 },
            { "ftp", 21 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        // Кнопка для выбора исходного файла
        private void btnInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = openFileDialog.FileName;
            }
        }

        // Кнопка для выбора выходного файла
        private void btnOutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputFilePath.Text = saveFileDialog.FileName;
            }
        }

        // Кнопка для парсинга ссылки или файла
        private void btnParse_Click(object sender, EventArgs e)
        {
            // Очищаем вывод перед каждым разбором
            txtResult.Clear();

            if (!string.IsNullOrEmpty(txtLink.Text))
            {
                // Парсинг ссылки из текстового поля
                ParseUrl(txtLink.Text);
            }
            else if (!string.IsNullOrEmpty(txtInputFile.Text) && File.Exists(txtInputFile.Text))
            {
                // Парсинг ссылок из файла
                ParseFromFile(txtInputFile.Text, txtOutputFilePath.Text);
            }
            else
            {
                MessageBox.Show("Введите ссылку или выберите файл.");
            }
        }

        // Метод для парсинга URL
        private void ParseUrl(string url)
        {
            string result = ParseSingleUrl(url);

            // Вывод результата
            txtResult.Text = result;

            // Если указан выходной файл, записать результат туда
            if (!string.IsNullOrEmpty(txtOutputFilePath.Text))
            {
                File.AppendAllText(txtOutputFilePath.Text, result + Environment.NewLine);
            }
        }

        // Парсинг ссылок из файла
        private void ParseFromFile(string inputFile, string outputFile)
        {
            try
            {
                var lines = File.ReadAllLines(inputFile);
                var results = new List<string>();

                foreach (var line in lines)
                {
                    string result = ParseSingleUrl(line);
                    results.Add(result);

                    // Выводим результат в текстовое поле
                    txtResult.AppendText(result + Environment.NewLine);
                }

                // Сохранение в файл, если указан выходной путь
                if (!string.IsNullOrEmpty(outputFile))
                {
                    File.WriteAllLines(outputFile, results);
                    MessageBox.Show("Результаты сохранены в файл.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Парсинг одной ссылки
        private string ParseSingleUrl(string url)
        {
            try
            {
                Uri uri = new Uri(url);
                string protocol = uri.Scheme;
                string host = uri.Host;
                int port = uri.Port != -1 ? uri.Port : (knownProtocols.ContainsKey(protocol) ? knownProtocols[protocol] : -1);

                // Удаление начального слэша у URL-пути
                string path = uri.AbsolutePath.TrimStart('/');

                // Проверка, если путь пустой, считаем ссылку неправильной
                if (string.IsNullOrEmpty(path))
                {
                    throw new UriFormatException();
                }

                // Если порт -1, значит ссылка неверная
                if (port == -1)
                {
                    throw new UriFormatException();
                }

                // Форматированный вывод без жирного шрифта
                return $"Протокол: {protocol}\nХост: {host}\nПорт: {port}\nURL-путь: {path}\n--------------------------------------";
            }
            catch (UriFormatException)
            {
                return "Ссылка не распознана";
            }
        }

        // Смена цветовой темы
        private void btnChangeTheme_Click(object sender, EventArgs e)
        {
            if (BackColor == SystemColors.Control)
            {
                BackColor = System.Drawing.Color.Black;
                ForeColor = System.Drawing.Color.White;

                // Темная тема для всех элементов
                foreach (Control control in this.Controls)
                {
                    if (control is Button || control is TextBox || control is RichTextBox)
                    {
                        control.BackColor = System.Drawing.Color.Gray;
                        control.ForeColor = System.Drawing.Color.White;
                    }
                }
            }
            else
            {
                BackColor = SystemColors.Control;
                ForeColor = System.Drawing.Color.Black;

                // Светлая тема для всех элементов
                foreach (Control control in this.Controls)
                {
                    if (control is Button || control is TextBox || control is RichTextBox)
                    {
                        control.BackColor = SystemColors.Window;
                        control.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
        }

        // Вывод справки
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для парсинга URL\n" +
                            "В первой строке можно выбрать файл, в котором содержатся ссылки\n" +
                            "Во второй строке можно выбрать файл, куда будет помещен результат работы программы\n."+
                            "В третьей строке можно ввести или вставить из буфера обмена ссылку, которую необходимо разобрать"+
                            "");
        }
    }
}
