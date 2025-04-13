namespace Cau3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cau3.Properties.Resources.postqoom;
            this.pictureBox1.Location = new System.Drawing.Point(22, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Context Menu Strip";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(336, 269);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(215, 29);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Ngày Tháng Năm";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(336, 209);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(127, 29);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Thời Gian";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExitToolStripMenuItem,
            this.displayTimeToolStripMenuItem,
            this.displayDateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // menuExitToolStripMenuItem
            // 
            this.menuExitToolStripMenuItem.Name = "menuExitToolStripMenuItem";
            this.menuExitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + T";
            this.menuExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menuExitToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.menuExitToolStripMenuItem.Text = "MenuExit";
            this.menuExitToolStripMenuItem.Click += new System.EventHandler(this.menuExitToolStripMenuItem_Click);
            // 
            // displayTimeToolStripMenuItem
            // 
            this.displayTimeToolStripMenuItem.Name = "displayTimeToolStripMenuItem";
            this.displayTimeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.displayTimeToolStripMenuItem.Text = "Display Time";
            this.displayTimeToolStripMenuItem.Click += new System.EventHandler(this.displayTimeToolStripMenuItem_Click);
            // 
            // displayDateToolStripMenuItem
            // 
            this.displayDateToolStripMenuItem.Name = "displayDateToolStripMenuItem";
            this.displayDateToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.displayDateToolStripMenuItem.Text = "Display Date";
            this.displayDateToolStripMenuItem.Click += new System.EventHandler(this.displayDateToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 421);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDateToolStripMenuItem;
    }
}

