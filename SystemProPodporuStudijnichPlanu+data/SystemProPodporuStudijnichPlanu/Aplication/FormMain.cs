﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Aplication;

namespace SystemProPodporuStudijnichPlanu
{
    public partial class FormMain : Form
    {
        public List<Predmet> predmetyLichy = new List<Predmet>();
        public List<Predmet> predmetySudy = new List<Predmet>();
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
        List<Predmet> predmetyS11 = new List<Predmet>();
        List<Predmet> predmetyS12 = new List<Predmet>();
        public FormMain()
        {
            InitializeComponent();
            DataAccess dataaccess = new DataAccess();
            RefreshZaznamy();
            //dataaccess.FillOborCB(cmb_obor);
            menuStripMain.BackColor = ColorTranslator.FromHtml("#e8212e");
            VyplnPotrebnyZeZaznamu();
          //  FillHlavniListy();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Obnov();
        }

        private void Obnov()
        {
            KreditySum();
        }
        private void ObnovFull()
        {
            lb_semestr1.DisplayMember = "FullInfo";
            KreditySum();

        }
        private void KreditySum()
        {
            decimal sum = 0;
            foreach (Predmet a in predmetyS1)
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
            int vyber = (int)nud_PridatDoSem.Value;
            FormPridavani FP = new FormPridavani();
            if (vyber == 1 || vyber == 3 || vyber == 5 || vyber == 7 || vyber == 9 || vyber == 11)
                FP.PredmetySeznam = predmetyLichy;
            else
                FP.PredmetySeznam = predmetySudy;
            FP.RefreshSeznam();
            FP.PredmetyAdd = VyberListu(vyber);
            DialogResult potvrzeni = FP.ShowDialog();
            if (potvrzeni == DialogResult.OK)
            {
                NaplnVybranyList(vyber, FP.PredmetyAdd);


            }
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
                        nud_KredSem12.Visible = lb_semestr12.Visible = true;
                        goto case 11;
                    }
                case 11:
                    {
                        nud_KredSem11.Visible = lb_semestr11.Visible = true;
                        goto case 10;
                    }
                case 10:
                    {
                        nud_KredSem10.Visible = lb_semestr10.Visible = true;
                        goto case 9;
                    }
                case 9:
                    {
                        nud_KredSem9.Visible = lb_semestr9.Visible = true;
                        goto case 8;
                    }
                case 8:
                    {
                        nud_KredSem8.Visible = lb_semestr8.Visible = true;
                        goto case 7;
                    }
                case 7:
                    {
                        nud_KredSem7.Visible = lb_semestr7.Visible = true;
                        goto case 6;
                    }
                case 6:
                    {
                        nud_KredSem6.Visible = lb_semestr6.Visible = true;
                        goto case 5;
                    }
                case 5:
                    {
                        nud_KredSem5.Visible = lb_semestr5.Visible = true;
                        goto case 4;
                    }
                case 4:
                    {
                        nud_KredSem4.Visible = lb_semestr4.Visible = true;
                        goto case 3;
                    }
                case 3:
                    {
                        nud_KredSem3.Visible = lb_semestr3.Visible = true;
                        goto case 2;
                    }
                case 2:
                    {
                        nud_KredSem2.Visible = lb_semestr2.Visible = true;
                        goto case 1;
                    }
                case 1:
                    {
                        nud_KredSem1.Visible = lb_semestr1.Visible = true;
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
                nud_KredSem2.Visible = nud_KredSem1.Visible = lb_semestr12.Visible = lb_semestr11.Visible = lb_semestr10.Visible =
                lb_semestr9.Visible = lb_semestr8.Visible = lb_semestr7.Visible = lb_semestr6.Visible = lb_semestr5.Visible =
                lb_semestr4.Visible = lb_semestr3.Visible = lb_semestr2.Visible = lb_semestr1.Visible = false;
        }
        private void Bt_smaz_Click(object sender, EventArgs e)
        {
            if (lb_semestr1.SelectedIndex != -1)
            {
                try
                {
                    lb_semestr1.Items.Remove(lb_semestr1.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Není vybrán žádný předmět s daného semestru!");
                }
            }
            if (lb_semestr2.SelectedIndex != -1)
            {
                try
                {
                    lb_semestr2.Items.Remove(lb_semestr2.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Není vybrán žádný předmět s daného semestru!");
                }
            }
            if (lb_semestr3.SelectedIndex != -1)
            {
                try
                {
                    lb_semestr3.Items.Remove(lb_semestr3.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Není vybrán žádný předmět s daného semestru!");
                }
            }
            if (lb_semestr4.SelectedIndex != -1)
            {
                try
                {
                    lb_semestr5.Items.Remove(lb_semestr4.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Není vybrán žádný předmět s daného semestru!");
                }
            }
            if (lb_semestr5.SelectedIndex != -1)
            {
                try
                {
                    lb_semestr5.Items.Remove(lb_semestr5.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Není vybrán žádný předmět s daného semestru!");
                }
            }
            if (lb_semestr6.SelectedIndex != -1)
            {
                try
                {
                    lb_semestr6.Items.Remove(lb_semestr6.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Není vybrán žádný předmět s daného semestru!");
                }
            }
            if (lb_semestr7.SelectedIndex != -1)
            {
                try
                {
                    lb_semestr7.Items.Remove(lb_semestr7.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Není vybrán žádný předmět s daného semestru!");
                }
            }
            if (lb_semestr8.SelectedIndex != -1)
            {
                try
                {
                    lb_semestr9.Items.Remove(lb_semestr8.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Není vybrán žádný předmět s daného semestru!");
                }
            }
            if (lb_semestr9.SelectedIndex != -1)
            {
                try
                {
                    lb_semestr9.Items.Remove(lb_semestr9.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Není vybrán žádný předmět s daného semestru!");
                }
            }
            if (lb_semestr10.SelectedIndex != -1)
            {
                try
                {
                    lb_semestr10.Items.Remove(lb_semestr10.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Není vybrán žádný předmět s daného semestru!");
                }
            }
            if (lb_semestr11.SelectedIndex != -1)
            {
                try
                {
                    lb_semestr11.Items.Remove(lb_semestr11.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Není vybrán žádný předmět s daného semestru!");
                }
            }
            if (lb_semestr12.SelectedIndex != -1)
            {
                try
                {
                    lb_semestr12.Items.Remove(lb_semestr12.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Není vybrán žádný předmět s daného semestru!");
                }
            }
        }
        private void SprávaDatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCRUDmidstage x = new FormCRUDmidstage();
            x.Show();
        }
        private void Cmb_zaznam_SelectedIndexChanged(object sender, EventArgs e)
        {
            // RefreshZaznamy();

            //  FillHlavniListy();
            VyplnPotrebnyZeZaznamu();
            if(cmb_zaznam.SelectedIndex>=0)
                FillHlavniListy();

        }
        private void VyplnPotrebnyZeZaznamu()
        {
            DataAccess db = new DataAccess();
            DataRowView DZ = cmb_zaznam.SelectedItem as DataRowView;
            if (DZ != null)
            {
                int id_zaznam = Convert.ToInt32(DZ.Row["id_zaznam"].ToString());
                db.GetZaznamFull(id_zaznam, out int obor, out int semestry);
                tb_obor.Text = obor.ToString();
                tb_semest.Text = semestry.ToString();
                Viditelnost(semestry);
                nud_PridatDoSem.Maximum = semestry;
            }
        }
        private void RefreshZaznamy()
        {
            cmb_zaznam.DataSource = null;
            DataAccess db = new DataAccess();
            db.FillZaznamCB(cmb_zaznam);
            DataRowView DZ = cmb_zaznam.SelectedItem as DataRowView;
//            string zaznam = DZ.Row["zkr_zaznam"].ToString();

        }
        private void DeselectnutiListu(int i)
        {
            switch (i)
            {
                case 12:
                    {
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        break;
                    }
                case 11:
                    {
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr12.SelectedIndex = -1;
                        break;
                    }
                case 10:
                    {
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        break;
                    }
                case 9:
                    {
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        break;
                    }
                case 8:
                    {
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        break;
                    }
                case 7:
                    {
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        break;
                    }
                case 6:
                    {
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        break;
                    }
                case 5:
                    {
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        break;
                    }
                case 4:
                    {
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        break;
                    }
                case 3:
                    {
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        break;
                    }
                case 2:
                    {
                        lb_semestr1.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        break;
                    }
                case 1:
                    {
                        lb_semestr12.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        break;
                    }
                default:
                    break;
            }
        }

        private void Lb_semestr1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(1);
            label_popis.Text = lb_semestr1.SelectedItem.ToString();
        }
        private void Lb_semestr2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(2);
            label_popis.Text = lb_semestr2.SelectedItem.ToString();
        }

        private void Lb_semestr3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_popis.Text = lb_semestr3.SelectedItem.ToString();
            DeselectnutiListu(3);
        }

        private void Lb_semestr4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(4);
        }

        private void Lb_semestr5_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(5);
        }

        private void Lb_semestr6_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(6);
        }

        private void Lb_semestr7_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(7);
        }

        private void Lb_semestr8_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(8);

        }

        private void Lb_semestr9_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(9);
        }

        private void Lb_semestr10_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(10);
        }

        private void Lb_semestr11_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(11);
        }

