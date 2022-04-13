using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LIBRARY_MANAGMENT_SOFTWARE
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader user = new StreamReader(("Admin/usert.txt"), true);
            string con = user.ReadLine();
            user.Close();

            StreamReader pass = new StreamReader(("Admin/pswd.txt"), true);
            string con2 = pass.ReadLine();
            pass.Close();

            SqlConnection xcon = new SqlConnection();
            StreamReader file = new StreamReader(("Connection/Connection.txt"), true);
            string con3 = file.ReadLine();

            xcon.ConnectionString = con3;

            //SqlConnection xcon = new SqlConnection("data source=DESKTOP-IE4TLR6\\sqlexpress; database=hfs_lib_man; uid=sa; password=123;");
            xcon.Open();
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from userr where(Userr_Name='" + textBox1.Text + "'and Passwordd='" + textBox2.Text + "')", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);

            if (textBox1.Text.Equals(con) && textBox2.Text.Equals(con2) || xdata.Rows.Count > 0)
            {
                Form5 frm5 = new Form5();
                frm5.ShowDialog();
                this.Close();
            }


            else
            {
                MessageBox.Show("Invalid User name or Password");
                textBox1.Clear();
                textBox2.Clear();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            //this.Close();
        }

        


    }
}
