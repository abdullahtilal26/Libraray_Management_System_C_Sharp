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
    public partial class Form2 : Form
    {
        SqlConnection xcon;
        public Form2()
        {
            InitializeComponent();
            xcon = new SqlConnection();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(("Connection/Connection.txt"), true);
            String con = file.ReadLine();

            xcon.ConnectionString = con;

            showdata();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //string id;
            //id = dataGridView1.CurrentRow.Cells[0].Value.ToString();


            //xcon.Open();
            //SqlCommand xcmd = new SqlCommand("update bok_isu set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
            //xcmd.ExecuteNonQuery();
            //xcmd.Dispose();
            //SqlCommand xcmd2 = new SqlCommand("update bok_isu_rec set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
            //xcmd2.ExecuteNonQuery();
            //xcmd2.Dispose();
            //xcon.Close();
            //MessageBox.Show("updated");

            //showdata();
        }


        void showdata()
        {
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);

            for (int i = 0; i < xdata.Rows.Count; i++) 
            
            {
                dataGridView1.Rows.Add();

                dataGridView1.Rows[i].Cells[0].Value = xdata.Rows[i].ItemArray[0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = xdata.Rows[i].ItemArray[1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = xdata.Rows[i].ItemArray[2].ToString();
                dataGridView1.Rows[i].Cells[3].Value = xdata.Rows[i].ItemArray[3].ToString();
                dataGridView1.Rows[i].Cells[4].Value = xdata.Rows[i].ItemArray[4].ToString();
                dataGridView1.Rows[i].Cells[5].Value = xdata.Rows[i].ItemArray[5].ToString();
                dataGridView1.Rows[i].Cells[6].Value = xdata.Rows[i].ItemArray[6].ToString();
                dataGridView1.Rows[i].Cells[7].Value = xdata.Rows[i].ItemArray[7].ToString();
                dataGridView1.Rows[i].Cells[8].Value = xdata.Rows[i].ItemArray[8].ToString();



            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            string id;

            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            xcon.Open();
            SqlCommand xcmd = new SqlCommand("delete from bok_isu where id = " + id + "", xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();

            MessageBox.Show("Deleted");


            showdata();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            this.Close();

        }

        


    }

}
