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
//using System.Threading;///////////////

namespace LIBRARY_MANAGMENT_SOFTWARE
{
    public partial class Form3 : Form
    {
        //Thread th;/////////////////

        SqlConnection xcon;
        public Form3()
        {
            xcon = new SqlConnection();
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //tabPage1.BackColor = Color.Red;
            //tabPage1.BackFadeColor = Color.White;
            //tabPage1.BorderColor = Color.DarkRed;
            //String d = DateTime.Now.ToString("dd.MM.yyyy");
            //label1.Text = d;

            StreamReader file = new StreamReader(("Connection/Connection.txt"), true);
            String con = file.ReadLine();
            xcon.ConnectionString = con;


            
            show_return();
             
           
        }

        void show_return4()
        {
            String dat;
            dat = DateTime.Now.ToString("dd/MM/yyyy");

            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where (Borrowers_Name='" + textBox1.Text + "' and Received='" + null + "')", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);

            for (int i = 0; i < xdata.Rows.Count; i++)
            {


                dataGridView4.Rows.Add();

                dataGridView4.Rows[i].Cells[0].Value = xdata.Rows[i].ItemArray[0].ToString();
                dataGridView4.Rows[i].Cells[1].Value = xdata.Rows[i].ItemArray[1].ToString();
                dataGridView4.Rows[i].Cells[2].Value = xdata.Rows[i].ItemArray[2].ToString();
                dataGridView4.Rows[i].Cells[3].Value = xdata.Rows[i].ItemArray[3].ToString();
                dataGridView4.Rows[i].Cells[4].Value = xdata.Rows[i].ItemArray[4].ToString();
                dataGridView4.Rows[i].Cells[5].Value = xdata.Rows[i].ItemArray[5].ToString();
                dataGridView4.Rows[i].Cells[6].Value = xdata.Rows[i].ItemArray[6].ToString();
                dataGridView4.Rows[i].Cells[7].Value = xdata.Rows[i].ItemArray[7].ToString();
                //dataGridView1.Rows[i].Cells[8].Value = xdata.Rows[i].ItemArray[8].ToString();

            }

        }
        void show_return3()
        {
            String dat;
            dat = DateTime.Now.ToString("dd/MM/yyyy");
            //DateTime start1 = DateTime.Parse(dat);



            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Due_Date >'" + dat + "' and Received='" + null + "'", xcon);
            //SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Due_Date >'" + dat + "''", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);

            for (int i = 0; i < xdata.Rows.Count; i++)
            {


                dataGridView3.Rows.Add();

                dataGridView3.Rows[i].Cells[0].Value = xdata.Rows[i].ItemArray[0].ToString();
                dataGridView3.Rows[i].Cells[1].Value = xdata.Rows[i].ItemArray[1].ToString();
                dataGridView3.Rows[i].Cells[2].Value = xdata.Rows[i].ItemArray[2].ToString();
                dataGridView3.Rows[i].Cells[3].Value = xdata.Rows[i].ItemArray[3].ToString();
                dataGridView3.Rows[i].Cells[4].Value = xdata.Rows[i].ItemArray[4].ToString();
                dataGridView3.Rows[i].Cells[5].Value = xdata.Rows[i].ItemArray[5].ToString();
                dataGridView3.Rows[i].Cells[6].Value = xdata.Rows[i].ItemArray[6].ToString();
                dataGridView3.Rows[i].Cells[7].Value = xdata.Rows[i].ItemArray[7].ToString();
                //dataGridView1.Rows[i].Cells[8].Value = xdata.Rows[i].ItemArray[8].ToString();

            }

        }


        void show_return2()
        {
            String dat;
            dat = DateTime.Now.ToString("dd/MM/yyyy");

            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where (Due_Date <'" + dat + "' and Received='" + null + "')", xcon);
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
                //dataGridView1.Rows[i].Cells[8].Value = xdata.Rows[i].ItemArray[8].ToString();

            }

        }
        

