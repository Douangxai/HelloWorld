using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cau4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemnodegoc_Click(object sender, EventArgs e)
        {
            bool t = false;
            if (!string.IsNullOrEmpty(txtNode.Text))
            {
                TreeNode Node = new TreeNode();
                Node.Text = txtNode.Text;
                foreach (TreeNode nodex in treeView1.Nodes)
                {
                    if (string.Equals(Node.Text, nodex.Text))
                    {
                        MessageBox.Show("Node đã tồn tại");
                        t = true;
                    }
                }
                if (t == false) treeView1.Nodes.Add(Node);
                txtNode.Clear();
                txtNode.Focus();
            }
            else
                MessageBox.Show("Node không được để trống");
        }

        private void btnThemnodecon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNode.Text))
            {
                if (treeView1.SelectedNode != null)
                {
                    TreeNode Subnode = new TreeNode();
                    Subnode.Text = txtNode.Text;
                    treeView1.SelectedNode.Nodes.Add(Subnode);
                    txtNode.Clear();
                    txtNode.Focus();
                }
                else
                    MessageBox.Show("Bạn chưa chọn vị trí tạo Node con");
            }
            else
                MessageBox.Show("Node không được để trống");
        }

        private void btnXoaallNode_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void btnXoaNodechon_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
                treeView1.SelectedNode.Remove();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int n = treeView1.GetNodeCount(true);
            MessageBox.Show("Tổng số Node của TreeView : " + n);
        }
    }
}
