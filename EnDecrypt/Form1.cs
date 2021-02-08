using System;
using System.Windows.Forms;
using EnDecryptLibrary;

namespace EnDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            richTextBoxInput.Text = "Input your text here";
            richTextBoxOutput.Text = "See your output here";

            this.CenterToScreen();
        }

        private void buttonClose2_Click(object sender, EventArgs e)
        {
            this.Close();
            // Application.Restart();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = EnDecryptLibrary.EnDecrypt.Encrypt(richTextBoxInput.Text, "V*Ge08sB:w7<A){1Dp QyU]J6(Hj@vb=i$>og?Y^%fMRm4WnhS[X`}KIN/O;TctqL!Z32r.|-d,E~C#kl&ux_F5a+9Pz", "A0001");
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = EnDecryptLibrary.EnDecrypt.Decrypt(richTextBoxInput.Text, "V*Ge08sB:w7<A){1Dp QyU]J6(Hj@vb=i$>og?Y^%fMRm4WnhS[X`}KIN/O;TctqL!Z32r.|-d,E~C#kl&ux_F5a+9Pz", "A0001");
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Text = EnDecryptLibrary.EnDecrypt.GenerateKey();

            //richTextBoxOutput.Text = EnDecryptLibrary.EnDecrypt.GenerateSecondaryKey(richTextBoxInput.Text).ToString();
        }
    }
}
