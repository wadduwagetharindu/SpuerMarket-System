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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
            ShowEmployee();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\c# project\SpuerMarket application\DB\SuperS1\SuperS1.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Clear()
        {
           
            SellerIdTb.Text = "";
            SellerNameTb.Text = "";
            SellerAgeTb.Text = "";
            SellerPhoneTb.Text = "";
            SellerPassTb.Text = "";
        }
             
                 //  SellerDGV eke pennanne Me method eken (ShoEmployee() )
        private void ShowEmployee()
        {
            Con.Open();
            string Query = "Select * from SellerDb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SellerAddBtn_Click(object sender, EventArgs e)
        {
            
            if (SellerIdTb.Text == "" || SellerNameTb.Text == "" || SellerAgeTb.Text =="" || SellerPhoneTb.Text == "" || SellerPassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SellerDb(SellerId,SellerName,SellerAge,SellerPhone,SellerPassword ) values(@SI,@SN,@SA,@SP,@SPASS)", Con);
                    cmd.Parameters.AddWithValue("@SI", SellerIdTb.Text);
                    cmd.Parameters.AddWithValue("@SN", SellerNameTb.Text);
                    cmd.Parameters.AddWithValue("@SA", SellerAgeTb.Text);
                    cmd.Parameters.AddWithValue("@SP", SellerPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@SPASS", SellerPassTb.Text);


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

        int Key = 0;
        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SellerIdTb.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellerNameTb.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            SellerAgeTb.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            SellerPhoneTb.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            SellerPassTb.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (SellerIdTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SellerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SellerEditBtn_Click(object sender, EventArgs e)
        {

            if (SellerIdTb.Text == "" || SellerNameTb.Text == "" || SellerAgeTb.Text == "" || SellerPhoneTb.Text == "" ||SellerPassTb.Text == "")

            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("Update SellerDb Set SellerId=@SI,SellerName=@SN,SellerAge=@SA, SellerPhone=@SP, SellerPassword=@SPASS where SellerId=@SKey ", Con);
                    cmd.Parameters.AddWithValue("@SI", SellerIdTb.Text);
                    cmd.Parameters.AddWithValue("@SN", SellerNameTb.Text);                                                                                   
                    cmd.Parameters.AddWithValue("@SA", SellerAgeTb.Text);
                    cmd.Parameters.AddWithValue("@SP", SellerPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@SPASS", SellerPassTb.Text);
                    cmd.Parameters.AddWithValue("@SKey", Key);

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

        private void SellerDeleteBtn_Click(object sender, EventArgs e)
        {
            if (SellerIdTb.Text == "" || SellerNameTb.Text == "" || SellerAgeTb.Text == "" || SellerPhoneTb.Text == "" || SellerPassTb.Text == "")

            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from SellerDb where SellerId=@SKey", Con);
                    cmd.Parameters.AddWithValue("@SKey", Key);

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
    }

       
    
}
