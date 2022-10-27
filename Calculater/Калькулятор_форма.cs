using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Label = System.Windows.Forms.Label;

namespace Calculater
{
    public partial class Калькулятор_форма : Form
    {
        double a, b; //  Объявление переменных

        int count;     //  Переменная для вычислений

        bool sign = true;    //  Для того, что бы менять знаки у введеных чисел, true-положит, false-отриц

        Label label1 = new Label(); //  Создаем лист для памяти чисел

        public Калькулятор_форма()
        {
            InitializeComponent();

        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length < 9)
            {
                textDisplay.Text = textDisplay.Text + 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textDisplay.Text.Length < 9)
            {
                textDisplay.Text = textDisplay.Text + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length < 9)
            {
                textDisplay.Text = textDisplay.Text + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length < 9)
            {
                textDisplay.Text = textDisplay.Text + 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length < 9)
            {
                textDisplay.Text = textDisplay.Text + 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length < 9)
            {
                textDisplay.Text = textDisplay.Text + 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length < 9)
            {
                textDisplay.Text = textDisplay.Text + 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length < 9)
            {
                textDisplay.Text = textDisplay.Text + 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length < 9)
            {
                textDisplay.Text = textDisplay.Text + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length < 9)
            {
                textDisplay.Text = textDisplay.Text + 9;
            }
        }

        // Арифметические действия

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "";
            }
            else
            {
                a = double.Parse(textDisplay.Text);
                textDisplay.Text = "";
                count = 1;
                label1.Text = a.ToString() + "+";
                sign = true;
            }
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "";
            }
            else
            {
                a = double.Parse(textDisplay.Text);
                textDisplay.Text = "";
                count = 2;
                label1.Text = a.ToString() + "-";
                sign = true;
            }
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "";
            }
            else
            {
                a = double.Parse(textDisplay.Text);
                textDisplay.Text = "";
                count = 3;
                label1.Text = a.ToString() + "*";
                sign = true;
            }
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "";
            }
            else
            {
                a = double.Parse(textDisplay.Text);
                textDisplay.Text = "";
                count = 4;
                label1.Text = a.ToString() + "/";
                sign = true;
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "";
            }
            else
            {
                textDisplay.Text = "";
                label1.Text = "";
                a = 0;
            }
        }

        private void buttonsign_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "";
            }
            else
            {
                if (sign == true)
                {
                    textDisplay.Text = "-" + textDisplay.Text;
                    sign = false;
                }
                else if (sign == false)
                {
                    textDisplay.Text = textDisplay.Text.Replace("-", "");
                    sign = true;
                }
            }
        }

        CalculLogic Logic_Calc = new CalculLogic();

        private void Калькулятор_форма_Load(object sender, EventArgs e)
        {

        }

        //  Вывод данных в txtDisplay
        private void buttonqually_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "")
            {
                textDisplay.Text = "";
            }
            else
            {
                if (textDisplay.Text.Length < 9)
                {
                    textDisplay.Text = Logic_Calc.Calculate(count, a, textDisplay.Text);
                    label1.Text = "";
                }
                else
                {
                    textDisplay.Text = "EXCEEDED";
                }
            }
        }
    }
}
