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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SupermarketTuto
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
            ShowEmployee();
            ShowEmployeeBill();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\c# project\SpuerMarket application\DB\SuperS1\SuperS1.mdf"";Integrated Security=True;Connect Timeout=30");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ProQuaTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void ShowEmployee()
        {
            Con.Open();
            string Query = "Select ProName,ProQua from ProductDb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProSellingDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            // ShowEmployee();
        }

        private void ProSellingDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProNameTb.Text = ProSellingDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProPriceTb.Text = ProSellingDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SellingDate.Text = DateTime.Today.ToString()+ " / " + DateTime.Today.Month.ToString() + " / " + DateTime.Today.Year.ToString();
        }

        private void SellingDate_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ProductEdit_Click(object sender, EventArgs e)
        {

        }

        int Grdtotal = 0, n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            // int n = 0,total = Convert.ToInt32(ProPriceTb.Text) * Convert.ToInt32(ProQuaTb.Text);
           

            if (ProNameTb.Text =="" || ProQuaTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else 
            {
                int  total = Convert.ToInt32(ProPriceTb.Text) * Convert.ToInt32(ProQuaTb.Text);
              

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProNameTb.Text;
                newRow.Cells[2].Value = ProPriceTb.Text;
                newRow.Cells[3].Value = ProQuaTb.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProPriceTb.Text) * Convert.ToInt32(ProQuaTb.Text);
                OrderDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                AmtLb.Text = "Rs: " + Grdtotal;

            }

        }

        private void ShowEmployeeBill()
        {
            Con.Open();
            string Query = "Select * from BillTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ProductSave_Click(object sender, EventArgs e)
        {

            if (BillIdTb.Text == "" || ProNameTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BillTb(BillId,SellerName,BillDate,TotAmt ) values(@BI,@BN,@BD,@BT)", Con);
                    cmd.Parameters.AddWithValue("@BI", BillIdTb.Text);
                    cmd.Parameters.AddWithValue("@BN", ProNameTb.Text);
                    cmd.Parameters.AddWithValue("@BD", SellingDate.Text);
                    cmd.Parameters.AddWithValue("@BT", Grdtotal);
                    


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Saved");

                    Con.Close();
                    ShowEmployeeBill();
                    //Clear();
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
           
        }

        private void AmtLb_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void OrderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
