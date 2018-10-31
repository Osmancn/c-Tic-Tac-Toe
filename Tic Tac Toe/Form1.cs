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
    public partial class frmOyun : Form
    {
        public frmOyun()
        {
            InitializeComponent();
        }
        String siradakiOyuncu = "X";
        String oyuncu1 = "X Oyuncusu";
        String oyuncu2 = "O Oyuncusu";
        bool oyunBittimi;
        byte oyuncu1skor ;
        byte oyuncu2skor ;
        byte hamle;
        byte sure;
        byte salise;


        private void Form1_Load(object sender, EventArgs e)
        {
            oyunBittimi = false;
            oyuncu1skor = 0;
            oyuncu2skor = 0;
            hamle = 0;
            sure = 10;
            salise = 0;
            lbSkor.Text = oyuncu1 + " - " + oyuncu1skor + "     " + oyuncu2skor + " - " + oyuncu2;
            btnDevam.Enabled = false;
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Text = siradakiOyuncu;

            if (siradakiOyuncu == "X")
            {
                if (Kazandimi(siradakiOyuncu))
                {
                    oyuncu1skor++;
                    lbSkor.Text = oyuncu1 + " - " + oyuncu1skor + 
                        "     " + oyuncu2skor + " - " + oyuncu2;
                    btnDevam.Enabled = true;
                }
                sure = 11;
                salise = 10;
                hamle++;
                siradakiOyuncu = "O";
                lbSira.Text = siradakiOyuncu;
                
            }
            else
            {
                if (Kazandimi(siradakiOyuncu))
                {
                    oyuncu2skor++;
                    lbSkor.Text = oyuncu1 + " - " + oyuncu1skor +
                        "     " + oyuncu2skor + " - " + oyuncu2;
                    btnDevam.Enabled = true;
                }
                sure = 11;
                salise =10;
                hamle++;
                siradakiOyuncu = "X";
                lbSira.Text = siradakiOyuncu;
            }

            label.Enabled = false;

            if (hamle == 1)
                timer1.Enabled = true;

            if(hamle==9  && !oyunBittimi)
            {
                MessageBox.Show("Berabere");
                btnDevam.Enabled = true;
                timer1.Enabled = false;
            }
                
        }

        private void lbSira_Click(object sender, EventArgs e)
        {

        }

        private Boolean Kazandimi(String o)
        {
            if( lb1.Text + lb2.Text + lb3.Text == o + o + o ||
                lb4.Text + lb5.Text + lb6.Text == o + o + o ||
                lb7.Text + lb8.Text + lb9.Text == o + o + o ||
                lb1.Text + lb4.Text + lb7.Text == o + o + o ||
                lb2.Text + lb5.Text + lb8.Text == o + o + o ||
                lb3.Text + lb6.Text + lb9.Text == o + o + o ||
                lb1.Text + lb5.Text + lb9.Text == o + o + o ||
                lb3.Text + lb5.Text + lb7.Text == o + o + o )
            {
                lb1.Enabled = false;
                lb2.Enabled = false;
                lb3.Enabled = false;
                lb4.Enabled = false;
                lb5.Enabled = false;
                lb6.Enabled = false;
                lb7.Enabled = false;
                lb8.Enabled = false;
                lb9.Enabled = false;
                timer1.Enabled = false;
                oyunBittimi = true;
                MessageBox.Show(o+" Kazandı");
                return true;
            }
            return false;
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            oyunBittimi = false;
            hamle = 0;
            sure = 10;
            salise = 10;
            lb1.Text = "";
            lb2.Text = "";
            lb3.Text = "";
            lb4.Text = "";
            lb5.Text = "";
            lb6.Text = "";
            lb7.Text = "";
            lb8.Text = "";
            lb9.Text = "";
            lb1.Enabled = true;
            lb2.Enabled = true;
            lb3.Enabled = true;
            lb4.Enabled = true;
            lb5.Enabled = true;
            lb6.Enabled = true;
            lb7.Enabled = true;
            lb8.Enabled = true;
            lb9.Enabled = true;
            btnDevam.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            if (salise > 10)
            {
                if (sure == 0)
                {
                    if (siradakiOyuncu == "X")
                    {
                        siradakiOyuncu = "O";
                        lbSira.Text = siradakiOyuncu;
                    }
                    else
                    {
                        siradakiOyuncu = "X";
                        lbSira.Text = siradakiOyuncu;
                    }
                    sure = 11;
                }
                sure--;
                lbSure.Text = "" + sure;
                salise = 0;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmAnaMenu frmAnaMenu = new frmAnaMenu();
            frmAnaMenu.Show();
            this.Hide();
        }
    }
}
