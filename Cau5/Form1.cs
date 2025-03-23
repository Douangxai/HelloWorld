using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar == ' ') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;

            int dayofmonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            dateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dayofmonth);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else if (!string.IsNullOrEmpty(txtHoTen.Text) || !string.IsNullOrEmpty(txtSDT.Text) ||
                !string.IsNullOrEmpty(txtEmail.Text) == true)
            {
                MessageBox.Show("Chúc mừng bạn: " + txtHoTen.Text + "\nSố Điện Thoại: " + txtSDT.Text + "\nEmail: "
                    + txtEmail.Text + "\nThời gian lựa chọn: " + dateTimePicker1.Value.ToShortDateString());
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
