using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class phone : Form
    {
        private zapis a;
        string fileName = "";
        string[] zud;
        int qq;
        int www;


        public phone()
        {
            InitializeComponent();

            a = new zapis();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                a.LoadFromFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qq = a.Addauthor(textBox1.Text);
            if (qq == -1)
            {
                MessageBox.Show("введите имя");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            qq = a.Addpublisher(textBox2.Text);
            if (qq == -1)
            {
                MessageBox.Show("введите номер телефона");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            www = a.AddpublisherToauthor(textBox3.Text, textBox4.Text);

            if (www == -1)
            {
                MessageBox.Show("некоректный ввод!");
            }
            else if (www == -2)
            {
                MessageBox.Show("4");
            }
            else if (www == -3)
            {
                MessageBox.Show("5");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            a.Printauthors(out zud);
            foreach (string s in zud)
                listBox1.Items.Add(s);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            a.Printpublishers(out zud);
            foreach (string s in zud)
                listBox2.Items.Add(s);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                a.SaveToFile(saveFileDialog1.FileName);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            www = a.Findauthors(textBox5.Text, out zud);

            if (www == -1)
            {
                MessageBox.Show("введите номер телефона");
            }
            else
            {
                foreach (string s in zud)
                    listBox3.Items.Add(s);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            qq = a.Findpublishers(textBox6.Text, out zud);
            if (qq == -1)
            {
                MessageBox.Show("введите имя");
            }
            else
            {
                foreach (string s in zud)
                    listBox4.Items.Add(s);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Text="создатель не несет ответственности за ваши данные!" ;
        }  
    }
 }
    

