using System;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //завантаження дисків при створенні форми
            LoadDrives();
        }

        private string currentDirectory = "C:\\"; //початковий шлях
        //метод для завантаження списку дисків
        private void LoadDrives()
        {
            //очищуємо listBox, потім додаємо диски
            listBoxDrives.Items.Clear();
            var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                listBoxDrives.Items.Add(drive.Name);
            }
        }
        //метод для завантаження каталогів і файлів
        private void LoadDirectory(string path)
        {
            listBoxDirectories.Items.Clear();
            listBoxFiles.Items.Clear();

            try
            {
                //завантажуємо каталоги
                var directories = Directory.GetDirectories(path);
                foreach (var directory in directories)
                {
                    listBoxDirectories.Items.Add(directory);
                }

                //завантажуємо файли
                var files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    listBoxFiles.Items.Add(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завнтаженні каталогу: {ex.Message}");
            }
        }
        //метод для відображення властивостей файлів і каталогів
        private void DisplayProperties(string path)
        {
            var fileInfo = new FileInfo(path);
            var directoryInfo = new DirectoryInfo(path);

            if (fileInfo.Exists)
            {
                lblFileInfo.Text = $"Назва: {fileInfo.Name}\nРозмір: {fileInfo.Length} bytes\nСтворено: {fileInfo.CreationTime}";
            }
            else if (directoryInfo.Exists)
            {
                lblDirectoryInfo.Text = $"Каталог: {directoryInfo.Name}\nСтворено: {directoryInfo.CreationTime}";
            }
        }
        //метод для віображення властивостей диску
        private void DisplayDriveProperties(string drivePath)
        {
            var driveInfo = new DriveInfo(drivePath);

            if (driveInfo.IsReady)
            {
                lblDriveInfo.Text = $"Диск: {driveInfo.Name}\n" +
                                   $"Тип: {driveInfo.DriveType}\n" +
                                   $"Доступний простір: {driveInfo.AvailableFreeSpace / (1024 * 1024)} MB\n" +
                                   $"Загальний розмір: {driveInfo.TotalSize / (1024 * 1024)} MB\n" +
                                   $"Файлова система: {driveInfo.DriveFormat}";
            }
            else
            {
                lblDriveInfo.Text = "Проблема з диском";
            }
        }
        //метод для завантаження файлів з каталогу
        private void LoadFilesFromDirectory(string directoryPath)
        {
            listBoxFiles.Items.Clear(); //очищення списоку файлів

            try
            {
                var files = Directory.GetFiles(directoryPath); //отримання всіх файлів в каталозі
                foreach (var file in files)
                {
                    listBoxFiles.Items.Add(file); //додаємо файли до listBoxFiles
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження файлів: {ex.Message}");
            }
        }
        //обробник для списку дисків
        private void listBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDrives.SelectedItem != null)
            {
                var selectedDrive = listBoxDrives.SelectedItem.ToString();
                currentDirectory = selectedDrive; //оновлення поточної директорії
                DisplayDriveProperties(selectedDrive); //виклик метод для відображення властивостей диску
                LoadDirectory(selectedDrive); //завантаження каталогів
            }
        }
        //обробник для списку каталогів 
        private void listBoxDirectories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDirectories.SelectedItem != null)
            {
                var selectedDirectory = listBoxDirectories.SelectedItem.ToString();
                currentDirectory = selectedDirectory; //оновлення поточної директорії
                DisplayProperties(selectedDirectory);//виклик метод для відображення властивостей каталогу
                LoadFilesFromDirectory(selectedDirectory);//завантаження файлів
            }
        }
        //обробник для списку файлів 
        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem != null)
            {
                var selectedFile = listBoxFiles.SelectedItem.ToString();
                DisplayProperties(selectedFile);  //викликаємо метод для відображення властивостей файлу
            }
        }
        //обробник для кнопки Filter
        private void btnFilter_Click(object sender, EventArgs e)
        {
            //отримуємо значення для фільтрації
            var filter = txtFilter.Text.Trim();

            try
            {
                //фільтрація файлів
                var files = Directory.GetFiles(currentDirectory);
                listBoxFiles.Items.Clear();
                foreach (var file in files)
                {
                    if (Path.GetFileName(file).IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        listBoxFiles.Items.Add(file);
                    }
                }

                //фільтрація каталогів
                var directories = Directory.GetDirectories(currentDirectory);
                listBoxDirectories.Items.Clear();
                foreach (var directory in directories)
                {
                    if (Path.GetFileName(directory).IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        listBoxDirectories.Items.Add(directory);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка фільтрації: {ex.Message}");
            }
        }
        //обробник для кнопки View File
        private void btnViewFile_Click(object sender, EventArgs e)
        {
            //якщо обрано текстовий файл, то його вміст буде виводитись в MessageBox
            //якщо графічний -- вивід в pictureBoxPreview
            if (listBoxFiles.SelectedItem != null)
            {
                var selectedFile = listBoxFiles.SelectedItem.ToString();
                if (selectedFile.EndsWith(".txt"))
                {
                    var text = File.ReadAllText(selectedFile);
                    MessageBox.Show(text);
                }
                else if (selectedFile.EndsWith(".jpg") || selectedFile.EndsWith(".png"))
                {
                    pictureBoxPreview.Image = Image.FromFile(selectedFile);
                }
            }
        }
        //обробник для кнопки Back
        private void btnBack_Click(object sender, EventArgs e)
        {
            var parentDirectory = Directory.GetParent(currentDirectory)?.FullName;
            if (!string.IsNullOrEmpty(parentDirectory))
            {
                currentDirectory = parentDirectory;
                LoadDirectory(currentDirectory);
            }
        }
        //обробник для кнопки Security Attributes
        private void btnSecurityAttrs_Click(object sender, EventArgs e)
        {
            string selectedPath = null;

            //спочатку визначаємо, що вибрано
            if (listBoxFiles.SelectedItem != null)
            {
                selectedPath = listBoxFiles.SelectedItem.ToString();
            }
            else if (listBoxDirectories.SelectedItem != null)
            {
                selectedPath = listBoxDirectories.SelectedItem.ToString();
            }

            if (selectedPath != null)
            {
                try
                {
                    listBoxSecurityAttrs.Items.Clear(); //очищаємо старі атрибути

                    if (File.Exists(selectedPath))
                    {
                        var fileInfo = new FileInfo(selectedPath);
                        var accessControl = fileInfo.GetAccessControl();
                        var rules = accessControl.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));

                        lblSecurity.Text = $"Файл: {fileInfo.Name}";

                        foreach (FileSystemAccessRule rule in rules)
                        {
                            listBoxSecurityAttrs.Items.Add($"{rule.IdentityReference}: {rule.FileSystemRights}");
                        }
                    }
                    else if (Directory.Exists(selectedPath))
                    {
                        var dirInfo = new DirectoryInfo(selectedPath);
                        var accessControl = dirInfo.GetAccessControl();
                        var rules = accessControl.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));

                        lblSecurity.Text = $"Каталог: {dirInfo.Name}";

                        foreach (FileSystemAccessRule rule in rules)
                        {
                            listBoxSecurityAttrs.Items.Add($"{rule.IdentityReference}: {rule.FileSystemRights}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вибраний шлях не існує", "Помилка");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка отримання атрибутів безпеки: {ex.Message}", "Помилка");
                }
            }
            else
            {
                MessageBox.Show("Виберіть каталог або файл");
            }
        }
        //обробник для кнопки Go To Path
        private void btnGoToPath_Click(object sender, EventArgs e)
        {
            var path = txtPathInput.Text;
            if (Directory.Exists(path))
            {
                currentDirectory = path;
                LoadDirectory(currentDirectory);
            }
            else
            {
                MessageBox.Show("Не існуючий шлях");
            }
        }
        //обробник для кнопки Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxDirectories.Items.Clear();
            listBoxFiles.Items.Clear();
            lblFileInfo.Text = string.Empty;
        }
    }
}
