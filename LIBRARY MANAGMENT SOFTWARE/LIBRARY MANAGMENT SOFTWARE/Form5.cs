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
    public partial class Form5 : Form
    {
        SqlConnection xcon;
        
        public Form5()
        {
            xcon = new SqlConnection();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            this.Close();
        }

        

            

       

        private void button5_Click(object sender, EventArgs e)
        {

            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            //string path;
            //path = ofd.FileName;
            //string path2;
            // path2= Path.GetDirectoryName(path);
            // label2.Text = path2;
            

            //StreamWriter wrt = new StreamWriter("Backup/backups_path/backup_path.txt", true);
            //wrt.WriteLine(path2);
            //wrt.Flush();
            //wrt.Dispose();

            StreamReader rdr = new StreamReader("Backup/backup_path.txt", true);
            string pth = rdr.ReadLine();

            xcon.Open();
            SqlCommand xcmd = new SqlCommand("backup database hfs_lib_man to disk = '" + (( DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".bak")) + "' ", xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();

            MessageBox.Show("Backup Created");

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(("Connection/Connection.txt"), true);
            String con = file.ReadLine();

            xcon.ConnectionString = con;
        }

       
        

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.ShowDialog();
            this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
            this.Close();
        }

       
    }
}
