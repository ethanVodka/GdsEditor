using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDSEDITOR
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


            Pnl_MegreVia.Dock= DockStyle.Fill;
            Pnl_FillMesh.Dock= DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(Pnl_FillMesh);
            splitContainer1.Panel1.Controls.Add(Pnl_MegreVia);
        }

        private void SplitContainer2_Panel1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void SplitContainer2_Panel1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void FillMeshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pnl_FillMesh.BringToFront();
        }

        private void MergeViaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pnl_MegreVia.BringToFront();
        }
    }
}
