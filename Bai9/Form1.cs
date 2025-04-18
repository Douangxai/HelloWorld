﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            txtStart.Text = monthCalendar1.SelectionStart.ToShortDateString();

            txtEnd.Text = monthCalendar1.SelectionEnd.ToShortDateString();

            txtmin.Text = monthCalendar1.MinDate.ToShortDateString();

            txtMax.Text = monthCalendar1.MaxDate.ToShortDateString();

            txtDayDate.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void btnCountday_Click(object sender, EventArgs e)
        {
            int numdays;

            numdays = Convert.ToInt32((monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart).TotalDays);

            txtday.Text = numdays.ToString();
        }

        private void btnCountHour_Click(object sender, EventArgs e)
        {
            int numhour;

            numhour = Convert.ToInt32((monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart).TotalHours);

            txthour.Text = numhour.ToString();
        }
    }
}
