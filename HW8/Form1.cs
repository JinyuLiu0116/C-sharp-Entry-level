using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void bt_Submit_Click(object sender, EventArgs e)
        {
            string firstName = tb_firstN.Text;
            string lastName = tb_lastN.Text;
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Empty input");
            }
            else if (!firstName.All(char.IsLetter) || !lastName.All(char.IsLetter)) 
            {
                MessageBox.Show("Invalid input charcator");
            }
            else
            {
                lb_welcome.Text = $"Hello {firstName} {lastName}, welcome!";
            }
        }

        private void lb_last_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_welcome.Text = "";
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_firstN.Text = "";
            tb_lastN.Text = "";
            lb_welcome.Text = "";
        }
    }
}

