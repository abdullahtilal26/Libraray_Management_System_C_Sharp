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
    public partial class Form1 : Form
    {
        SqlConnection xcon;

        public Form1()
        {
            InitializeComponent();

            xcon = new SqlConnection();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Gr_# = '" + textBox1.Text + "'", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);
            dataGridView1.DataSource = xdata;
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            xcon.Open();
            SqlCommand xcmd = new SqlCommand("insert into bok_isu values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBoxbookid.Text+"','" + textBox5.Text + "', '" + textBox6.Text + "','')", xcon);//for table bok_isu
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            SqlCommand xcmd2 = new SqlCommand("insert into bok_isu_rec values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBoxbookid.Text+"','" + textBox5.Text + "','" + textBox6.Text + "','')", xcon);//for table bok_isu_rec (for all previous record)
            xcmd2.ExecuteNonQuery();
            xcmd2.Dispose();
            xcon.Close();
            MessageBox.Show("Issued");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBoxbookid.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(("Connection/Connection.txt"), true);
            String con = file.ReadLine();

            xcon.ConnectionString = con;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 FRM2 = new Form2();
            FRM2.ShowDialog();
            this.Close();

        }

        private void labelbookid_Click(object sender, EventArgs e)
        {

        }

        private void textBoxbookid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox6.Text = dateTimePicker2.Value.ToString("dd/MM/yyyy");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
            this.Close();
        }

        

        

        
    }
}
 