using lab5.Services;
using System;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private readonly ElGamalCipher _elGamalCipher;
        private KeysInfo _keysInfo;

        public Form1()
        {
            InitializeComponent();

            FileError.Text = string.Empty;

            _elGamalCipher = new ElGamalCipher();
        }

        private void GenerateKeys_Click(object sender, EventArgs e)
        {
            _keysInfo = _elGamalCipher.GenerateKeys();
            KeysInfo.Text = $"Открытый ключ:\r\ny = {_keysInfo.ClientKey.y}\r\ng = {_keysInfo.ClientKey.g}\r\np = {_keysInfo.ClientKey.p}";
            KeysInfo.Text += $"\r\nЗакрытый ключ:\r\nx = {_keysInfo.SecretKey.x}";
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            Output.Text = _elGamalCipher.Encrypt(Message.Text, _keysInfo.ClientKey);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            Output.Text = _elGamalCipher.Decrypt(Message.Text, _keysInfo.ClientKey, _keysInfo.SecretKey);
        }

        private void SaveToFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FileName.Text))
            {
                FileError.Text = "Укажите имя файла.";
                return;
            }

            FileError.Text = string.Empty;

            try
            {
                var path = string.Empty;
                if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                    path = FolderBrowserDialog.SelectedPath;

                File.WriteAllText(Path.Combine(path, FileName.Text + ".txt"), Output.Text);
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void LoadFromFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var path = OpenFileDialog.FileName;
                    Message.Text = File.ReadAllText(path);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
