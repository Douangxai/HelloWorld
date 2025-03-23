namespace Cau4
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemnodegoc = new System.Windows.Forms.Button();
            this.btnThemnodecon = new System.Windows.Forms.Button();
            this.btnXoaallNode = new System.Windows.Forms.Button();
            this.btnXoaNodechon = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAn = new System.Windows.Forms.Button();
            this.txtNode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(33, 90);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(525, 462);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Treeview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiêu đề Node";
            // 
            // btnThemnodegoc
            // 
            this.btnThemnodegoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThemnodegoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnodegoc.Location = new System.Drawing.Point(577, 155);
            this.btnThemnodegoc.Name = "btnThemnodegoc";
            this.btnThemnodegoc.Size = new System.Drawing.Size(447, 56);
            this.btnThemnodegoc.TabIndex = 4;
            this.btnThemnodegoc.Text = "Thêm Node gốc";
            this.btnThemnodegoc.UseVisualStyleBackColor = false;
            this.btnThemnodegoc.Click += new System.EventHandler(this.btnThemnodegoc_Click);
            // 
            // btnThemnodecon
            // 
            this.btnThemnodecon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThemnodecon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnodecon.Location = new System.Drawing.Point(577, 238);
            this.btnThemnodecon.Name = "btnThemnodecon";
            this.btnThemnodecon.Size = new System.Drawing.Size(447, 56);
            this.btnThemnodecon.TabIndex = 4;
            this.btnThemnodecon.Text = "Thêm Node con";
            this.btnThemnodecon.UseVisualStyleBackColor = false;
            this.btnThemnodecon.Click += new System.EventHandler(this.btnThemnodecon_Click);
            // 
            // btnXoaallNode
            // 
            this.btnXoaallNode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoaallNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaallNode.Location = new System.Drawing.Point(577, 321);
            this.btnXoaallNode.Name = "btnXoaallNode";
            this.btnXoaallNode.Size = new System.Drawing.Size(447, 56);
            this.btnXoaallNode.TabIndex = 4;
            this.btnXoaallNode.Text = "Xóa tất cả các Node";
            this.btnXoaallNode.UseVisualStyleBackColor = false;
            this.btnXoaallNode.Click += new System.EventHandler(this.btnXoaallNode_Click);
            // 
            // btnXoaNodechon
            // 
            this.btnXoaNodechon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoaNodechon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNodechon.Location = new System.Drawing.Point(577, 404);
            this.btnXoaNodechon.Name = "btnXoaNodechon";
            this.btnXoaNodechon.Size = new System.Drawing.Size(447, 56);
            this.btnXoaNodechon.TabIndex = 4;
            this.btnXoaNodechon.Text = "Xóa Node đang chọn";
            this.btnXoaNodechon.UseVisualStyleBackColor = false;
            this.btnXoaNodechon.Click += new System.EventHandler(this.btnXoaNodechon_Click);
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(577, 487);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(447, 56);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Đếm tổng Node Treeview";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(577, 568);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(132, 69);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "+";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAn
            // 
            this.btnAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAn.Location = new System.Drawing.Point(892, 568);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(132, 69);
            this.btnAn.TabIndex = 5;
            this.btnAn.Text = "-";
            this.btnAn.UseVisualStyleBackColor = true;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // txtNode
            // 
            this.txtNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNode.Location = new System.Drawing.Point(732, 96);
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(292, 32);
            this.txtNode.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1068, 672);
            this.Controls.Add(this.txtNode);
            this.Controls.Add(this.btnAn);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnXoaNodechon);
            this.Controls.Add(this.btnXoaallNode);
            this.Controls.Add(this.btnThemnodecon);
            this.Controls.Add(this.btnThemnodegoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemnodegoc;
        private System.Windows.Forms.Button btnThemnodecon;
        private System.Windows.Forms.Button btnXoaallNode;
        private System.Windows.Forms.Button btnXoaNodechon;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.TextBox txtNode;
    }
}

