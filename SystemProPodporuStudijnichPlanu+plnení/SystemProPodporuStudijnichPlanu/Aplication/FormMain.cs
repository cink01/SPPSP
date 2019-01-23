using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace SystemProPodporuStudijnichPlanu
{
    public partial class FormMain : Form
    {
        private List<Predmet> predmetyFull = new List<Predmet>();
        /*
         List<Predmet> predmetyS1 = new List<Predmet>();
         List<Predmet> predmetyS2 = new List<Predmet>();
         List<Predmet> predmetyS3 = new List<Predmet>();
         List<Predmet> predmetyS4 = new List<Predmet>();
         List<Predmet> predmetyS5 = new List<Predmet>();
         List<Predmet> predmetyS6 = new List<Predmet>();
         List<Predmet> predmetyS7 = new List<Predmet>();
         List<Predmet> predmetyS8 = new List<Predmet>();
         List<Predmet> predmetyS9 = new List<Predmet>();
         List<Predmet> predmetyS10 = new List<Predmet>();
         */
        public FormMain()
        {
            InitializeComponent();
            Color c = System.Drawing.ColorTranslator.FromHtml("#e8212e");
            menuStripMain.BackColor = c;
            menuStripMain.ForeColor = Color.White;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Obnov();
        }

        private void Obnov()
        {
            lb_semestr1.DataSource = predmetyFull;
            lb_semestr1.DisplayMember = "NazInfo";
            KreditySum();
            lb_semestr2.DataSource = predmetyFull;
            lb_semestr2.DisplayMember = "NazInfo";
            KreditySum();
            lb_semestr3.DataSource = predmetyFull;
            lb_semestr3.DisplayMember = "NazInfo";
            KreditySum();
            lb_semestr4.DataSource = predmetyFull;
            lb_semestr4.DisplayMember = "NazInfo";
            KreditySum();
            lb_semestr5.DataSource = predmetyFull;
            lb_semestr5.DisplayMember = "NazInfo";
            KreditySum();
            lb_semestr6.DataSource = predmetyFull;
            lb_semestr6.DisplayMember = "NazInfo";
            KreditySum();
        }
        private void ObnovFull()
        {
            lb_semestr1.DataSource = predmetyFull;
            lb_semestr1.DisplayMember = "FullInfo";
            KreditySum();

        }
        private void KreditySum()
        {
            decimal sum = 0;
            foreach (Predmet a in predmetyFull)
            {
                sum += a.Kredit_predmet;
            }
            nud_KredSem1.Value = sum;
        }

        private void ZmenaKredituVNUD(object sender, EventArgs e)
        {
            nud_celkemKred.Value = nud_KredSem1.Value + nud_KredSem2.Value + nud_KredSem3.Value + nud_KredSem4.Value + nud_KredSem5.Value + nud_KredSem6.Value;
            if (nud_KredSem1.Value < 15)
            {
                nud_KredSem1.BackColor = Color.LightCoral;
            }
            else
            {
                nud_KredSem1.BackColor = Color.LightGreen;
            }

            if (nud_KredSem2.Value < 15)
            {
                nud_KredSem2.BackColor = Color.LightCoral;
            }
            else
            {
                nud_KredSem2.BackColor = Color.LightGreen;
            }

            if (nud_KredSem3.Value < 15)
            {
                nud_KredSem3.BackColor = Color.LightCoral;
            }
            else
            {
                nud_KredSem3.BackColor = Color.LightGreen;
            }

            if (nud_KredSem4.Value < 15)
            {
                nud_KredSem4.BackColor = Color.LightCoral;
            }
            else
            {
                nud_KredSem4.BackColor = Color.LightGreen;
            }

            if (nud_KredSem5.Value < 15)
            {
                nud_KredSem5.BackColor = Color.LightCoral;
            }
            else
            {
                nud_KredSem5.BackColor = Color.LightGreen;
            }

            if (nud_KredSem6.Value < 15)
            {
                nud_KredSem6.BackColor = Color.LightCoral;
            }
            else
            {
                nud_KredSem6.BackColor = Color.LightGreen;
            }

            if (nud_celkemKred.Value < 180)
            {
                nud_celkemKred.BackColor = Color.LightCoral;
            }
            else
            {
                nud_celkemKred.BackColor = Color.LightGreen;
            }
        }

        private void UkonceniProgramu(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.EXIT_MESSAGE, Properties.Resources.EXIT_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Bt_proved_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int IS = 1;
            predmetyFull = db.GetPredmetFull(IS);
            ObnovFull();
            /* IS = 2;
             predmetyFull = db.GetPredmetFull(IS);
             ObnovFull();
             IS = 3;
             predmetyFull = db.GetPredmetFull(IS);
             ObnovFull();
             IS = 4;
             predmetyFull = db.GetPredmetFull(IS);
             ObnovFull();
             IS = 5;
             predmetyFull = db.GetPredmetFull(IS);
             ObnovFull();
             IS = 6;
             predmetyFull = db.GetPredmetFull(IS);
             ObnovFull();*/
        }

        private string cesta = @"D:\VEJSKA\SPPSP\dokumentace\pomocné soubory\vspj_predmety_bez_anotace.txt";
        private void NaplnitDatabáziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NacteniDat nd = new NacteniDat();
            // string cesta = @"D:\VEJSKA\5 semestr\SPPSP\dokumentace\pomocné soubory\vspj_predmety_bez_anotace.txt";
            nd.Proved(cesta);
            DataAccess da = new DataAccess();
        }
        //string cesta = @"D:\VEJSKA\5 semestr\SPPSP\dokumentace\pomocné soubory\vspj_predmety_bez_anotace.txt";
        private void NaplnitPredmetyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NacteniDat nd = new NacteniDat();
            cesta = @"D:\VEJSKA\SPPSP\dokumentace\pomocné soubory\vspj_predmety_s_anotaci.txt";
            nd.ProvedPopis(cesta);
            DataAccess da = new DataAccess();
        }
        /* 
         private void nud_pocty_ValueChanged(object sender, EventArgs e)
         {
             tabPage1.Visible = tabPage2.Visible = tabPage3.Visible = tabPage4.Visible = tabPage5.Visible = tabPage6.Visible = tabPage7.Visible = tabPage8.Visible = tabPage9.Visible = tabPage10.Visible = tabPage11.Visible = tabPage12.Visible = false;
             switch (Convert.ToInt32(nud_pocty.Value))
             {
                 case 12:
                     {
                         tabPage12.Visible = true;
                         goto case 11;
                     }
                 case 11:
                     {

                         tabPage11.Visible = true;
                         goto case 10;
                     }
                 case 10:
                     {
                         tabPage10.Visible = true;
                         goto case 9;
                     }
                 case 9:
                     {
                         tabPage9.Visible = true;
                         goto case 8;
                     }
                 case 8:
                     {
                         tabPage8.Visible = true;
                         goto case 7;
                     }
                 case 7:
                     {
                         tabPage7.Visible = true;
                         goto case 6;
                     }
                 case 6:
                     {
                         tabPage6.Visible = true;
                         goto case 5;
                     }
                 case 5:
                     {
                         tabPage5.Visible = true;
                         goto case 4;
                     }
                 case 4:
                     {
                         tabPage4.Visible = true;
                         goto case 3;
                     }
                 case 3:
                     {
                         tabPage3.Visible = true;
                         goto case 2;
                     }
                 case 2:
                     {
                         tabPage2.Visible = true;
                         goto case 1;
                     }
                 case 1:
                     {
                         tabPage1.Visible = true;
                     }
                     break;
             }
         }*/
    }
}