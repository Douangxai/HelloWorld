namespace Bai6
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_complete = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_ngaythang = new System.Windows.Forms.Label();
            this.lbl_gio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(50, 30, 530, 30);
            this.label1.Size = new System.Drawing.Size(704, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bây giờ là:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(31, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hiển thị ngày giờ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(272, 162);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(367, 47);
            this.progressBar1.TabIndex = 2;
            // 
            // lbl_complete
            // 
            this.lbl_complete.AutoSize = true;
            this.lbl_complete.Location = new System.Drawing.Point(385, 113);
            this.lbl_complete.Name = "lbl_complete";
            this.lbl_complete.Size = new System.Drawing.Size(79, 29);
            this.lbl_complete.TabIndex = 3;
            this.lbl_complete.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 276);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(180, 30, 180, 30);
            this.label3.Size = new System.Drawing.Size(783, 89);
            this.label3.TabIndex = 4;
            this.label3.Text = "Xin chào các bạn đến với plpsoft.vn";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_ngaythang
            // 
            this.lbl_ngaythang.AutoSize = true;
            this.lbl_ngaythang.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_ngaythang.ForeColor = System.Drawing.Color.White;
            this.lbl_ngaythang.Location = new System.Drawing.Point(207, 29);
            this.lbl_ngaythang.Name = "lbl_ngaythang";
            this.lbl_ngaythang.Size = new System.Drawing.Size(0, 29);
            this.lbl_ngaythang.TabIndex = 5;
            // 
            // lbl_gio
            // 
            this.lbl_gio.AutoSize = true;
            this.lbl_gio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_gio.ForeColor = System.Drawing.Color.White;
            this.lbl_gio.Location = new System.Drawing.Point(394, 29);
            this.lbl_gio.Name = "lbl_gio";
            this.lbl_gio.Size = new System.Drawing.Size(0, 29);
            this.lbl_gio.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(685, 362);
            this.Controls.Add(this.lbl_gio);
            this.Controls.Add(this.lbl_ngaythang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_complete);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_complete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_ngaythang;
        private System.Windows.Forms.Label lbl_gio;
    }
}

