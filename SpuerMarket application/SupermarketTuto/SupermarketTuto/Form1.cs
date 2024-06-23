using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      /*  private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }*/

        private void Clear_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            UPasswordTb.Text = "";
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text == ""  || UPasswordTb.Text == "")
            {
                MessageBox.Show("Eneter The UserName And Password");
            }
            else
            {
                if (LSelect.SelectedIndex > -1)
                {
                    if (LSelect.SelectedItem.ToString() == "ADMIN") 
                    {
                        if (UNameTb.Text == "Admin" && UPasswordTb.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You are the Admin, Enter the Correct UserName And Password ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You In The Seller Section");
                    }
                }
                else 
                {
                    MessageBox.Show("Select A Role");
                }
                    
                
            }
        }
    }
}
