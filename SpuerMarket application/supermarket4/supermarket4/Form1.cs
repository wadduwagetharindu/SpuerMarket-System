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

namespace supermarket4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project\c# project\SpuerMarket application\DB\SuperS4.mdf"";Integrated Security=True;Connect Timeout=30");
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into aaaa(Id,NAME,DEC ) values(@CI,@CN,@CD)", Con);
                    cmd.Parameters.AddWithValue("@CI", textBox1.Text);
                    cmd.Parameters.AddWithValue("@CN", textBox2.Text);
                    cmd.Parameters.AddWithValue("@CD", textBox3.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee saved");

                    Con.Close();
                    /* ShowEmployee();
                     Clear();*/
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
