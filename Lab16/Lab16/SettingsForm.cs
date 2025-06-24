using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab16
{
    public partial class SettingsForm : Form
    {
        //властивість для збереження IP-адреси мультикаст-групи
        public string MulticastAddress { get; set; }
        //властивість для збереження порту
        public int Port { get; set; }
        //властивість для збереження вибраного шрифту чату
        public Font ChatFont { get; set; }

        //конструктор форми налаштувань
        public SettingsForm(string currentAddress, int currentPort, Font currentFont)
        {
            InitializeComponent();

            textBoxAddress.Text = currentAddress;
            numericUpDownPort.Value = currentPort;
            ChatFont = currentFont;
            labelFontPreview.Font = currentFont;
        }
        //обробник кнопки "Вибрати шрифт"
        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            //відкриваємо діалогове вікно вибору шрифту
            FontDialog dialog = new FontDialog();
            dialog.Font = ChatFont;

            //якщо користувач натиснув OK, зберігаємо новий шрифт
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ChatFont = dialog.Font;
                //оновлюємо вигляд прикладу шрифту
                labelFontPreview.Font = ChatFont;
            }
        }
        //обробник кнопки OK
        private void btnOK_Click(object sender, EventArgs e)
        {
            MulticastAddress = textBoxAddress.Text;
            Port = (int)numericUpDownPort.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
