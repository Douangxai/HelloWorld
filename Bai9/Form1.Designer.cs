namespace Bai9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtDayDate = new System.Windows.Forms.TextBox();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCountday = new System.Windows.Forms.Button();
            this.btnCountHour = new System.Windows.Forms.Button();
            this.txthour = new System.Windows.Forms.TextBox();
            this.txtday = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MONTH CALENDAR";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(26, 106);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "SelectionStart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "SelectionEnd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "MinDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "MaxDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "DayDate";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(195, 29);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(220, 30);
            this.txtStart.TabIndex = 3;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(195, 68);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(220, 30);
            this.txtEnd.TabIndex = 3;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(195, 107);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(220, 30);
            this.txtmin.TabIndex = 3;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(195, 146);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(220, 30);
            this.txtMax.TabIndex = 3;
            // 
            // txtDayDate
            // 
            this.txtDayDate.Location = new System.Drawing.Point(195, 185);
            this.txtDayDate.Name = "txtDayDate";
            this.txtDayDate.Size = new System.Drawing.Size(220, 30);
            this.txtDayDate.TabIndex = 3;
            // 
            // btnHienthi
            // 
            this.btnHienthi.BackColor = System.Drawing.Color.LightGray;
            this.btnHienthi.Location = new System.Drawing.Point(195, 224);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(221, 35);
            this.btnHienthi.TabIndex = 4;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = false;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Count day from Select range";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Count Hour from Select range";
            // 
            // btnCountday
            // 
            this.btnCountday.BackColor = System.Drawing.Color.LightGray;
            this.btnCountday.Location = new System.Drawing.Point(510, 389);
            this.btnCountday.Name = "btnCountday";
            this.btnCountday.Size = new System.Drawing.Size(221, 35);
            this.btnCountday.TabIndex = 4;
            this.btnCountday.Text = "Count Day";
            this.btnCountday.UseVisualStyleBackColor = false;
            this.btnCountday.Click += new System.EventHandler(this.btnCountday_Click);
            // 
            // btnCountHour
            // 
            this.btnCountHour.BackColor = System.Drawing.Color.LightGray;
            this.btnCountHour.Location = new System.Drawing.Point(510, 445);
            this.btnCountHour.Name = "btnCountHour";
            this.btnCountHour.Size = new System.Drawing.Size(221, 35);
            this.btnCountHour.TabIndex = 4;
            this.btnCountHour.Text = "Count Hour";
            this.btnCountHour.UseVisualStyleBackColor = false;
            this.btnCountHour.Click += new System.EventHandler(this.btnCountHour_Click);
            // 
            // txthour
            // 
            this.txthour.Location = new System.Drawing.Point(327, 447);
            this.txthour.Name = "txthour";
            this.txthour.Size = new System.Drawing.Size(149, 30);
            this.txthour.TabIndex = 6;
            // 
            // txtday
            // 
            this.txtday.Location = new System.Drawing.Point(327, 394);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(149, 30);
            this.txtday.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHienthi);
            this.groupBox1.Controls.Add(this.txtDayDate);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.txtmin);
            this.groupBox1.Controls.Add(this.txtEnd);
            this.groupBox1.Controls.Add(this.txtStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(315, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 278);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Day_Month_Year";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(788, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.txthour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCountHour);
            this.Controls.Add(this.btnCountday);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtDayDate;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCountday;
        private System.Windows.Forms.Button btnCountHour;
        private System.Windows.Forms.TextBox txthour;
        private System.Windows.Forms.TextBox txtday;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