        void show_return()
        {
            String dat;
            dat = DateTime.Now.ToString("dd/MM/yyyy");

            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where (Due_Date like'" + dat + "' and Received='" + null + "')", xcon);
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
                //dataGridView1.Rows[i].Cells[8].Value = xdata.Rows[i].ItemArray[8].ToString();
               
            }
 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)//set your checkbox column index instead of 2
            {
                if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[8].EditedFormattedValue) == true)
                {
                    string id;
                    id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    xcon.Open();
                    SqlCommand xcmd = new SqlCommand("update bok_isu set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
                    xcmd.ExecuteNonQuery();
                    xcmd.Dispose();

                    SqlCommand xcmd2 = new SqlCommand("update bok_isu_rec set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
                    xcmd2.ExecuteNonQuery();
                    xcmd2.Dispose();
                    xcon.Close();

                    dataGridView1.Rows.Clear();

                    show_return();
                    //Paste your code here
                }
            }
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

            //dataGridView1.Rows.Clear();

            //show_return();

          
            //this.Close();
            //th = new Thread(opennewform);
            //th.SetApartmentState(ApartmentState.STA);
            //th.Start();



        }

     
        private void button1_Click(object sender, EventArgs e)
        {      
          

        }

        //private void opennewform(object obj)
        //{
        //    Application.Run(new Form3());
            
        //}
       

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            String dat;
            dat = DateTime.Now.ToString("dd/MM/yyyy");

            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where (Due_Date <'" + dat + "' and Received='" + null + "')", xcon);
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
                //dataGridView1.Rows[i].Cells[8].Value = xdata.Rows[i].ItemArray[8].ToString();

            }
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();

            String dat;
            dat = DateTime.Now.ToString("dd/MM/yyyy");

            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where (Due_Date >'" + dat + "' and Received='" + null + "')", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);

            for (int i = 0; i < xdata.Rows.Count; i++)
            {


                dataGridView3.Rows.Add();

                dataGridView3.Rows[i].Cells[0].Value = xdata.Rows[i].ItemArray[0].ToString();
                dataGridView3.Rows[i].Cells[1].Value = xdata.Rows[i].ItemArray[1].ToString();
                dataGridView3.Rows[i].Cells[2].Value = xdata.Rows[i].ItemArray[2].ToString();
                dataGridView3.Rows[i].Cells[3].Value = xdata.Rows[i].ItemArray[3].ToString();
                dataGridView3.Rows[i].Cells[4].Value = xdata.Rows[i].ItemArray[4].ToString();
                dataGridView3.Rows[i].Cells[5].Value = xdata.Rows[i].ItemArray[5].ToString();
                dataGridView3.Rows[i].Cells[6].Value = xdata.Rows[i].ItemArray[6].ToString();
                dataGridView3.Rows[i].Cells[7].Value = xdata.Rows[i].ItemArray[7].ToString();
                //dataGridView1.Rows[i].Cells[8].Value = xdata.Rows[i].ItemArray[8].ToString();

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)//set your checkbox column index instead of 2
            {
                if (Convert.ToBoolean(dataGridView2.Rows[e.RowIndex].Cells[8].EditedFormattedValue) == true)
                {
                    string id;
                    id = dataGridView2.CurrentRow.Cells[0].Value.ToString();

                    xcon.Open();
                    SqlCommand xcmd = new SqlCommand("update bok_isu set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
                    xcmd.ExecuteNonQuery();
                    xcmd.Dispose();

                    SqlCommand xcmd2 = new SqlCommand("update bok_isu_rec set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
                    xcmd2.ExecuteNonQuery();
                    xcmd2.Dispose();
                    xcon.Close();

                    dataGridView2.Rows.Clear();

                    show_return2();
                    //Paste your code here
                }
            }
            //string id;
            //id = dataGridView2.CurrentRow.Cells[0].Value.ToString();


            //xcon.Open();
            //SqlCommand xcmd = new SqlCommand("update bok_isu set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
            //xcmd.ExecuteNonQuery();
            //xcmd.Dispose();

            //SqlCommand xcmd2 = new SqlCommand("update bok_isu_rec set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
            //xcmd2.ExecuteNonQuery();
            //xcmd2.Dispose();
            //xcon.Close();

            //dataGridView2.Rows.Clear();
            //show_return2();

            //this.Close();
            //th = new Thread(opennewform);
            //th.SetApartmentState(ApartmentState.STA);
            //th.Start();
            
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)//set your checkbox column index instead of 2
            {
                if (Convert.ToBoolean(dataGridView3.Rows[e.RowIndex].Cells[8].EditedFormattedValue) == true)
                {
                    string id;
                    id = dataGridView3.CurrentRow.Cells[0].Value.ToString();

                    xcon.Open();
                    SqlCommand xcmd = new SqlCommand("update bok_isu set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
                    xcmd.ExecuteNonQuery();
                    xcmd.Dispose();

                    SqlCommand xcmd2 = new SqlCommand("update bok_isu_rec set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
                    xcmd2.ExecuteNonQuery();
                    xcmd2.Dispose();
                    xcon.Close();

                    dataGridView3.Rows.Clear();
                    show_return3();
                    //Paste your code here
                }
            }
            //string id;
            //id = dataGridView3.CurrentRow.Cells[0].Value.ToString();


            //xcon.Open();
            //SqlCommand xcmd = new SqlCommand("update bok_isu set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
            //xcmd.ExecuteNonQuery();
            //xcmd.Dispose();

            //SqlCommand xcmd2 = new SqlCommand("update bok_isu_rec set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
            //xcmd2.ExecuteNonQuery();
            //xcmd2.Dispose();
            //xcon.Close();

            //dataGridView3.Rows.Clear();

            //show_return3();

            
            //this.Close();
            //th = new Thread(opennewform);
            //th.SetApartmentState(ApartmentState.STA);
            //th.Start();
        }

        
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();

            String dat;
            dat = DateTime.Now.ToString("dd/MM/yyyy");

            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where (Borrowers_Name='"+textBox1.Text+"' and Received='"+null+"' )", xcon);
            DataTable xdata = new DataTable();
            xadapt.Fill(xdata);

            for (int i = 0; i < xdata.Rows.Count; i++)
            {


                dataGridView4.Rows.Add();

                dataGridView4.Rows[i].Cells[0].Value = xdata.Rows[i].ItemArray[0].ToString();
                dataGridView4.Rows[i].Cells[1].Value = xdata.Rows[i].ItemArray[1].ToString();
                dataGridView4.Rows[i].Cells[2].Value = xdata.Rows[i].ItemArray[2].ToString();
                dataGridView4.Rows[i].Cells[3].Value = xdata.Rows[i].ItemArray[3].ToString();
                dataGridView4.Rows[i].Cells[4].Value = xdata.Rows[i].ItemArray[4].ToString();
                dataGridView4.Rows[i].Cells[5].Value = xdata.Rows[i].ItemArray[5].ToString();
                dataGridView4.Rows[i].Cells[6].Value = xdata.Rows[i].ItemArray[6].ToString();
                dataGridView4.Rows[i].Cells[7].Value = xdata.Rows[i].ItemArray[7].ToString();
                //dataGridView1.Rows[i].Cells[8].Value = xdata.Rows[i].ItemArray[8].ToString();

            }

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)//set your checkbox column index instead of 2
            {
                if (Convert.ToBoolean(dataGridView4.Rows[e.RowIndex].Cells[8].EditedFormattedValue) == true)
                {
                    string id;
                    id = dataGridView4.CurrentRow.Cells[0].Value.ToString();

                    xcon.Open();
                    SqlCommand xcmd = new SqlCommand("update bok_isu set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
                    xcmd.ExecuteNonQuery();
                    xcmd.Dispose();

                    SqlCommand xcmd2 = new SqlCommand("update bok_isu_rec set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
                    xcmd2.ExecuteNonQuery();
                    xcmd2.Dispose();
                    xcon.Close();

                    dataGridView4.Rows.Clear();

                    show_return4();
                    //Paste your code here
                }
            }
            //string id;
            //id = dataGridView4.CurrentRow.Cells[0].Value.ToString();


            //xcon.Open();
            //SqlCommand xcmd = new SqlCommand("update bok_isu set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
            //xcmd.ExecuteNonQuery();
            //xcmd.Dispose();

            //SqlCommand xcmd2 = new SqlCommand("update bok_isu_rec set Received = '" + Column9.TrueValue + "' where Id = " + id + "", xcon);
            //xcmd2.ExecuteNonQuery();
            //xcmd2.Dispose();
            //xcon.Close();

            //dataGridView4.Rows.Clear();

            //show_return4();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
            this.Close();
        }

        

        
       

        

       

       

        

       
        

       

        
        
        
        

       

        

        

        

        

       
    


    }
}
