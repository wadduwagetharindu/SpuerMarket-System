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

namespace SupermarketTuto
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            ShowEmployee();
            GetEmployees();
            Clear();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            GetEmployeeName();
            display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            display();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\c# project\SpuerMarket application\DB\SuperS1\SuperS1.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {

            ProIdTb.Text = "";
            ProNameTb.Text = "";
            ProQuaTb.Text = "";
            ProPriceTb.Text = "";
            comboBox1.Text = "";
        }

        private void GetEmployees()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from CatDb", Con);
            SqlDataReader Rdr;
            Rdr = Cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CId", typeof(int));
            dt.Load(Rdr);
            comboBox1.ValueMember = "CName";
            comboBox1.DataSource = dt;
           

            Con.Close();
        }

        //   ................    //
        
           private void GetEmployeeName()
           {


               string Query = "Select * from CatDb ";

               SqlDataAdapter da = new SqlDataAdapter(Query, Con);

               Con.Open();
               DataSet dt = new DataSet();
               da.Fill(dt, "CName");
               comboBox2.DisplayMember = "CName";
               comboBox2.ValueMember = "CName";
               comboBox2.DataSource = dt.Tables["CName"];
               Con.Close();
               if (comboBox2.Items.Count>1)
               {
                   comboBox2.SelectedIndex = -1;
               }


           }

        private void display()
        {
            SqlCommand Query = new SqlCommand("Select * from ProductDb where ProCat like '%" + comboBox2.Text + "'", Con);
            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = Query;
            dt2.Clear();
            da2.Fill(dt2);
            ProductDGV.DataSource = dt2;
        }
   
        private void ShowEmployee()
           {
               Con.Open();
               string Query = "Select * from ProductDb";
               SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
               SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
               var ds = new DataSet();
               sda.Fill(ds);
               ProductDGV.DataSource = ds.Tables[0];
               Con.Close();
           }
          
        private void ProductSave_Click(object sender, EventArgs e)
            {

                if (ProIdTb.Text == "" || ProNameTb.Text == "" || ProQuaTb.Text == "" || ProPriceTb.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("insert into ProductDb(ProId,ProName,ProQua,ProPrice,ProCat ) values(@PI,@PN,@PQ,@PP,@PC)", Con);
                        cmd.Parameters.AddWithValue("@PI", ProIdTb.Text);
                        cmd.Parameters.AddWithValue("@PN", ProNameTb.Text);
                        cmd.Parameters.AddWithValue("@PQ", ProQuaTb.Text);
                        cmd.Parameters.AddWithValue("@PP", ProPriceTb.Text);
                        cmd.Parameters.AddWithValue("@PC", comboBox1.Text);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seller Saved");

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
        

            private void ProName_OnValueChanged(object sender, EventArgs e)
            {

            }

            int Key = 0;
            private void ProductEdit_Click(object sender, EventArgs e)
            {
                if (ProIdTb.Text == "" || ProNameTb.Text == "" || ProQuaTb.Text == "" || ProPriceTb.Text == "" || comboBox1.Text == "")

                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        Con.Open();

                        SqlCommand cmd = new SqlCommand("Update ProductDb Set ProId=@PI,ProNAme=@PN,ProQua=@PQ, ProPrice=@PP, ProCat=@PC where ProId=@PKey ", Con);
                        cmd.Parameters.AddWithValue("@PI", ProIdTb.Text);
                        cmd.Parameters.AddWithValue("@PN", ProNameTb.Text);
                        cmd.Parameters.AddWithValue("@PQ", ProQuaTb.Text);
                        cmd.Parameters.AddWithValue("@PP", ProPriceTb.Text);
                        cmd.Parameters.AddWithValue("@PC", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@PKey", Key);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seller Edited");

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

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProIdTb.Text = ProductDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProNameTb.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProQuaTb.Text = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProPriceTb.Text = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
           

            if (ProIdTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void ProductDelete_Click(object sender, EventArgs e)
        {
            if (ProIdTb.Text == "" || ProNameTb.Text == "" || ProQuaTb.Text == "" || ProPriceTb.Text == "" || comboBox1.Text == "")

            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from ProductDb where ProId=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted");

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

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void RefreshTb(object sender, EventArgs e)
        {
            
            GetEmployeeName();
          
        }
    }
} 
