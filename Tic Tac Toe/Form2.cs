using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        private void btnTek_Click(object sender, EventArgs e)
        {
            FrmYpy frmYpy = new FrmYpy();
            frmYpy.Show();
            this.Hide();
        }

        private void btnCift_Click(object sender, EventArgs e)
        {
            frmOyun frmOyun = new frmOyun();
            frmOyun.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
