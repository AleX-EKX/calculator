using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace начало2
{
    public partial class калькулятор_для_идеального_веса : Form
    {
        public калькулятор_для_идеального_веса()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             // * float.Parse(textBox2.Text));//* float.Parse(textBox2.Text),2).ToString();
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните данные");
                return;
            }
            if(Convert.ToDouble(textBox2.Text) %1 == 0)
            {
                label4.Text = "Ваше значение - " + (Math.Round(double.Parse(textBox1.Text)*10000, 2) / (Math.Round(double.Parse(textBox2.Text), 2) * (Math.Round(double.Parse(textBox2.Text), 2)))).ToString("f2");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                label4.Text = "Ваше значение - " + (Math.Round(double.Parse(textBox1.Text), 0) / (Math.Round(double.Parse(textBox2.Text), 2) * (Math.Round(double.Parse(textBox2.Text), 2)))).ToString("f2");
                textBox1.Text = "";
                textBox2.Text = "";
            }
               
        }
        // rabo4iy label4.Text = " " + (Math.Round(double.Parse(textBox1.Text),2) / (Math.Round(double.Parse(textBox2.Text),2)* (Math.Round(double.Parse(textBox2.Text),2)))).ToString("f2"); // * float.Parse(textBox2.Text));//* float.Parse(textBox2.Text),2).ToString();
        //label4.Text = " " + Math.Round(int.Parse(textBox1.Text) / Math.Pow(float.Parse(textBox2.Text), float.Parse(textBox2.Text)));
        //Math.Pow(x, k)
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Заполните данные");
                return;
            }
            if (Convert.ToDouble(textBox3.Text) % 1 == 0)
            {
                label5.Text = "Вес - " + (int.Parse(comboBox1.Text) * (float.Parse(textBox3.Text) * float.Parse(textBox3.Text) / 10000));
                comboBox1.Text = "";
                textBox3.Text = "";
            }
            else
            {
                label5.Text = "Вес - " + (int.Parse(comboBox1.Text) * (float.Parse(textBox3.Text) * float.Parse(textBox3.Text)));
                comboBox1.Text = "";
                textBox3.Text = "";
            }

                
        }

    }
}
