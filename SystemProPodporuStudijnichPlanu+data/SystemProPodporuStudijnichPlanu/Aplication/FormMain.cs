using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Aplication;

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
        }
        private void NaplnitPredmetyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cesta = @"D:\VEJSKA\SPPSP\dokumentace\pomocné soubory\vspj_predmety_s_anotaci_tilda.txt";
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
            nd.ProvedPopis(cesta);
        }
        private void ToolStripMenuItem2_Click(object sender, EventArgs e) => Viditelnost(1);
        private void ToolStripMenuItem3_Click(object sender, EventArgs e) => Viditelnost(2);
        private void ToolStripMenuItem4_Click(object sender, EventArgs e) => Viditelnost(3);
        private void ToolStripMenuItem5_Click(object sender, EventArgs e) => Viditelnost(4);
        private void ToolStripMenuItem6_Click(object sender, EventArgs e) => Viditelnost(5);
        private void ToolStripMenuItem7_Click(object sender, EventArgs e) => Viditelnost(6);
        private void ToolStripMenuItem8_Click(object sender, EventArgs e) => Viditelnost(7);
        private void ToolStripMenuItem9_Click(object sender, EventArgs e) => Viditelnost(8);
        private void ToolStripMenuItem10_Click(object sender, EventArgs e) => Viditelnost(9);
        private void ToolStripMenuItem11_Click(object sender, EventArgs e) => Viditelnost(10);
        private void ToolStripMenuItem12_Click(object sender, EventArgs e) => Viditelnost(11);
        private void ToolStripMenuItem13_Click(object sender, EventArgs e) => Viditelnost(12);
        private void Viditelnost(int i)
        {
            if (i > 6)
                label_popis.Left = 766;
            else
                label_popis.Left = 451;
            Tma();
            switch (i)
            {
                case 12:
                    {
                        nud_KredSem12.Visible = rb_add12.Visible = rb_del12.Visible = lb_semestr12.Visible = true;
                        goto case 11;
                    }
                case 11:
                    {
                        nud_KredSem11.Visible = rb_add11.Visible = rb_del11.Visible = lb_semestr11.Visible = true;
                        goto case 10;
                    }
                case 10:
                    {
                        nud_KredSem10.Visible = rb_add10.Visible = rb_del10.Visible = lb_semestr10.Visible = true;
                        goto case 9;
                    }
                case 9:
                    {
                        nud_KredSem9.Visible = rb_add9.Visible = rb_del9.Visible = lb_semestr9.Visible = true;
                        goto case 8;
                    }
                case 8:
                    {
                        nud_KredSem8.Visible = rb_add8.Visible = rb_del8.Visible = lb_semestr8.Visible = true;
                        goto case 7;
                    }
                case 7:
                    {
                        nud_KredSem7.Visible = rb_add7.Visible = rb_del7.Visible = lb_semestr7.Visible = true;
                        goto case 6;
                    }
                case 6:
                    {
                        nud_KredSem6.Visible = rb_add6.Visible = rb_del6.Visible = lb_semestr6.Visible = true;
                        goto case 5;
                    }
                case 5:
                    {
                        nud_KredSem5.Visible = rb_add5.Visible = rb_del5.Visible = lb_semestr5.Visible = true;
                        goto case 4;
                    }
                case 4:
                    {
                        nud_KredSem4.Visible = rb_add4.Visible = rb_del4.Visible = lb_semestr4.Visible = true;
                        goto case 3;
                    }
                case 3:
                    {
                        nud_KredSem3.Visible = rb_add3.Visible = rb_del3.Visible = lb_semestr3.Visible = true;
                        goto case 2;
                    }
                case 2:
                    {
                        nud_KredSem2.Visible = rb_add2.Visible = rb_del2.Visible = lb_semestr2.Visible = true;
                        goto case 1;
                    }
                case 1:
                    {
                        nud_KredSem1.Visible = rb_add1.Visible = rb_del1.Visible = lb_semestr1.Visible = true;
                    }
                    break;
                default:
                    break;
            }
        }

        public void Tma()
        {
            nud_KredSem12.Visible = nud_KredSem11.Visible = nud_KredSem10.Visible = nud_KredSem9.Visible = nud_KredSem8.Visible =
                nud_KredSem7.Visible = nud_KredSem6.Visible = nud_KredSem5.Visible = nud_KredSem4.Visible = nud_KredSem3.Visible =
                nud_KredSem2.Visible = nud_KredSem1.Visible = rb_add2.Visible = rb_del2.Visible = rb_add3.Visible = rb_del3.Visible =
                rb_add4.Visible = rb_del4.Visible = rb_add5.Visible = rb_del5.Visible = rb_add6.Visible = rb_del6.Visible =
                rb_add7.Visible = rb_del7.Visible = rb_add8.Visible = rb_del8.Visible = rb_add9.Visible = rb_del9.Visible =
                rb_add10.Visible = rb_del10.Visible = rb_add11.Visible = rb_del11.Visible = rb_add12.Visible = rb_del12.Visible =
                rb_add1.Visible = rb_del1.Visible = lb_semestr12.Visible = lb_semestr11.Visible = lb_semestr10.Visible =
                lb_semestr9.Visible = lb_semestr8.Visible = lb_semestr7.Visible = lb_semestr6.Visible = lb_semestr5.Visible =
                lb_semestr4.Visible = lb_semestr3.Visible = lb_semestr2.Visible = lb_semestr1.Visible = false;
        }
        private void Bt_smaz_Click(object sender, EventArgs e)
        {

        }

        private void SprávaDatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCRUDmidstage x = new FormCRUDmidstage();
            x.Show();
        }
    }
}