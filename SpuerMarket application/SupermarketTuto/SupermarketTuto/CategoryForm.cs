using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace SupermarketTuto
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            ShowEmployee();
            Clear();


        }

       
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\c# project\SpuerMarket application\DB\SuperS1\SuperS1.mdf"";Integrated Security=True;Connect Timeout=30");

      
        private void button6_Click(object sender, EventArgs e)
            {

            /*
            try
            {
                Con.Open();
                string query = "insert into CatDb values(" + CatIdTb.Text + ", '" + CatNameTb.Text + "', '" + CatDescTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Save Category");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Con.Close();
            */
        }

        private void CatIdTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            CatIdTb.Text = "";
            CatNameTb.Text = "";
            CatDescTb.Text = "";
        }
        private void ShowEmployee()
        {
            Con.Open();
            string Query = "Select * from CatDb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
  
             
           if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")

            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CatDb(CId,CName,CDec ) values(@CI,@CN,@CD)", Con);
                    cmd.Parameters.AddWithValue("@CI", CatIdTb.Text);
                    cmd.Parameters.AddWithValue("@CN", CatNameTb.Text);
                    cmd.Parameters.AddWithValue("@CD", CatDescTb.Text); 

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee saved");

                    Con.Close();
                    ShowEmployee();
                     Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();

            
        }

        int Key = 0;
        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();

            if (CatIdTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CatDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


        private void populate()
        {
            Con.Open();
            string query = ("select * from CatDb");
            SqlDataAdapter sad = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sad);
            var ds = new DataTable();
            sad.Fill(ds);
            //CatDGV.DataSource = ds.Tables[0];
           CatDGV.DataSource = ds;
            Con.Close();
        }
        

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
            Con.Close();
        }
       
        private void button8_Click(object sender, EventArgs e)
        {
            

            /*

            try
            {
                 if(CatIdTb.Text =="")
                 {
                     MessageBox.Show("Missing Information");
                 }
                 else
                 {
                     Con.Open();
                     string query = "delete from CatDb where CId " + CatIdTb.Text + "";
                     SqlCommand cmd = new SqlCommand(query, Con);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Category delete");
                     Con.Close();
                     populate();
                 }
             }
             catch(Exception ex) 
             {
                 MessageBox.Show(ex.Message);
             }
             Con.Close();
               
             */
            
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

           // if (Key ==0)
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")

                {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from CatDb where CId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Delete");

                    Con.Close();
                    ShowEmployee();
                     Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")

            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update CatDb Set CId=@CI,CName=@CN,CDec=@CD where CId=@CKey ", Con);
                    cmd.Parameters.AddWithValue("@CI", CatIdTb.Text);
                    cmd.Parameters.AddWithValue("@CN", CatNameTb.Text);
                    cmd.Parameters.AddWithValue("@CD", CatDescTb.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee saved");

                    Con.Close();
                    ShowEmployee();
                     Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }
    }

 }


