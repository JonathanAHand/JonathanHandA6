using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;



namespace JonathanHandA6
{
    public partial class FileIOForm : Form
    {
        private string _loadedFilePath;
        private string _rawJson;

        public List<Book> Books { get; private set; } = new();

        public FileIOForm()
        {
            InitializeComponent();
            lblBookCount.Text = "Total Books: 0";
            lblBookCount.Text = "Total Books: " + Books.Count;

        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Choose book data file";
            openFile.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFile.InitialDirectory = Path.Combine(Application.StartupPath, @"..\..\..");


            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    _loadedFilePath = openFile.FileName;
                    _rawJson = File.ReadAllText(_loadedFilePath);

                    List<Book> loadedBooks = JsonSerializer.Deserialize<List<Book>>(_rawJson);
                    Books = loadedBooks;

                    MessageBox.Show("File loaded successfully. " + Books.Count + " books found.");

                    lblBookCount.Text = "Total Books: " + Books.Count;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                }
            }
        }

        private void FileIOForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (Books == null || Books.Count == 0)
            {
                MessageBox.Show("No book data to export. Please load a file first.");
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save CSV file";
            saveFile.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<string> lines = new List<string>();
                    lines.Add("Title,Author,Genre,PageLength");

                    foreach (Book b in Books)
                    {
                        string line = $"{b.Title},{b.Author},{b.Genre},{b.PageLength}";
                        lines.Add(line);
                    }

                    File.WriteAllLines(saveFile.FileName, lines);
                    MessageBox.Show("CSV file exported successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
        }

        private void btnExportJson_Click(object sender, EventArgs e)
        {
            if (Books == null || Books.Count == 0)
            {
                MessageBox.Show("No book data to export. Please load a file first.");
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save JSON file";
            saveFile.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonOutput = JsonSerializer.Serialize(Books, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(saveFile.FileName, jsonOutput);
                    MessageBox.Show("JSON file exported successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving JSON file: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


