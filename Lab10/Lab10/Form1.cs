using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(draw_rect));
            thread2 = new Thread(new ThreadStart(draw_eclips));
            thread3 = new Thread(new ThreadStart(Rnd_num));
        }

        Thread thread1;
        Thread thread2;
        Thread thread3;
        // --- ElGamal (імітація через RSA) ---

        private RSACryptoServiceProvider elGamalRsa;
        private string elGamalPublicKey;
        private string elGamalPrivateKey;

        private void draw_rect()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = tab1PanelOutput1.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(40);
                    g.DrawRectangle(Pens.Pink, 0, 0, rnd.Next(this.Width),
                    rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }

        private void draw_eclips()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = tab1PanelOutput2.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(40);
                    g.DrawEllipse(Pens.Pink, 0, 0, rnd.Next(this.Width),
                    rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }

        private void Rnd_num()
        {
            try
            {
                Random rnd = new Random();
                Parallel.For(0, 500, i => {
                    tab1RichTextBoxOutput3.Invoke((MethodInvoker)delegate ()
                    {
                        tab1RichTextBoxOutput3.Text += rnd.Next().ToString();
                    });
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }

        private void tab1BtnStart1_Click(object sender, EventArgs e) => thread1.Start();
        private void tab1BtnStop1_Click(object sender, EventArgs e) => thread1.Suspend();

        private void tab1BtnStart2_Click(object sender, EventArgs e) => thread2.Start();
        private void tab1BtnStop2_Click(object sender, EventArgs e) => thread2.Suspend();

        private void tab1BtnStart3_Click(object sender, EventArgs e) => thread3.Start();
        private void tab1BtnStop3_Click(object sender, EventArgs e) => thread3.Suspend();

        private void tab1BtnStartAll_Click(object sender, EventArgs e)
        {
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void tab1BtnStopAll_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
            thread2.Suspend();
            thread3.Suspend();
        }

        // =============================
        // Асинхронні криптографічні методи (tabPage2)
        // =============================

        private async void btnNewDes_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                using (Aes aes = Aes.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes("MessageToEncrypt123");
                    aes.GenerateKey();
                    aes.GenerateIV();
                    ICryptoTransform encryptor = aes.CreateEncryptor();

                    byte[] result = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                    SetCryptoOutput("NewDES (AES) result:\n" + BitConverter.ToString(result));
                }
            });
        }

        private async void btnMD5_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes("HashThisMessage");
                    byte[] hash = md5.ComputeHash(inputBytes);
                    SetCryptoOutput("MD5 Hash:\n" + BitConverter.ToString(hash));
                }
            });
        }

        private async void btnElGamal_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes("Simulated ElGamal");
                    byte[] encrypted = rsa.Encrypt(inputBytes, false);
                    SetCryptoOutput("Simulated ElGamal (RSA) result:\n" + BitConverter.ToString(encrypted));
                }
            });
        }

        private void SetCryptoOutput(string text)
        {
            if (tab2RichTextBoxOutput.InvokeRequired)
            {
                tab2RichTextBoxOutput.Invoke((MethodInvoker)(() => tab2RichTextBoxOutput.Text = text));
            }
            else
            {
                tab2RichTextBoxOutput.Text = text;
            }
        }

        private void tab2BtnElGamalGenKeys_Click(object sender, EventArgs e)
        {
            elGamalRsa = new RSACryptoServiceProvider();
            elGamalPublicKey = elGamalRsa.ToXmlString(false);
            elGamalPrivateKey = elGamalRsa.ToXmlString(true);
            SetCryptoOutput("ElGamal (RSA) ключі згенеровано.");
        }

        private void tab2BtnElGamalEncrypt_Click(object sender, EventArgs e)
        {
            if (elGamalRsa == null)
            {
                SetCryptoOutput("Спочатку згенеруйте ключі.");
                return;
            }
            string input = tab2TextBoxElGamalInput.Text;
            if (string.IsNullOrEmpty(input))
            {
                SetCryptoOutput("Введіть текст для шифрування.");
                return;
            }
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] encrypted = elGamalRsa.Encrypt(inputBytes, false);
            SetCryptoOutput("Зашифровано (ElGamal/RSA):\n" + Convert.ToBase64String(encrypted));
        }

        private void tab2BtnElGamalDecrypt_Click(object sender, EventArgs e)
        {
            if (elGamalRsa == null)
            {
                SetCryptoOutput("Спочатку згенеруйте ключі.");
                return;
            }
            string input = tab2TextBoxElGamalInput.Text;
            if (string.IsNullOrEmpty(input))
            {
                SetCryptoOutput("Введіть текст для розшифрування (Base64).");
                return;
            }
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(input);
                byte[] decrypted = elGamalRsa.Decrypt(encryptedBytes, false);
                SetCryptoOutput("Розшифровано (ElGamal/RSA):\n" + Encoding.UTF8.GetString(decrypted));
            }
            catch
            {
                SetCryptoOutput("Помилка розшифрування.");
            }
        }

        // --- NewDES (AES) ---

        private void tab2BtnNewDesEncrypt_Click(object sender, EventArgs e)
        {
            string input = tab2TextBoxNewDesInput.Text;
            string key = tab2TextBoxNewDesKey.Text;
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(key))
            {
                SetCryptoOutput("Введіть текст і ключ.");
                return;
            }
            using (Aes aes = Aes.Create())
            {
                aes.Key = GetAesKey(key, aes.KeySize / 8);
                aes.IV = new byte[aes.BlockSize / 8]; // IV = 0 для простоти
                ICryptoTransform encryptor = aes.CreateEncryptor();
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] encrypted = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                SetCryptoOutput("Зашифровано (NewDES/AES):\n" + Convert.ToBase64String(encrypted));
            }
        }

        private void tab2BtnNewDesDecrypt_Click(object sender, EventArgs e)
        {
            string input = tab2TextBoxNewDesInput.Text;
            string key = tab2TextBoxNewDesKey.Text;
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(key))
            {
                SetCryptoOutput("Введіть текст (Base64) і ключ.");
                return;
            }
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = GetAesKey(key, aes.KeySize / 8);
                    aes.IV = new byte[aes.BlockSize / 8]; // IV = 0 для простоти
                    ICryptoTransform decryptor = aes.CreateDecryptor();
                    byte[] encryptedBytes = Convert.FromBase64String(input);
                    byte[] decrypted = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                    SetCryptoOutput("Розшифровано (NewDES/AES):\n" + Encoding.UTF8.GetString(decrypted));
                }
            }
            catch
            {
                SetCryptoOutput("Помилка розшифрування.");
            }
        }

        // Допоміжний метод для отримання ключа потрібної довжини
        private byte[] GetAesKey(string key, int length)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            Array.Resize(ref keyBytes, length);
            return keyBytes;
        }
    }
}
