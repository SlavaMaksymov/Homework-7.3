using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using System.Diagnostics.Metrics;

namespace Homework_7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        int shift;
        char letter;

        private void button1_Click(object sender, EventArgs e)
        {
            shift = Convert.ToInt32(textBox3.Text);


            string result = "";


            if (shift < 1 || shift > 25)
            {
                MessageBox.Show("Не коректне значення! Введіть зсув від 1 до 25.");
            }

            string text = textBox1.Text.ToLower();

            for (int i = 0; i < text.Length; i++)
            {

                int temp = Convert.ToInt32(text[i]);
                if (temp != 32)
                {
                    temp += shift;
                }

                if (temp > 122)
                {
                    temp -= 26;

                }

                letter = Convert.ToChar(temp);
                result += letter;
            }



            textBox2.Text = result;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "3";
            textBox4.Clear();

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deciphered = "";
            string cipher = textBox2.Text;

            for (int i = 0; i < cipher.Length; i++)
            {

                int temp = Convert.ToInt32(cipher[i]);
                if (temp != 32)
                {
                    temp -= shift;

                }

                if (temp < 97 && temp != 32)
                {
                    temp += 26;

                }

                letter = Convert.ToChar(temp);
                deciphered += letter;
                textBox4.Text = deciphered;
            }
        }
    }
}
