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
using System.Drawing.Printing;



namespace LIBRARY_MANAGMENT_SOFTWARE
{
    public partial class Form4 : Form
    {
        SqlConnection xcon;

        public Form4()
        {
           
            InitializeComponent();
            xcon = new SqlConnection();
            
        }

        
        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(("Connection/Connection.txt"), true);
            String con = file.ReadLine();
            xcon.ConnectionString = con;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            dataGridView1.Rows.Clear();
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Id like '" + textBox1.Text + "' or Gr_# like '" + textBox1.Text + "' or Borrowers_Name like'" + textBox1.Text + "'or  Class like'" + textBox1.Text + "' or Book_Name like '" + textBox1.Text + "' or Book_Id like '" + textBox1.Text + "' or Issuing_Date like '" + textBox1.Text + "' or Due_Date like '" + textBox1.Text + "' or Received like '" + textBox1.Text + "' ", xcon);
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
    

        private void button2_Click(object sender, EventArgs e)
        {

            string id,gr, borrowers_nam, clas, bok_nam, bok_id, issu_dat, due_dat;

            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            gr = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            borrowers_nam=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            clas=dataGridView1.CurrentRow.Cells[3].Value.ToString();
            bok_nam=dataGridView1.CurrentRow.Cells[4].Value.ToString();
            bok_id=dataGridView1.CurrentRow.Cells[5].Value.ToString();
            issu_dat=dataGridView1.CurrentRow.Cells[6].Value.ToString();
            due_dat=dataGridView1.CurrentRow.Cells[7].Value.ToString();

            xcon.Open();
            SqlCommand xcmd = new SqlCommand("update bok_isu set Gr_#='"+gr+"',Borrowers_Name='"+borrowers_nam+"',Class='"+clas+"',Book_Name='"+bok_nam+"', Book_Id='"+bok_id+"', Issuing_Date='"+issu_dat+"', Due_Date='"+due_dat+"' where Id='"+id+"'", xcon);
            xcmd.ExecuteNonQuery();
            xcmd.Dispose();
            xcon.Close();

            MessageBox.Show("Updated");
            dataGridView1.Rows.Clear();
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Id='"+textBox2.Text+"'  ", xcon);
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

            radioButton1.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Gr_#='" + textBox2.Text + "'  ", xcon);
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
            radioButton2.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Borrowers_Name='" + textBox2.Text + "'  ", xcon);
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
            radioButton3.Checked = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Class='" + textBox2.Text + "'  ", xcon);
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

            radioButton6.Checked = false;
        } 

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Book_Name='" + textBox2.Text + "'  ", xcon);
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
            radioButton5.Checked = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Book_Id='" + textBox2.Text + "'  ", xcon);
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
            radioButton4.Checked = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Issuing_Date ='" + textBox2.Text + "'  ", xcon);
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
            radioButton9.Checked = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Due_Date='" + textBox2.Text + "'  ", xcon);
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
            radioButton8.Checked = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Received='received'  ", xcon);
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
            radioButton7.Checked = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBox2.Text = null;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font f = new Font(FontFamily.GenericSansSerif, 15);
            Pen p = new Pen(Brushes.Black, 3);

            string id, gr, borrowers_nam, clas, bok_nam, bok_id, issu_dat, due_dat, recev;

            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            gr = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            borrowers_nam = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            clas = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            bok_nam = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            bok_id = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            issu_dat = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            due_dat = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            recev = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            //-----------------------------------HEADING-----------------------------------------
            e.Graphics.DrawRectangle(p, new Rectangle(92, 100, 250, 50));
            e.Graphics.DrawString("Specific Search Result", f, Brushes.Blue, new Rectangle(100, 110, 500, 50));
            //-------------------------------Id---------------------------------------------

            e.Graphics.DrawString(" Id:", f, Brushes.Blue, new Rectangle(100, 200, 500, 50));
            e.Graphics.DrawString(id, f, Brushes.Red, new Rectangle(140, 200, 500, 50));
            //--------------------Gr_#---------------------------------

            e.Graphics.DrawString("Gr# :", f, Brushes.Blue, new Rectangle(100, 250, 500, 50));
            e.Graphics.DrawString(gr, f, Brushes.Red, new Rectangle(155, 250, 500, 50));

            //--------------------Borrowers_Name---------------------------------

            e.Graphics.DrawString("Borrower's Name :", f, Brushes.Blue, new Rectangle(100, 300, 500, 50));
            e.Graphics.DrawString(borrowers_nam, f, Brushes.Red, new Rectangle(276, 300, 500, 50));

            //--------------------Class---------------------------------

