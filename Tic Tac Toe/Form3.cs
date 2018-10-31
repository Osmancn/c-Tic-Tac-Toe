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
    public partial class FrmYpy : Form
    {
        public FrmYpy()
        {
            InitializeComponent();
        }

        String siradakiOyuncu = "X";
        String oyuncu1 = "X Oyuncusu";
        String oyuncu2 = "O Oyuncusu";
        bool oyunBittimi;
        byte oyuncu1skor;
        byte oyuncu2skor;
        byte hamle;
        byte sure;
        byte salise;

        private void FrmYpy_Load(object sender, EventArgs e)
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

        

        private Boolean Kazandimi(String o)
        {
            if (lb1.Text + lb2.Text + lb3.Text == o + o + o ||
                lb4.Text + lb5.Text + lb6.Text == o + o + o ||
                lb7.Text + lb8.Text + lb9.Text == o + o + o ||
                lb1.Text + lb4.Text + lb7.Text == o + o + o ||
                lb2.Text + lb5.Text + lb8.Text == o + o + o ||
                lb3.Text + lb6.Text + lb9.Text == o + o + o ||
                lb1.Text + lb5.Text + lb9.Text == o + o + o ||
                lb3.Text + lb5.Text + lb7.Text == o + o + o)
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
                oyunBittimi = true;
                MessageBox.Show(o + " Kazandı");
                return true;
            }
            return false;
        }

        // yapay zeka metotları
       

        Label Kazaniyomu(String o)
        {
            //yatay
            if ((lb1.Text == o) && (lb2.Text == o) && (lb3.Text == ""))
                return lb3;
            if ((lb2.Text == o) && (lb3.Text == o) && (lb1.Text == ""))
                return lb1;
            if ((lb1.Text == o) && (lb3.Text == o) && (lb2.Text == ""))
                return lb2;

            if ((lb4.Text == o) && (lb5.Text == o) && (lb6.Text == ""))
                return lb6;
            if ((lb4.Text == o) && (lb6.Text == o) && (lb5.Text == ""))
                return lb5;
            if ((lb5.Text == o) && (lb6.Text == o) && (lb4.Text == ""))
                return lb4;

            if ((lb7.Text == o) && (lb8.Text == o) && (lb9.Text == ""))
                return lb9;
            if ((lb7.Text == o) && (lb9.Text == o) && (lb8.Text == ""))
                return lb8;
            if ((lb8.Text == o) && (lb9.Text == o) && (lb7.Text == ""))
                return lb7;

            //dikey
            if ((lb1.Text == o) && (lb4.Text == o) && (lb7.Text == ""))
                return lb7;
            if ((lb4.Text == o) && (lb7.Text == o) && (lb1.Text == ""))
                return lb1;
            if ((lb1.Text == o) && (lb7.Text == o) && (lb4.Text == ""))
                return lb4;

            if ((lb2.Text == o) && (lb5.Text == o) && (lb8.Text == ""))
                return lb8;
            if ((lb5.Text == o) && (lb8.Text == o) && (lb2.Text == ""))
                return lb2;
            if ((lb2.Text == o) && (lb8.Text == o) && (lb5.Text == ""))
                return lb5;

            if ((lb3.Text == o) && (lb6.Text == o) && (lb9.Text == ""))
                return lb9;
            if ((lb6.Text == o) && (lb9.Text == o) && (lb3.Text == ""))
                return lb3;
            if ((lb3.Text == o) && (lb9.Text == o) && (lb6.Text == ""))
                return lb6;

            //çapraz
            if ((lb1.Text == o) && (lb5.Text == o) && (lb9.Text == ""))
                return lb9;
            if ((lb5.Text == o) && (lb9.Text == o) && (lb1.Text == ""))
                return lb1;
            if ((lb1.Text == o) && (lb9.Text == o) && (lb5.Text == ""))
                return lb5;

            if ((lb3.Text == o) && (lb5.Text == o) && (lb7.Text == ""))
                return lb7;
            if ((lb5.Text == o) && (lb7.Text == o) && (lb3.Text == ""))
                return lb3;
            if ((lb3.Text == o) && (lb7.Text == o) && (lb5.Text == ""))
                return lb5;


            return null;
        }

        Label KoseDoldu()
        {
            if (lb1.Text == "O")
            {
                if (lb3.Text == "")
                    return lb3;
                if (lb9.Text == "")
                    return lb9;
                if (lb7.Text == "")
                    return lb7;
            }

            if (lb3.Text == "O")
            {
                if (lb1.Text == "")
                    return lb1;
                if (lb9.Text == "")
                    return lb9;
                if (lb7.Text == "")
                    return lb7;
            }

            if (lb9.Text == "O")
            {
                if (lb1.Text == "")
                    return lb1;
                if (lb3.Text == "")
                    return lb3;
                if (lb7.Text == "")
                    return lb7;
            }

            if (lb7.Text == "O")
            {
                if (lb1.Text == "")
                    return lb1;
                if (lb3.Text == "")
                    return lb3;
                if (lb9.Text == "")
                    return lb9;
            }

            if (lb1.Text == "")
                return lb1;
            if (lb3.Text == "")
                return lb3;
            if (lb7.Text == "")
                return lb7;
            if (lb9.Text == "")
                return lb9;
          
            return null;
        }

        Label BosYerDoldur()
        {
            if (lb1.Text == "")
                return lb1;
            if (lb2.Text == "")
                return lb2;
            if (lb3.Text == "")
                return lb3;
            if (lb4.Text == "")
                return lb4;
            if (lb5.Text == "")
                return lb5;
            if (lb6.Text == "")
                return lb6;
            if (lb7.Text == "")
                return lb7;
            if (lb8.Text == "")
                return lb8;
            if (lb9.Text == "")
                return lb9;


            return null;
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Text = siradakiOyuncu;

           
            
            if (Kazandimi(siradakiOyuncu))
            {
                oyuncu1skor++;
                lbSkor.Text = oyuncu1 + " - " + oyuncu1skor +
                     "     " + oyuncu2skor + " - " + oyuncu2;
                btnDevam.Enabled = true;
            }
            hamle++;
            siradakiOyuncu = "O";
            label.Enabled = false;

            if (hamle == 9 && !oyunBittimi)
            {
                MessageBox.Show("Berabere");
                btnDevam.Enabled = true;
            }

            // yapay zeka sırası
            if (!oyunBittimi && hamle<9)
            {
                Label move = null;
                move = Kazaniyomu("O");
                if (move == null)
                {
                    move = Kazaniyomu("X");
                    if (move == null)
                    {
                        move = KoseDoldu();
                        if (move == null)
                        {
                            move = BosYerDoldur();
                        }
                    }
                }

                move.Text = siradakiOyuncu;
                hamle++;
                move.Enabled = false;

                sure = 11;
                salise = 10;

                if (Kazandimi(siradakiOyuncu))
                {
                    oyuncu2skor++;
                    lbSkor.Text = oyuncu1 + " - " + oyuncu1skor +
                         "     " + oyuncu2skor + " - " + oyuncu2;
                    btnDevam.Enabled = true;
                }
            }

            siradakiOyuncu = "X";

            
          
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
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmAnaMenu frmAnaMenu = new frmAnaMenu();
            frmAnaMenu.Show();
            this.Hide();
        }
    }
}
