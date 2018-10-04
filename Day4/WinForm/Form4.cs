using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form4 : Form
    {
        Random rd = new Random(37);
        public Form4()
        {
            InitializeComponent();
            lstv1.Columns.Add("Name");
            lstv1.Columns.Add("Depth");
        }

        void TreeToList()
        {
            lstv1.Items.Clear();
            foreach (TreeNode node in trv1.Nodes)
            {
                TreeToList(node);
            }
        }

        void TreeToList(TreeNode node)
        {
            lstv1.Items.Add(new ListViewItem(new string[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() }));
            foreach (TreeNode n in node.Nodes)
            {
                TreeToList(n);
            }
        }

        private void addRoot_Click(object sender, EventArgs e)
        {
            trv1.Nodes.Add(rd.Next().ToString());
            TreeToList();
        }

        private void addChild_Click(object sender, EventArgs e)
        {
            if (trv1.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드 없음.", "treeView테스트", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            trv1.SelectedNode.Nodes.Add(rd.Next().ToString());
            trv1.SelectedNode.Expand();
            TreeToList();
        }
    }
}