            e.Graphics.DrawString("Class :", f, Brushes.Blue, new Rectangle(100, 350, 500, 50));
            e.Graphics.DrawString(clas, f, Brushes.Red, new Rectangle(180, 350, 500, 50));
            //--------------------Book_name---------------------------------

            e.Graphics.DrawString("Book Name :", f, Brushes.Blue, new Rectangle(100, 400, 500, 50));
            e.Graphics.DrawString(bok_nam, f, Brushes.Red, new Rectangle(229, 400, 500, 50));
            //--------------------Book_id---------------------------------

            e.Graphics.DrawString("Book Id :", f, Brushes.Blue, new Rectangle(100, 450, 500, 50));
            e.Graphics.DrawString(bok_id, f, Brushes.Red, new Rectangle(200, 450, 500, 50));
            //--------------------Isuuing date---------------------------------

            e.Graphics.DrawString("Issuing Date :", f, Brushes.Blue, new Rectangle(100, 500, 500, 50));
            e.Graphics.DrawString(issu_dat, f, Brushes.Red, new Rectangle(230, 500, 500, 50));

            //--------------------Due date---------------------------------

            e.Graphics.DrawString("Due Date:", f, Brushes.Blue, new Rectangle(100, 550, 500, 50));
            e.Graphics.DrawString(due_dat, f, Brushes.Red, new Rectangle(200, 550, 500, 50));

            //--------------------Recevied---------------------------------

            e.Graphics.DrawString("Recevied :", f, Brushes.Blue, new Rectangle(100, 600, 500, 50));
            e.Graphics.DrawString(recev, f, Brushes.Red, new Rectangle(200, 600, 500, 50));
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.ShowDialog();
        }
      
