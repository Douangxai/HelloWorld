namespace HelloWorld
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
            this.lb_hoten = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.btn_hoten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_hoten
            // 
            this.lb_hoten.AutoSize = true;
            this.lb_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoten.Location = new System.Drawing.Point(42, 61);
            this.lb_hoten.Name = "lb_hoten";
            this.lb_hoten.Size = new System.Drawing.Size(86, 20);
            this.lb_hoten.TabIndex = 0;
            this.lb_hoten.Text = "Họ và Tên\r\n";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(155, 59);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(376, 22);
            this.txt_hoten.TabIndex = 1;
            this.txt_hoten.TextChanged += new System.EventHandler(this.txt_hoten_TextChanged);
            // 
            // btn_hoten
            // 
            this.btn_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoten.Location = new System.Drawing.Point(227, 112);
            this.btn_hoten.Name = "btn_hoten";
            this.btn_hoten.Size = new System.Drawing.Size(94, 41);
            this.btn_hoten.TabIndex = 2;
            this.btn_hoten.Text = "Hiển thị";
            this.btn_hoten.UseVisualStyleBackColor = true;
            this.btn_hoten.Click += new System.EventHandler(this.btn_hoten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 252);
            this.Controls.Add(this.btn_hoten);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.lb_hoten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_hoten;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Button btn_hoten;
    }
}

