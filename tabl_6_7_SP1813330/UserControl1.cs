using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace tabl_6_7_SP1813330
{
    public partial class UserControl1 : UserControl
    {

        public string str1;
        public string str2;

        public string[] dict1;
        public string[] dict2;
        public string[] dict3;

        public UserControl1()
        {
            InitializeComponent();


            dict1 = System.IO.File.ReadAllLines(@"key1.txt");
            dict2 = System.IO.File.ReadAllLines(@"key2.txt");
            dict3 = System.IO.File.ReadAllLines(@"tabl.txt");
            
            foreach (string s in dict1)
            {
                comboBox1.Items.Add(s);
            }

            foreach (string s in dict2)
            {
                comboBox2.Items.Add(s);
            }



            // Выставляю начальное значение
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;

        }
        
        private void sel()
        {
            textBox1.Text = str1 + " - " + str2;

            // тут прописываем поиск по таблице
            foreach(string i in dict3)
            {
                var v = i.Split(new char[] { '|' });
               
                bool a = true;

                if(v[0] == str1 & v[1] == str2) 
                {
                    textBox1.Text = v[2];
                    a = false;
                    return;
                }

                if (v[0] == str2 & v[1] == str1)
                {
                    textBox1.Text = v[2];
                    a = false;
                    return;
                }
                if(a)
                {
                    textBox1.Text = "В базе нет такого сочетания!";
                }
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            str1 = comboBox1.Text;
            sel();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            str2 = comboBox2.Text;
            sel();
        }

        
    }
}