        private void Lb_semestr12_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(12);
        }

        private List<Predmet> VyberListu(int i)
        {
            switch (i)
            {
                case 12:
                    {
                        return predmetyS12;
                    }
                case 11:
                    {
                        return predmetyS11;
                    }
                case 10:
                    {
                        return predmetyS10;
                    }
                case 9:
                    {
                        return predmetyS9;
                    }
                case 8:
                    {
                        return predmetyS8;
                    }
                case 7:
                    {
                        return predmetyS7;
                    }
                case 6:
                    {
                        return predmetyS6;
                    }
                case 5:
                    {
                        return predmetyS5;

                    }
                case 4:
                    {
                        return predmetyS4;

                    }
                case 3:
                    {
                        return predmetyS3;

                    }
                case 2:
                    {
                        return predmetyS2;
                    }
                case 1:
                    {
                        return predmetyS1;
                    }
            }
            return null;

        }
        private void NaplnVybranyList(int i, List<Predmet> p)
        {
            switch (i)
            {
                case 12:
                    {
                        predmetyS12 = p; break;
                    }
                case 11:
                    {
                        predmetyS11 = p; break;
                    }
                case 10:
                    {
                        predmetyS10 = p; break;
                    }
                case 9:
                    {
                        predmetyS9 = p; break;
                    }
                case 8:
                    {
                        predmetyS8 = p; break;
                    }
                case 7:
                    {
                        predmetyS7 = p; break;
                    }
                case 6:
                    {
                        predmetyS6 = p; break;
                    }
                case 5:
                    {
                        predmetyS5 = p; break;

                    }
                case 4:
                    {
                        predmetyS4 = p; break;

                    }
                case 3:
                    {
                        predmetyS3 = p; break;

                    }
                case 2:
                    {
                        predmetyS2 = p; break;
                    }
                case 1:
                    {
                        predmetyS1 = p; break;
                    }
                default: break;
            }
        }

