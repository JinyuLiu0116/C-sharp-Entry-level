using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Assignment3
{
    public partial class Form1 : Form
    {
        // gobal list variable, allow even driven to access it
        List<BanckAcount> bAcounts = new List<BanckAcount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void creatAcount_Click(object sender, EventArgs e)
        {
            //check if user input is null
            if(string.IsNullOrEmpty(tb_onwerName.Text))
            {
                MessageBox.Show("Account name cannot be empty");
                return; 
            }
            //create object of banckAcount class and pass text from text view
            BanckAcount bAcount = new BanckAcount(tb_onwerName.Text);

            bAcounts.Add(bAcount);
            CleanGrid();
            tb_onwerName.Text = string.Empty;// clean text box
        }
        private void CleanGrid()
        {
            //clear data before add new data to it
            DGV_bankAcount.DataSource = null;
            //connect list of BanckAcount to data group view
            DGV_bankAcount.DataSource = bAcounts;
        }

        private void deposit_Click(object sender, EventArgs e)
        {   
            
            
            //debug if user only select one row and number entered is not negative
            if (DGV_bankAcount.SelectedRows.Count ==0)
            {
                MessageBox.Show("Please select an account");
            }
            //not allow select multiple rows
            else if (DGV_bankAcount.SelectedRows.Count > 1)
            {
                MessageBox.Show("You can only select one account");
            }
            else
            {
                //take the data from selected row and convert it into BanckAcount
                BanckAcount selectedAccount = DGV_bankAcount.SelectedRows[0]
                    .DataBoundItem as BanckAcount;
                //message to store returned string error message
                string message=selectedAccount.Deposit(NUD_amount.Value);
                CleanGrid();
                NUD_amount.Value = 0;
                MessageBox.Show(message);//show arror message
            }
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            if (DGV_bankAcount.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an account");
            }
            else if (DGV_bankAcount.SelectedRows.Count > 1)
            {
                MessageBox.Show("You can only select one account");
            }
            else
            {
                BanckAcount selectedAccount = DGV_bankAcount.SelectedRows[0]
                    .DataBoundItem as BanckAcount;
                string message = selectedAccount.Withdraw(NUD_amount.Value);
                CleanGrid();
                NUD_amount.Value = 0;
                MessageBox.Show(message);
            }

        }
    }
}

