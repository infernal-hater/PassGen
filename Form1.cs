using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_Generate_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int length = (int)numericUpDown1.Value; //длина пароля
            bool symbols = checkBox1.Checked;
            Random rand = new Random();
            
                for (int j = 0; j < length; j++)
                {
                    if (symbols == false) // Если нет чекбокса на символах
                    {
                        int value = rand.Next(0, 10); // Простая генерация с помощью цифр
                        richTextBox1.Text += value.ToString(); 
                        continue;

                    }

                    if (symbols == true) // если символы включены
                    {
                        char value = (char)rand.Next(33, 125);// символы берутся из таблиы символов ASCII
                        richTextBox1.Text += value.ToString();
                        continue;
                    }
                } 
            }    

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void b_Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