        private void FillHlavniListy()
        {
            ClearListy();
            DataAccess db = new DataAccess();
            DataRowView DZ = cmb_zaznam.SelectedItem as DataRowView;
            string zaznam = DZ.Row["zkr_zaznam"].ToString();
            int id_zaznam = Convert.ToInt32(DZ.Row["id_zaznam"].ToString());
            int semestry;
            db.GetZaznamFull(id_zaznam,out int obor,out semestry);
            tb_obor.Text = obor.ToString();
            tb_semest.Text = semestry.ToString();
            Viditelnost(semestry);
            nud_PridatDoSem.Maximum = semestry;
/*
if (1 <= semestry)
{
    predmetyS1 = db.GetPredmetZVyberu(1, zaznam, obor);
}

if (2 <= semestry)
{
    predmetyS2 = db.GetPredmetZVyberu(2, zaznam, obor);
}

if (3 <= semestry)
{
    predmetyS3 = db.GetPredmetZVyberu(3, zaznam, obor);
}

if (4 <= semestry)
{
    predmetyS4 = db.GetPredmetZVyberu(4, zaznam, obor);
}

if (5 <= semestry)
{
    predmetyS5 = db.GetPredmetZVyberu(5, zaznam, obor);
}

if (6 <= semestry)
{
    predmetyS6 = db.GetPredmetZVyberu(6, zaznam, obor);
}

if (7 <= semestry)
{
    predmetyS7 = db.GetPredmetZVyberu(7, zaznam, obor);
}

if (8 <= semestry)
{
    predmetyS8 = db.GetPredmetZVyberu(8, zaznam, obor);
}

if (9 <= semestry)
{
    predmetyS9 = db.GetPredmetZVyberu(9, zaznam, obor);
}

if (10 <= semestry)
{
    predmetyS10 = db.GetPredmetZVyberu(10, zaznam, obor);
}

if (11 <= semestry)
{
    predmetyS11 = db.GetPredmetZVyberu(11, zaznam, obor);
}

if (12 <= semestry)
{
    predmetyS12 = db.GetPredmetZVyberu(12, zaznam, obor);
}
*/
predmetyLichy = db.GetPredmetFullLichy(obor);
            predmetySudy = db.GetPredmetFullSudy(obor);
        }
        private void ClearListy()
        {
            predmetyS1.Clear();
            predmetyS2.Clear();
            predmetyS3.Clear();
            predmetyS4.Clear();
            predmetyS5.Clear();
            predmetyS6.Clear();
            predmetyS7.Clear();
            predmetyS8.Clear();
            predmetyS9.Clear();
            predmetyS10.Clear();
            predmetyS11.Clear();
            predmetyS12.Clear();
            predmetySudy.Clear();
            predmetyLichy.Clear();
        }
        private void Cmb_obor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillHlavniListy();
        }

        private void VytvořitNovýZáznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCUZaznam Zaznam = new FormCUZaznam();
            DataAccess da = new DataAccess();
            Zaznam.Text = "Vytvořit nový záznam";
            DialogResult potvrzeni = Zaznam.ShowDialog();
            if (potvrzeni == DialogResult.OK)
            {
                DataCrud x = new DataCrud();
                try
                {
                    x.InsertZaznam(Zaznam.Zkr,
                                   Zaznam.Obor,
                                   Zaznam.Semestr);
                    for (int i = 1; i <= Zaznam.Semestr; i++)
                        x.InsertPS(Zaznam.Zkr,Zaznam.Semestr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nelze uložit " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Vložení proběhlo úspěšně", "Vloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RefreshZaznamy();
        }

        private void UpravitZáznamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}