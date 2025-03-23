namespace Bai4
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nhap = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nhap = new System.Windows.Forms.Button();
            this.lstBox_hienthi = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_xoadangchon = new System.Windows.Forms.Button();
            this.btn_xoadau = new System.Windows.Forms.Button();
            this.btn_xoatatca = new System.Windows.Forms.Button();
            this.btn_xoacuoi = new System.Windows.Forms.Button();
            this.txt_hienthi = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Fuchsia;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(320, 25, 320, 25);
            this.label1.Size = new System.Drawing.Size(946, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHAI BÁO Y TẾ ĐIỆN TỬ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // txt_nhap
            // 
            this.txt_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhap.Location = new System.Drawing.Point(90, 79);
            this.txt_nhap.Multiline = true;
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(242, 50);
            this.txt_nhap.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btn_nhap);
            this.panel1.Controls.Add(this.txt_nhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 477);
            this.panel1.TabIndex = 3;
            // 
            // btn_nhap
            // 
            this.btn_nhap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nhap.Location = new System.Drawing.Point(90, 179);
            this.btn_nhap.Name = "btn_nhap";
            this.btn_nhap.Size = new System.Drawing.Size(169, 48);
            this.btn_nhap.TabIndex = 3;
            this.btn_nhap.Text = "Nhập thông tin";
            this.btn_nhap.UseVisualStyleBackColor = false;
            this.btn_nhap.Click += new System.EventHandler(this.btn_nhap_Click);
            // 
            // lstBox_hienthi
            // 
            this.lstBox_hienthi.FormattingEnabled = true;
            this.lstBox_hienthi.ItemHeight = 25;
            this.lstBox_hienthi.Location = new System.Drawing.Point(364, 85);
            this.lstBox_hienthi.Name = "lstBox_hienthi";
            this.lstBox_hienthi.Size = new System.Drawing.Size(525, 254);
            this.lstBox_hienthi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng số người đã khai báo";
            // 
            // btn_xoadangchon
            // 
            this.btn_xoadangchon.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_xoadangchon.Location = new System.Drawing.Point(380, 418);
            this.btn_xoadangchon.Name = "btn_xoadangchon";
            this.btn_xoadangchon.Size = new System.Drawing.Size(232, 49);
            this.btn_xoadangchon.TabIndex = 6;
            this.btn_xoadangchon.Text = "Xóa thông tin đang chọn";
            this.btn_xoadangchon.UseVisualStyleBackColor = false;
            this.btn_xoadangchon.Click += new System.EventHandler(this.btn_xoadangchon_Click);
            // 
            // btn_xoadau
            // 
            this.btn_xoadau.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_xoadau.Location = new System.Drawing.Point(647, 418);
            this.btn_xoadau.Name = "btn_xoadau";
            this.btn_xoadau.Size = new System.Drawing.Size(232, 49);
            this.btn_xoadau.TabIndex = 6;
            this.btn_xoadau.Text = "Xóa thông tin đầu";
            this.btn_xoadau.UseVisualStyleBackColor = false;
            this.btn_xoadau.Click += new System.EventHandler(this.btn_xoadau_Click);
            // 
            // btn_xoatatca
            // 
            this.btn_xoatatca.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_xoatatca.Location = new System.Drawing.Point(380, 489);
            this.btn_xoatatca.Name = "btn_xoatatca";
            this.btn_xoatatca.Size = new System.Drawing.Size(232, 49);
            this.btn_xoatatca.TabIndex = 6;
            this.btn_xoatatca.Text = "Xóa tất cả thông tin";
            this.btn_xoatatca.UseVisualStyleBackColor = false;
            this.btn_xoatatca.Click += new System.EventHandler(this.btn_xoatatca_Click);
            // 
            // btn_xoacuoi
            // 
            this.btn_xoacuoi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_xoacuoi.Location = new System.Drawing.Point(647, 489);
            this.btn_xoacuoi.Name = "btn_xoacuoi";
            this.btn_xoacuoi.Size = new System.Drawing.Size(232, 49);
            this.btn_xoacuoi.TabIndex = 6;
            this.btn_xoacuoi.Text = "Xóa thông tin cuối";
            this.btn_xoacuoi.UseVisualStyleBackColor = false;
            this.btn_xoacuoi.Click += new System.EventHandler(this.btn_xoacuoi_Click);
            // 
            // txt_hienthi
            // 
            this.txt_hienthi.Location = new System.Drawing.Point(630, 361);
            this.txt_hienthi.Name = "txt_hienthi";
            this.txt_hienthi.Size = new System.Drawing.Size(235, 30);
            this.txt_hienthi.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 561);
            this.Controls.Add(this.txt_hienthi);
            this.Controls.Add(this.btn_xoacuoi);
            this.Controls.Add(this.btn_xoatatca);
            this.Controls.Add(this.btn_xoadau);
            this.Controls.Add(this.btn_xoadangchon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBox_hienthi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nhap;
        private System.Windows.Forms.ListBox lstBox_hienthi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_xoadangchon;
        private System.Windows.Forms.Button btn_xoadau;
        private System.Windows.Forms.Button btn_xoatatca;
        private System.Windows.Forms.Button btn_xoacuoi;
        private System.Windows.Forms.TextBox txt_hienthi;
    }
}

