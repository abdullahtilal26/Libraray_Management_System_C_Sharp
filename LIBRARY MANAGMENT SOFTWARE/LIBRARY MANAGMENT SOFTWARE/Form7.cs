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
    public partial class Form7 : Form
    {
        SqlConnection xcon;

        public Form7()
        {
            xcon = new SqlConnection();
            InitializeComponent();
        }

        
        private void Form7_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(("Connection/Connection.txt"), true);
            string con = file.ReadLine();

            xcon.ConnectionString = con;

            show();

        }


        void show()
        {
           
           

            SqlDataAdapter xadapt = new SqlDataAdapter("select * from Userr ", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);

            for (int i = 0; i < xdata.Rows.Count; i++)
            {


                dataGridView1.Rows.Add();

                dataGridView1.Rows[i].Cells[0].Value = xdata.Rows[i].ItemArray[0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = xdata.Rows[i].ItemArray[1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = xdata.Rows[i].ItemArray[2].ToString();
               
            }
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xcon.Open();
            SqlCommand xcmd = new SqlCommand("insert into userr values('" + textBox1.Text + "','" + textBox2.Text + "')", xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();
            MessageBox.Show("Created");
            textBox1.Clear();
            textBox2.Clear();
            show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

           string id,user,pwd;

           id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           user = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           pwd=dataGridView1.CurrentRow.Cells[2].Value.ToString();


            xcon.Open();
            SqlCommand xcmd = new SqlCommand("update userr set Userr_Name='"+user+"',Passwordd='"+pwd+"' where Id='"+id+"'", xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();

            MessageBox.Show("Updated");
            dataGridView1.Rows.Clear();
            show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id;
            id=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            xcon.Open();
            SqlCommand xcmd=new SqlCommand("delete from userr where Id ='"+id+"'",xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();

            MessageBox.Show("Deleted");
            dataGridView1.Rows.Clear();
            show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (File.Exists(("Admin/usert.txt")))
            {

                File.Delete(("Admin/usert.txt"));
            }


            StreamWriter conwrt = new StreamWriter(("Admin/usert.txt"),true);
            conwrt.WriteLine(textBox3.Text.ToString());
            conwrt.Flush();
            conwrt.Dispose();
            MessageBox.Show("Username Changed");
            textBox3.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists(("Admin/pswd.txt")))
            {
                File.Delete(("Admin/pswd.txt"));
            }


            StreamWriter conwrt = new StreamWriter(("Admin/pswd.txt"), true);
            conwrt.WriteLine(textBox4.Text.ToString());
            conwrt.Flush();
            conwrt.Dispose();
            MessageBox.Show("Password Changed");
            textBox4.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
                        

            string txt;
            txt=textBox5.Text;

            SqlDataAdapter xadapt = new SqlDataAdapter(""+txt+"", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);

            for (int i = 0; i < xdata.Rows.Count; i++)
            {
                dataGridView2.Rows.Add();

                dataGridView2.Rows[i].Cells[0].Value = xdata.Rows[i].ItemArray[0].ToString();
                dataGridView2.Rows[i].Cells[1].Value = xdata.Rows[i].ItemArray[1].ToString();
                dataGridView2.Rows[i].Cells[2].Value = xdata.Rows[i].ItemArray[2].ToString();
                dataGridView2.Rows[i].Cells[3].Value = xdata.Rows[i].ItemArray[3].ToString();
                dataGridView2.Rows[i].Cells[4].Value = xdata.Rows[i].ItemArray[4].ToString();
                dataGridView2.Rows[i].Cells[5].Value = xdata.Rows[i].ItemArray[5].ToString();
                dataGridView2.Rows[i].Cells[6].Value = xdata.Rows[i].ItemArray[6].ToString();
                dataGridView2.Rows[i].Cells[7].Value = xdata.Rows[i].ItemArray[7].ToString();
                dataGridView2.Rows[i].Cells[8].Value = xdata.Rows[i].ItemArray[8].ToString();

            }

            MessageBox.Show("Select Quarry Successfull");
            
            

        }

        
        private void button7_Click_1(object sender, EventArgs e)
        {
            string txt;
            txt=textBox6.Text;
            xcon.Open();
            SqlCommand xcmd = new SqlCommand("" + txt + "", xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();
            MessageBox.Show("Insert Quarry Successfull");
            
            }

        private void button8_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
            this.Close();
        }



        

       


    }
}
