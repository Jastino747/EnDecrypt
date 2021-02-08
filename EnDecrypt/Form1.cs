using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnDecrypt
{
    public partial class Form1 : Form
    {
        public List<ClassData> listData = new List<ClassData>();
        string text;
        int manipulator;
        int subManipulator;
        int index;
        Random generator = new Random();

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

            InputData("\t", 0, "");
            InputData("\n", 1, "");
            InputData(" ", 2, "");
            InputData("!", 3, "");
            InputData("\"", 4, "");
            InputData("#", 5, "");
            InputData("$", 6, "");
            InputData("%", 7, "");
            InputData("&", 8, "");
            InputData("\'", 9, "");
            InputData("(", 10, "");
            InputData(")", 11, "");
            InputData("*", 12, "");
            InputData("+", 13, "");
            InputData(",", 14, "");
            InputData("-", 15, "");
            InputData(".", 16, "");
            InputData("/", 17, "");
            InputData("0", 18, "");
            InputData("1", 19, "");
            InputData("2", 20, "");
            InputData("3", 21, "");
            InputData("4", 22, "");
            InputData("5", 23, "");
            InputData("6", 24, "");
            InputData("7", 25, "");
            InputData("8", 26, "");
            InputData("9", 27, "");
            InputData(":", 28, "");
            InputData(";", 29, "");
            InputData("<", 30, "");
            InputData("=", 31, "");
            InputData(">", 32, "");
            InputData("?", 33, "");
            InputData("@", 34, "");
            InputData("A", 35, "");
            InputData("B", 36, "");
            InputData("C", 37, "");
            InputData("D", 38, "");
            InputData("E", 39, "");
            InputData("F", 40, "");
            InputData("G", 41, "");
            InputData("H", 42, "");
            InputData("I", 43, "");
            InputData("J", 44, "");
            InputData("K", 45, "");
            InputData("L", 46, "");
            InputData("M", 47, "");
            InputData("N", 48, "");
            InputData("O", 49, "");
            InputData("P", 50, "");
            InputData("Q", 51, "");
            InputData("R", 52, "");
            InputData("S", 53, "");
            InputData("T", 54, "");
            InputData("U", 55, "");
            InputData("V", 56, "");
            InputData("W", 57, "");
            InputData("X", 58, "");
            InputData("Y", 59, "");
            InputData("Z", 60, "");
            InputData("[", 61, "");
            InputData("\\",62, "");
            InputData("]", 63, "");
            InputData("^", 64, "");
            InputData("_", 65, "");
            InputData("`", 66, "");
            InputData("a", 67, "");
            InputData("b", 68, "");
            InputData("c", 69, "");
            InputData("d", 70, "");
            InputData("e", 71, "");
            InputData("f", 72, "");
            InputData("g", 73, "");
            InputData("h", 74, "");
            InputData("i", 75, "");
            InputData("j", 76, "");
            InputData("k", 77, "");
            InputData("l", 78, "");
            InputData("m", 79, "");
            InputData("n", 80, "");
            InputData("o", 81, "");
            InputData("p", 82, "");
            InputData("q", 83, "");
            InputData("r", 84, "");
            InputData("s", 85, "");
            InputData("t", 86, "");
            InputData("u", 87, "");
            InputData("v", 88, "");
            InputData("w", 89, "");
            InputData("x", 90, "");
            InputData("y", 91, "");
            InputData("z", 92, "");
            InputData("{", 93, "");
            InputData("|", 94, "");
            InputData("}", 95, "");
            InputData("~", 96, "");
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
            RefreshData();
            manipulator = 0;
            subManipulator = 0;
            richTextBoxOutput.Clear();
            text = richTextBoxInput.Text;
            richTextBoxInput.Enabled = false;
            richTextBoxOutput.Enabled = false;
            buttonDecrypt.Enabled = false;
            buttonEncrypt.Enabled = false;
            for (int i = 0; i < listData.Count; i++)
            {
                GenerateCode(i);
            }
            /*for (int i=0; i<listData.Count; i++)
            {
                for (int j=0; j<listData.Count; j++)
                {
                    if (int.Parse(listData[i].Shuf) == j)
                    {
                        richTextBoxOutput.Text += listData[j].Cha;
                    }
                }
            }*/
            index = 0;
            timerEncrypt.Enabled = true;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            RefreshData();
            manipulator = 0;
            subManipulator = 0;
            richTextBoxOutput.Clear();
            text = richTextBoxInput.Text;
            richTextBoxInput.Enabled = false;
            richTextBoxOutput.Enabled = false;
            buttonDecrypt.Enabled = false;
            buttonEncrypt.Enabled = false;
            for (int i = 96; i >= 0; i--)
            {
                try
                {
                    DegenerateCode(i);
                }
                catch (Exception)
                {
                    MessageBox.Show("Decryption failed due to incompetence of encrypted text input. \nPay attention to each characters, including upper case, lower case, spaces even tabs and enters.");
                    break;
                }
            }
            timerDecrypt.Enabled = true;
        }
        private void InputData(string ch, int id, string sh)
        {
            ClassData data = new ClassData(ch, id, sh);
            listData.Add(data);
        }

        private void timerEncrypt_Tick(object sender, EventArgs e)
        {
            try
            {
                if (text.Length > 0)
                {
                    subManipulator = subManipulator + subManipulator + 1;
                    manipulator += subManipulator;
                    if (manipulator > 96) manipulator = manipulator % 97;
                    for (int i = 0; i < listData.Count; i++)
                    {
                        if (text.Substring(0, 1) == listData[i].Cha)
                        {
                            for (int j = 0; j < listData.Count; j++)
                            {
                                if (int.Parse(listData[i].Shuf) == j)
                                {
                                    richTextBoxOutput.Text += listData[(j + manipulator) % 97].Cha;
                                    text = text.Remove(0, 1);
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < listData.Count; i++)
                    {
                        if (index == i)
                        {
                            for (int j = 0; j < listData.Count; j++)
                            {
                                if (int.Parse(listData[i].Shuf) == j)
                                {
                                    /*richTextBoxOutput.Text += "\n";
                                    richTextBoxOutput.Text += (listData[i].Cha + " = " + listData[j].Cha);*/
                                    richTextBoxOutput.Text += listData[j].Cha;
                                }
                            }
                        }
                    }
                    index++;
                    if (index > 96)
                    {
                        index = 0;
                        richTextBoxInput.Enabled = true;
                        richTextBoxOutput.Enabled = true;
                        buttonDecrypt.Enabled = true;
                        buttonEncrypt.Enabled = true;
                        RefreshData();
                        timerEncrypt.Enabled = false;
                        text = "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Encryption failed due to incompetence of encrypted text input. \nPay attention to each characters, including upper case, lower case, spaces even tabs and enters.");
            }
        }

        private void timerDecrypt_Tick(object sender, EventArgs e)
        {
            if (text.Length > 0)
            {
                subManipulator = subManipulator + subManipulator + 1;
                manipulator += subManipulator;
                if (manipulator > 96) manipulator = manipulator % 97;
                for (int i = 0; i < listData.Count; i++)
                {
                    if (text.Substring(0, 1) == listData[(i + manipulator) % 97].Cha)
                    {
                        for (int j = 0; j < listData.Count; j++)
                        {
                            if (int.Parse(listData[j].Shuf) == i)
                            {
                                richTextBoxOutput.Text += listData[j].Cha;
                                text = text.Remove(0, 1);
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                richTextBoxInput.Enabled = true;
                richTextBoxOutput.Enabled = true;
                buttonDecrypt.Enabled = true;
                buttonEncrypt.Enabled = true;
                RefreshData();
                timerDecrypt.Enabled = false;
                text = "";
            }
        }
        private void GenerateCode(int ind)
        {
            listData[ind].Shuf = generator.Next(0, 97).ToString();
            bool valid = true;
            for (int i = 0; i < listData.Count; i++)
            {
                if (listData[i].Shuf == listData[ind].Shuf && i != ind)
                {
                    valid = false;
                    listData[ind].Shuf = "";
                    break;
                }
            }
            if (valid == false)
            {
                GenerateCode(ind);
            }
        }
        private void DegenerateCode(int ind)
        {
            for (int i=0; i<listData.Count; i++)
            {
                if (text.Substring(text.Length - 1, 1) == listData[i].Cha)
                {
                    listData[ind].Shuf = i.ToString();
                    text = text.Remove(text.Length - 1, 1);
                    /*richTextBoxOutput.Text += "\n";
                    richTextBoxOutput.Text += (listData[ind].Cha + " = " + listData[i].Cha);*/
                    break;
                }
            }
        }
        private void RefreshData()
        {
            for (int i=0; i < listData.Count; i++)
            {
                listData[i].Shuf = "";
            }
        }

        private void buttonTerminate_Click(object sender, EventArgs e)
        {
            richTextBoxInput.Enabled = true;
            richTextBoxOutput.Enabled = true;
            buttonDecrypt.Enabled = true;
            buttonEncrypt.Enabled = true;
            RefreshData();
            timerDecrypt.Enabled = false;
            timerEncrypt.Enabled = false;
        }
    }
}
