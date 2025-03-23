using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
        private void txt_num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
        private void btn_plus_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_num1.Text) + Convert.ToInt32(txt_num2.Text);
            txt_result.Text = result.ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_num1.Text) - Convert.ToInt32(txt_num2.Text);
            txt_result.Text = result.ToString();
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txt_num1.Text) * Convert.ToInt32(txt_num2.Text);
            txt_result.Text = result.ToString();
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            Double result = Convert.ToDouble(txt_num1.Text) / Convert.ToDouble(txt_num2.Text);
            txt_result.Text = result.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_num1.Clear();

            txt_num2.Clear();

            txt_result.Clear();
        }
    }
}
