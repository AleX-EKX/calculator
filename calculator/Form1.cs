using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace начало2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label7.Text = "" + (int.Parse(textBox1.Text) * int.Parse(textBox2.Text));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = (label1.Text + " - ") + (comboBox1.Text) + "\n" + (label2.Text + " - ") + (comboBox2.Text) + "\n" + (label3.Text + " - ")
                + (comboBox3.Text) + "\n" + (label4.Text + " - ") + (textBox1.Text) + "\n" + (label5.Text + " - ") + (textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text= "";
            comboBox2.SelectedIndex = -1;
            comboBox3.Text = "";
            textBox1.Clear();
            textBox2.Clear();
            label7.Text = "";
            richTextBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            var column1 = new DataGridViewTextBoxColumn();
            var column2 = new DataGridViewTextBoxColumn();
            var column3 = new DataGridViewTextBoxColumn();
            var column4 = new DataGridViewTextBoxColumn();
            var column5 = new DataGridViewTextBoxColumn();
            var column6 = new DataGridViewTextBoxColumn();

            column1.HeaderText = "Товар";
            column1.Name = "column1";
            column2.HeaderText = "Уровень";
            column2.Name = "column2";
            column3.HeaderText = "цвет";
            column3.Name = "column3";
            column4.HeaderText = "Цена";
            column4.Name = "column4";
            column5.HeaderText = "Кол-во";
            column5.Name = "column5";
            column6.HeaderText = "Итого";
            column6.Name = "column6";


            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.Columns.Add(column5);
            dataGridView1.Columns.Add(column6);

            dataGridView1.Rows.Add(comboBox1.Text);
            dataGridView1.Rows.Add(comboBox2.Text);
            dataGridView1.Rows.Add(comboBox3.Text);
            dataGridView1.Rows.Add(textBox1.Text);
            dataGridView1.Rows.Add(textBox2.Text);
            dataGridView1.Rows.Add(label7.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(1);
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            калькулятор_для_идеального_веса f2 = new калькулятор_для_идеального_веса();
            f2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f3 = new Form2();
            f3.Show();
        }
    }
}
