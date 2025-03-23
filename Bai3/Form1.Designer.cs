namespace Bai3
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
            this.lb_doimau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_color = new System.Windows.Forms.ComboBox();
            this.btn_doimau = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_doimau
            // 
            this.lb_doimau.AutoSize = true;
            this.lb_doimau.BackColor = System.Drawing.Color.Yellow;
            this.lb_doimau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doimau.ForeColor = System.Drawing.Color.Red;
            this.lb_doimau.Location = new System.Drawing.Point(101, 62);
            this.lb_doimau.Name = "lb_doimau";
            this.lb_doimau.Size = new System.Drawing.Size(545, 36);
            this.lb_doimau.TabIndex = 0;
            this.lb_doimau.Text = "Chào mừng bạn đến với plpsoft.vn     \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn màu";
            // 
            // cbo_color
            // 
            this.cbo_color.FormattingEnabled = true;
            this.cbo_color.Items.AddRange(new object[] {
            "Yellow",
            "Red",
            "Blue",
            "Black"});
            this.cbo_color.Location = new System.Drawing.Point(247, 161);
            this.cbo_color.Name = "cbo_color";
            this.cbo_color.Size = new System.Drawing.Size(304, 33);
            this.cbo_color.TabIndex = 2;
            // 
            // btn_doimau
            // 
            this.btn_doimau.Location = new System.Drawing.Point(146, 238);
            this.btn_doimau.Name = "btn_doimau";
            this.btn_doimau.Size = new System.Drawing.Size(136, 44);
            this.btn_doimau.TabIndex = 3;
            this.btn_doimau.Text = "Đổi màu";
            this.btn_doimau.UseVisualStyleBackColor = true;
            this.btn_doimau.Click += new System.EventHandler(this.btn_doimau_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(380, 238);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(136, 44);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 360);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_doimau);
            this.Controls.Add(this.cbo_color);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_doimau);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_doimau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_color;
        private System.Windows.Forms.Button btn_doimau;
        private System.Windows.Forms.Button btn_thoat;
    }
}

