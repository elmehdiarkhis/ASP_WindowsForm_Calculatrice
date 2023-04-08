using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculatrice_Test1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void calculatricesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void standardMnu_Click(object sender, EventArgs e)
        {
            frmStand fs = new frmStand();
            fs.MdiParent = this;
            fs.Show();
        }

        private void quittezMnu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir quitez l'application ? ","Attention,Fermeture",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void scientifiqueMnu_Click(object sender, EventArgs e)
        {
            frmScien fsc = new frmScien();
            fsc.MdiParent = this;
            fsc.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmStand fs = new frmStand();
            fs.MdiParent = this;
            fs.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmScien fsc = new frmScien();
            fsc.MdiParent = this;
            fsc.Show();
        }

        private void toolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
