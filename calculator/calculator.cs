using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            long firstNum = 0;
            long secondNum = 0;
            long total = 0;
           
            if (!long.TryParse(tb_firstNum.Text, out firstNum))
            {
                lb_error_firstNum.Text = "Invalid input";
                firstNum = 0;
                tb_firstNum.Focus();
                tb_result.Text = "";
            }
            else 
            {
                lb_error_firstNum.Text = "";
            }
             
            if (!long.TryParse(tb_secondNum.Text, out secondNum))
            {
                lb_error_secondNum.Text = "Invalid input";
                secondNum = 0;
                tb_secondNum.Focus();
                tb_result.Text = "";
            }
            else
            {
                lb_error_secondNum.Text = "";
            }

            total = firstNum + secondNum;
            tb_result.Text = total.ToString();
            //MessageBox.Show("The total is " + total);
        }
    }
}
