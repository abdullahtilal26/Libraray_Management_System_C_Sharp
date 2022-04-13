using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace LIBRARY_MANAGMENT_SOFTWARE
{
    public partial class Form9 : Form
    {
        public Form9()
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
                groupBox1.Show();
                groupBox2.Show();

            }
            else
            {
                MessageBox.Show("Please Entre Correct Username and Password");
            }
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(("Connection/Connection.txt")))
            {
                File.Delete(("Connection/Connection.txt"));
            }


            StreamWriter conwrt = new StreamWriter(("Connection/Connection.txt"), true);
            conwrt.WriteLine(textBox3.Text.ToString());
            conwrt.Flush();
            conwrt.Dispose();
            
            MessageBox.Show("Connection Created");
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection xcon = new SqlConnection();
            xcon.ConnectionString = textBox4.Text;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string op;
            op = ofd.FileName;

            xcon.Open();
            SqlCommand xcmd = new SqlCommand("restore database hfs_lib_man from disk = '" + ((op)) + "' ", xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();

            MessageBox.Show("Dtabase Restored");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //StreamWriter wrt = new StreamWriter("Backup/backup_path.txt", true);
            //wrt.WriteLine(textBox5.Text);
            //wrt.Flush();
            //wrt.Dispose();

            //MessageBox.Show("Path Generated");
            //label7.Text = textBox5.Text;
                        
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form8 frm8= new Form8();
            frm8.ShowDialog();
            this.Close();

        }

       

        
    }
}
