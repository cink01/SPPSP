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
            string fileContent = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "";
                openFileDialog.Filter = "txt soubor (*.txt)|*.txt|Všechny soubory (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    cesta = openFileDialog.FileName;
                }
            }
            NacteniDat nd = new NacteniDat();
            nd.Proved(cesta);
            DataAccess da = new DataAccess();
        }
        private void NaplnitPredmetyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NacteniDat nd = new NacteniDat();
            cesta = @"D:\VEJSKA\SPPSP\dokumentace\pomocné soubory\vspj_predmety_s_anotaci.txt";
            string fileContent = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "";
                openFileDialog.Filter = "txt soubor (*.txt)|*.txt|Všechny soubory (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    cesta = openFileDialog.FileName;
                }
            }
            nd.ProvedPopis(cesta);
            DataAccess da = new DataAccess();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            viditelnost(1);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            viditelnost(2);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            viditelnost(3);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            viditelnost(4);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            viditelnost(5);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            viditelnost(6);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            viditelnost(7);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            viditelnost(8);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            viditelnost(9);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            viditelnost(10);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            viditelnost(11);
        }

        private void ToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            viditelnost(12);
        }

        private void viditelnost(int i)
        {
            lb_semestr12.Visible = lb_semestr11.Visible = lb_semestr10.Visible = lb_semestr9.Visible = lb_semestr8.Visible = lb_semestr7.Visible = lb_semestr6.Visible = lb_semestr5.Visible = lb_semestr4.Visible = lb_semestr3.Visible = lb_semestr2.Visible = lb_semestr1.Visible = false;
            switch (i)
            {
                case 12:
                    {
                        lb_semestr12.Visible = true;
                        goto case 11;
                    }
                case 11:
                    {

                        lb_semestr11.Visible = true;
                        goto case 10;
                    }
                case 10:
                    {
                        lb_semestr10.Visible = true;
                        goto case 9;
                    }
                case 9:
                    {
                        lb_semestr9.Visible = true;
                        goto case 8;
                    }
                case 8:
                    {
                        lb_semestr8.Visible = true;
                        goto case 7;
                    }
                case 7:
                    {
                        lb_semestr7.Visible = true;
                        goto case 6;
                    }
                case 6:
                    {
                        lb_semestr6.Visible = true;
                        goto case 5;
                    }
                case 5:
                    {
                        lb_semestr5.Visible = true;
                        goto case 4;
                    }
                case 4:
                    {
                        lb_semestr4.Visible = true;
                        goto case 3;
                    }
                case 3:
                    {
                        lb_semestr3.Visible = true;
                        goto case 2;
                    }
                case 2:
                    {
                        lb_semestr2.Visible = true;
                        goto case 1;
                    }
                case 1:
                    {
                        lb_semestr1.Visible = true;
                    }
                    break;
            }
        }
    }
}