        private void button6_Click(object sender, EventArgs e)
        {
            
            printDocument3.DefaultPageSettings.Landscape = true;
            printPreviewDialog3.Document = printDocument3;
            printPreviewDialog3.ShowDialog();
            
        
            //    //{
        //    SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Id like '" + textBox1.Text + "' or Gr_# like '" + textBox1.Text + "'", xcon);
        //    //{
        ////    SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Id like '" + textBox1.Text + "' or Gr_# like '" + textBox1.Text + "' or Borrowers_Name like'" + textBox1.Text + "'or  Class like'" + textBox1.Text + "' or Book_Name like '" + textBox1.Text + "' or Book_Id like '" + textBox1.Text + "' or Issuing_Date like '" + textBox1.Text + "' or Due_Date like '" + textBox1.Text + "' or Received like '" + textBox1.Text + "' ", xcon);
        //    //DataSet1 dat = new DataSet1();
        //    //xadapt.Fill(dat);
        //    DataSet1 ds = new DataSet1();
        //    xadapt.Fill(ds,"DataTable1");
        //    dataGridView3.DataSource = ds.Tables[0];

        //    //Form5 frm5 = new Form5();
            //frm5.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font f = new Font(FontFamily.GenericSansSerif, 15);
            Pen p = new Pen(Brushes.Black, 3);

            string id, gr, borrowers_nam, clas, bok_nam, bok_id, issu_dat, due_dat, recev;

            id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            gr = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            borrowers_nam = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            clas = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            bok_nam = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            bok_id = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            issu_dat = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            due_dat = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            recev = dataGridView2.CurrentRow.Cells[8].Value.ToString();

            //-----------------------------------HEADING-----------------------------------------
            e.Graphics.DrawRectangle(p, new Rectangle(92, 100, 250, 50));
            e.Graphics.DrawString("Specific Search Result", f, Brushes.Blue, new Rectangle(100, 110, 500, 50));
            //-------------------------------Id---------------------------------------------

            e.Graphics.DrawString(" Id:", f, Brushes.Blue, new Rectangle(100, 200, 500, 50));
            e.Graphics.DrawString(id, f, Brushes.Red, new Rectangle(140, 200, 500, 50));
            //--------------------Gr_#---------------------------------

            e.Graphics.DrawString("Gr# :", f, Brushes.Blue, new Rectangle(100, 250, 500, 50));
            e.Graphics.DrawString(gr, f, Brushes.Red, new Rectangle(155, 250, 500, 50));

            //--------------------Borrowers_Name---------------------------------

            e.Graphics.DrawString("Borrower's Name :", f, Brushes.Blue, new Rectangle(100, 300, 500, 50));
            e.Graphics.DrawString(borrowers_nam, f, Brushes.Red, new Rectangle(276, 300, 500, 50));

            //--------------------Class---------------------------------

            e.Graphics.DrawString("Class :", f, Brushes.Blue, new Rectangle(100, 350, 500, 50));
            e.Graphics.DrawString(clas, f, Brushes.Red, new Rectangle(180, 350, 500, 50));
            //--------------------Book_name---------------------------------

            e.Graphics.DrawString("Book Name :", f, Brushes.Blue, new Rectangle(100, 400, 500, 50));
            e.Graphics.DrawString(bok_nam, f, Brushes.Red, new Rectangle(229, 400, 500, 50));
            //--------------------Book_id---------------------------------

            e.Graphics.DrawString("Book Id :", f, Brushes.Blue, new Rectangle(100, 450, 500, 50));
            e.Graphics.DrawString(bok_id, f, Brushes.Red, new Rectangle(200, 450, 500, 50));
            //--------------------Isuuing date---------------------------------

            e.Graphics.DrawString("Issuing Date :", f, Brushes.Blue, new Rectangle(100, 500, 500, 50));
            e.Graphics.DrawString(issu_dat, f, Brushes.Red, new Rectangle(230, 500, 500, 50));

            //--------------------Due date---------------------------------

            e.Graphics.DrawString("Due Date:", f, Brushes.Blue, new Rectangle(100, 550, 500, 50));
            e.Graphics.DrawString(due_dat, f, Brushes.Red, new Rectangle(200, 550, 500, 50));

            //--------------------Recevied---------------------------------

            e.Graphics.DrawString("Recevied :", f, Brushes.Blue, new Rectangle(100, 600, 500, 50));
            e.Graphics.DrawString(recev, f, Brushes.Red, new Rectangle(200, 600, 500, 50));
        }
        int i = 0;
        private void printDocument3_PrintPage(object sender, PrintPageEventArgs e)
        {

            int height = 0;
            int width = 0;

            Pen p = new Pen(Brushes.Black, 2.5f);

            #region id_col
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(100, 100, 100, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(100-30-10, 100, 70, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Columns[0].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(100-30-10, 100, 70, dataGridView1.Rows[0].Height));
            #endregion

            #region gr#_col
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(100 + 100, 100, 100, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(100 -30-10 +73, 100, 80, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Columns[1].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(100 -30-10+ 73, 100, 80, dataGridView1.Rows[0].Height));
            #endregion

            #region borrowers_name
            ////e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(155 +100, 100, 100, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(190 -30+ 55, 100, 180, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Columns[2].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(190-30 + 55, 100, 180, dataGridView1.Rows[0].Height));
            #endregion


            #region Class
            ////e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(210 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(100 + 295, 100, 70, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Columns[3].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(100 + 295, 100, 70, dataGridView1.Rows[0].Height));
            #endregion

            #region Book_name
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(265 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(400 + 63, 100, 200, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Columns[4].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(400 + 63+50, 100, 170, dataGridView1.Rows[0].Height));
            #endregion

            #region Bok_id
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(320 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(315 + 300+50, 100, 100, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Columns[5].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(315 + 300+50, 100, 100, dataGridView1.Rows[0].Height));
            #endregion


            #region issu_date
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(375 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(615 + 100+50, 100, 110, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Columns[6].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(615 + 100+50, 100, 110, dataGridView1.Rows[0].Height));
            #endregion


            #region due_dat
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(430 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(724 + 100+50, 100, 120, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Columns[7].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(724 + 100+50, 100, 120, dataGridView1.Rows[0].Height));
            #endregion


            #region Recevied
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(485 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(845 + 100+50, 100, 78, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Columns[8].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(845 + 100+50, 100, 78, dataGridView1.Rows[0].Height));
            #endregion

            height = 100;

            while (i < dataGridView1.Rows.Count)
            {
                height += dataGridView1.Rows[0].Height;

            e.Graphics.DrawRectangle(p, new Rectangle(100-30-10, height, 70, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(100-30-10, height, 70, dataGridView1.Rows[0].Height));

            e.Graphics.DrawRectangle(p, new Rectangle(100 -30-10+ 73, height, 80, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(100-30-10 + 73, height, 80, dataGridView1.Rows[0].Height));

            e.Graphics.DrawRectangle(p, new Rectangle(190 -30+ 55, height, 180, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(190 -30+ 55, height, 180, dataGridView1.Rows[0].Height));

            e.Graphics.DrawRectangle(p, new Rectangle(100 + 295, height, 70, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(100 + 295, height, 70, dataGridView1.Rows[0].Height));

            e.Graphics.DrawRectangle(p, new Rectangle(400 + 63, height, 200, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(400 + 63, height, 200, dataGridView1.Rows[0].Height));

            e.Graphics.DrawRectangle(p, new Rectangle(315 + 300+50, height, 100, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(315 + 300+50, height, 100, dataGridView1.Rows[0].Height));

            e.Graphics.DrawRectangle(p, new Rectangle(615 + 100+50, height, 110, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(615 + 100+50, height, 110, dataGridView1.Rows[0].Height));

            e.Graphics.DrawRectangle(p, new Rectangle(724 + 100+50, height, 120, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[7].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(724 + 100+50, height, 120, dataGridView1.Rows[0].Height));

            e.Graphics.DrawRectangle(p, new Rectangle(845 + 100+50, height, 78, dataGridView1.Rows[0].Height));
            e.Graphics.DrawString(dataGridView1.Rows[i].Cells[8].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(845 + 100+50, height, 78, dataGridView1.Rows[0].Height));

            i++;

            }
            

           //Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
           //dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, dataGridView1.Height));
           // e.Graphics.DrawImage(bm, 0, 0);

            //int height = 0;
            //int width = 0;

            //Pen p = new Pen(Brushes.Black, 2.5f);

            //#region id_col
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(100, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawRectangle(p, new Rectangle(100, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawString(dataGridView1.Columns[0].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(100, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //#endregion

            //#region gr#_col
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(100 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawRectangle(p, new Rectangle(100 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawString(dataGridView1.Columns[1].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(100 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //#endregion

            //#region borrowers_name
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(155 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawRectangle(p, new Rectangle(155 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawString(dataGridView1.Columns[2].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(155 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //#endregion


            //#region Class
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(210 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawRectangle(p, new Rectangle(210 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawString(dataGridView1.Columns[3].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(210 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //#endregion

            //#region Book_name
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(265 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawRectangle(p, new Rectangle(265 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawString(dataGridView1.Columns[4].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(265 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //#endregion

            //#region Bok_id
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(320 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawRectangle(p, new Rectangle(320 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawString(dataGridView1.Columns[5].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(320 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //#endregion


            //#region issu_date
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(375 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawRectangle(p, new Rectangle(375 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawString(dataGridView1.Columns[6].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(375 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //#endregion


            //#region due_dat
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(430 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawRectangle(p, new Rectangle(430 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawString(dataGridView1.Columns[7].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(430 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //#endregion


            //#region Recevied
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(485 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawRectangle(p, new Rectangle(485 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //e.Graphics.DrawString(dataGridView1.Columns[8].HeaderText.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(485 + dataGridView1.Columns[0].Width, 100, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //#endregion

            //height = 100;

            //while (i < dataGridView1.Rows.Count)
            //{
            //    height += dataGridView1.Rows[0].Height;

            //    e.Graphics.DrawRectangle(p, new Rectangle(100, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(100, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

            //    e.Graphics.DrawRectangle(p, new Rectangle(100 + dataGridView1.Columns[0].Width, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(100, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

            //    e.Graphics.DrawRectangle(p, new Rectangle(155 + dataGridView1.Columns[0].Width, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(155, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

            //    e.Graphics.DrawRectangle(p, new Rectangle(210 + dataGridView1.Columns[0].Width, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(210, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

            //    e.Graphics.DrawRectangle(p, new Rectangle(265 + dataGridView1.Columns[0].Width, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(265, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

            //    e.Graphics.DrawRectangle(p, new Rectangle(320 + dataGridView1.Columns[0].Width, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(320, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

            //    e.Graphics.DrawRectangle(p, new Rectangle(375 + dataGridView1.Columns[0].Width, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(375, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

            //    e.Graphics.DrawRectangle(p, new Rectangle(430 + dataGridView1.Columns[0].Width, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[7].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(430, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

            //    e.Graphics.DrawRectangle(p, new Rectangle(485 + dataGridView1.Columns[0].Width, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
            //    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[8].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, new Rectangle(485, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));

            //    i++;

            //}


        }

        private void printPreviewDialog3_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            printDocument3.DefaultPageSettings.Landscape = true;
            printDocument4.DefaultPageSettings.PaperSize = new PaperSize("Custom", this.dataGridView2.Width + 50, this.dataGridView2.Height + 10);
            printPreviewDialog4.Document = printDocument4;
            printPreviewDialog4.ShowDialog();
        }

        private void printDocument4_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView2.Width, this.dataGridView2.Height);
            dataGridView2.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView2.Width, dataGridView2.Height));
            e.Graphics.DrawImage(bm, 0, 0);

            //Bitmap resized = new Bitmap(bm, new Size(bm.Width/2, bm.Height /4));

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
            this.Close();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            SqlDataAdapter xadapt = new SqlDataAdapter("select * from bok_isu where Received='"+null+"'",xcon);
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
            radioButton10.Checked = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        
        

        
        

      
       

        

        
       



    }
}
