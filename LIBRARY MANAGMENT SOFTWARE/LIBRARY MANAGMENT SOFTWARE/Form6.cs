using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LIBRARY_MANAGMENT_SOFTWARE
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader user = new StreamReader(("Admin/usert.txt"), true);
            string con = user.ReadLine();

            StreamReader pass = new StreamReader(("Admin/pswd.txt"), true);
            string con2 = pass.ReadLine();

            if (textBox1.Text.Equals(con) && textBox2.Text.Equals(con2))
            {
                Form7 frm7 = new Form7();
                frm7.ShowDialog();
                this.Close();
            }


            else
            {
                MessageBox.Show("Invalid User name or Password");
                textBox1.Clear();
                textBox2.Clear();
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
            this.Close();
        }

       

        }
    }

