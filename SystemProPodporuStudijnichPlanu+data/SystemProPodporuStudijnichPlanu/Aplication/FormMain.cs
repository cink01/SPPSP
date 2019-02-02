using System;
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
        public List<Predmet> Sporty = new List<Predmet>();
        public FormMain()
        {
            InitializeComponent();
            RefreshZaznamy();
            menuStripMain.BackColor = ColorTranslator.FromHtml("#e8212e");
            VyplnPotrebnyZeZaznamu();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void KreditySum(List<Predmet> x,int vyber)
        {
            decimal sum = 0;
            foreach (Predmet a in x)
            {
                sum += a.Kredit_predmet;
            }
            VyberNudVal(sum, vyber);
        }
        private void ZmenaKredituVNUD(object sender, EventArgs e)
        {
            nud_celkemKred.Value = nud_KredSem1.Value + nud_KredSem2.Value + nud_KredSem3.Value + nud_KredSem4.Value + nud_KredSem5.Value + nud_KredSem6.Value + nud_KredSem7.Value + nud_KredSem8.Value + nud_KredSem9.Value + nud_KredSem10.Value + nud_KredSem11.Value + nud_KredSem12.Value;
            nud_KredSem1.BackColor = nud_KredSem1.Value < 15 ? Color.LightCoral : Color.LightGreen;
            nud_KredSem2.BackColor = nud_KredSem2.Value < 15 ? Color.LightCoral : Color.LightGreen;
            nud_KredSem3.BackColor = nud_KredSem3.Value < 15 ? Color.LightCoral : Color.LightGreen;
            nud_KredSem4.BackColor = nud_KredSem4.Value < 15 ? Color.LightCoral : Color.LightGreen;
            nud_KredSem5.BackColor = nud_KredSem5.Value < 15 ? Color.LightCoral : Color.LightGreen;
            nud_KredSem6.BackColor = nud_KredSem6.Value < 15 ? Color.LightCoral : Color.LightGreen;
            nud_celkemKred.BackColor = nud_celkemKred.Value < 180 ? Color.LightCoral : Color.LightGreen;
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
            DataCrud data = new DataCrud();
            VratZaznamData(out int id_z, out string zkr, out int id_o, out string roko, out int pocesem);
            int vyber = (int)nud_PridatDoSem.Value;
            FormPridavani FP = new FormPridavani();
            if (vyber == 1 || vyber == 3 || vyber == 5 || vyber == 7 || vyber == 9 || vyber == 11)
                FP.PredmetySeznam = predmetyLichy;
            else
                FP.PredmetySeznam = predmetySudy;
            FP.RefreshSeznam();
            DialogResult potvrzeni = FP.ShowDialog();
            if (potvrzeni == DialogResult.OK)
            {
                List<Predmet> x = FP.PredmetyAdd;
                foreach (Predmet p in x)
                {
                    data.InsertVyber(p.Id_predmet, vyber, id_z);
                }
                RefreshList(VratListBox(vyber), x,vyber);
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
                    cesta = openFileDialog.FileName;
                }
            }
            NacteniDat nd = new NacteniDat();
            nd.ProvedPopis(cesta);
        }
        private void Viditelnost(int i)
        {
            gb_popis.Left = i > 6 ? 715 : 428;
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
            VyplnPotrebnyZeZaznamu();
            if (cmb_zaznam.SelectedIndex >= 0)
                FillHlavniListy();

        }
        private void VyplnPotrebnyZeZaznamu()
        {
            DataAccess db = new DataAccess();
            if (cmb_zaznam.SelectedItem is DataRowView DZ)
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
        }
        private void DeselectnutiListu(int i)
        {
            bt_smaz.Visible = true;
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
            try
            {
                label_popis.Text = lb_semestr1.SelectedItem.ToString();
        }
            catch { }
        }
        private void Lb_semestr2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(2);
            try
            {
                label_popis.Text = lb_semestr2.SelectedItem.ToString();
            }
            catch { }
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
        private ListBox VratListBox(int i)
        {
            switch (i)
            {
                case 12:
                    {
                        return lb_semestr12;
                    }
                case 11:
                    {
                        return lb_semestr11;
                    }
                case 10:
                    {
                        return lb_semestr10;
                    }
                case 9:
                    {
                        return lb_semestr9;
                    }
                case 8:
                    {
                        return lb_semestr8;
                    }
                case 7:
                    {
                        return lb_semestr7;
                    }
                case 6:
                    {
                        return lb_semestr6;
                    }
                case 5:
                    {
                        return lb_semestr5;

                    }
                case 4:
                    {
                        return lb_semestr4;

                    }
                case 3:
                    {
                        return lb_semestr3;

                    }
                case 2:
                    {
                        return lb_semestr2;
                    }
                case 1:
                    {
                        return lb_semestr1;
                    }
            }
            return null;
        }
        private void VyberNudVal(decimal sum, int vyber)
        {
            switch (vyber)
            {
                case 12:
                    {
                        nud_KredSem12.Value = sum; break;
                    }
                case 11:
                    {
                        nud_KredSem11.Value = sum; break;
                    }
                case 10:
                    {
                        nud_KredSem10.Value = sum; break;
                    }
                case 9:
                    {
                        nud_KredSem9.Value = sum; break;
                    }
                case 8:
                    {
                        nud_KredSem8.Value = sum; break;
                    }
                case 7:
                    {
                        nud_KredSem7.Value = sum; break;
                    }
                case 6:
                    {
                        nud_KredSem6.Value = sum; break;
                    }
                case 5:
                    {
                        nud_KredSem5.Value = sum; break;
                    }
                case 4:
                    {
                        nud_KredSem4.Value = sum; break;
                    }
                case 3:
                    {
                        nud_KredSem3.Value = sum; break;
                    }
                case 2:
                    {
                        nud_KredSem2.Value = sum; break;
                    }
                case 1:
                    {
                        nud_KredSem1.Value = sum; break;
                    }
            }
        }
        private void RefreshList(ListBox x, List<Predmet> i,int vyber)
        {
            x.DataSource = null;
            x.Items.Clear();
            KreditySum(i,vyber);
            foreach (Predmet n in i)
            {
                x.Items.Add(n.FullInfo);
            }
        }
        private void VratZaznamData(out int id_z, out string zkr, out int id_o, out string rok_o, out int PocSem)
        {
            DataRowView DZ = cmb_zaznam.SelectedItem as DataRowView;
            zkr = DZ.Row["zkr_zaznam"].ToString();
            id_z = Convert.ToInt32(DZ.Row["id_zaznam"].ToString());
            DataAccess db = new DataAccess();
            db.GetZaznamFull(id_z, out id_o, out PocSem);
            rok_o = db.GetOborRok(id_o);
        }
        private void FillHlavniListy()
        {
            ClearListy();
            VratZaznamData(out int id_zaznam, out string zaznam, out int obor, out string roko, out int semestry);
            tb_obor.Text = obor.ToString();
            tb_semest.Text = semestry.ToString();
            Viditelnost(semestry);
            nud_PridatDoSem.Maximum = semestry;
            DataAccess db = new DataAccess();
            predmetyLichy = db.GetPredmetFullLichy(obor);
            predmetySudy = db.GetPredmetFullSudy(obor);
            Sporty = db.GetPredmetBySemestr(0,obor);
            predmetyLichy.AddRange(Sporty);
            predmetySudy.AddRange(Sporty);
             for(int i =1;i<=semestry; i++)
                 NaplnitIndividualy(zaznam, obor,i);
        }
        private void NaplnitIndividualy(string zaznam, int obor, int semestry = 0)
        {
            DataAccess db = new DataAccess();
            try
            {
                var test = new List<Predmet>();
                if (1 <= semestry)
                {
                    RefreshList(VratListBox(semestry), test = db.GetPredmetZVyberu(1, zaznam, obor), semestry);
                }
                if (2 <= semestry)
                {
                    RefreshList(VratListBox(semestry), test = db.GetPredmetZVyberu(2, zaznam, obor), semestry);
                }
                if (3 <= semestry)
                {
                    RefreshList(VratListBox(semestry), test = db.GetPredmetZVyberu(3, zaznam, obor), semestry);
                }
                if (4 <= semestry)
                {
                    RefreshList(VratListBox(semestry), test = db.GetPredmetZVyberu(4, zaznam, obor), semestry);
                }
                if (5 <= semestry)
                {
                    RefreshList(VratListBox(semestry), test = db.GetPredmetZVyberu(5, zaznam, obor), semestry);
                }
                if (6 <= semestry)
                {
                    RefreshList(VratListBox(semestry), test = db.GetPredmetZVyberu(6, zaznam, obor), semestry);
                }
                if (7 <= semestry)
                {
                    RefreshList(VratListBox(semestry), test = db.GetPredmetZVyberu(7, zaznam, obor), semestry);
                }
                if (8 <= semestry)
                {
                    RefreshList(VratListBox(semestry), test = db.GetPredmetZVyberu(8, zaznam, obor), semestry);
                }
                if (9 <= semestry)
                {
                    RefreshList(VratListBox(semestry), test = db.GetPredmetZVyberu(9, zaznam, obor), semestry);
                }
                if (10 <= semestry)
                {
                    RefreshList(VratListBox(semestry), test = db.GetPredmetZVyberu(10, zaznam, obor), semestry);
                }
                if (11 <= semestry)
                {
                    RefreshList(VratListBox(semestry), test = db.GetPredmetZVyberu(11, zaznam, obor), semestry);
                }
                if (12 <= semestry)
                {
                    RefreshList(VratListBox(semestry), test = db.GetPredmetZVyberu(12, zaznam, obor), semestry);
                }
            }
            catch { }
        }
        private void ClearListy()
        {
            Sporty.Clear();
            predmetySudy.Clear();
            predmetyLichy.Clear();
            
        }
        private void Cmb_obor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillHlavniListy();
        }
        private void VytvořitNovýZáznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCUZaznam Zaznam = new FormCUZaznam())
            {
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
                            x.InsertPS(Zaznam.Zkr, i);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nelze uložit " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Vložení proběhlo úspěšně", "Vloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            RefreshZaznamy();
        }
        private void UpravitZáznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VratZaznamData(out int id_z, out string zkr, out int id_o, out string rok_o, out int PocSem);
            using (FormCUZaznam Zaznam = new FormCUZaznam())
            {
                Zaznam.Text = "Upravit záznam";
                Zaznam.Id = id_z.ToString();
                Zaznam.Zkr = zkr;
                Zaznam.Obor = rok_o;
                Zaznam.Semestr = PocSem;
                string rok_oborOld = rok_o;
                DataAccess a = new DataAccess();
                DialogResult potvrzeni = Zaznam.ShowDialog();
                if (potvrzeni == DialogResult.OK)
                {
                    DataCrud x = new DataCrud();
                    string rok_oborNew = Zaznam.Obor;
                    try
                    {
                        id_z = Convert.ToInt32(Zaznam.Id);
                        if (rok_oborNew == rok_oborOld)
                        {
                            PocSem = Zaznam.Semestr;
                            int stare = a.GetZaznamSemestr(id_z);
                            x.UpdateZaznam(id_z,
                                           Zaznam.Zkr,
                                           PocSem);
                            if (stare > PocSem)
                                while (stare > PocSem)
                                {
                                    x.DeletePlanSemestr(id_z, stare);
                                    stare--;
                                }
                            if (stare < PocSem)
                                while (stare < PocSem)
                                {
                                    x.InsertPS(Zaznam.Zkr, stare);
                                    stare++;
                                }
                        }
                        else
                        {
                            try
                            {
                                x.DeleteZaznam(id_z);
                                x.InsertZaznam(Zaznam.Zkr,
                                               Zaznam.Obor,
                                               Zaznam.Semestr);
                                for (int i = 1; i <= Zaznam.Semestr; i++)
                                    x.InsertPS(Zaznam.Zkr, i);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Nelze uložit " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            MessageBox.Show("Vložení proběhlo úspěšně", "Vloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nelze uložit " + ex, "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Vložení proběhlo úspěšně", "Vloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            RefreshZaznamy();
        }
        private void PovolitSprávceToolStripMenuItem_Click(object sender, EventArgs e) => správaToolStripMenuItem.Visible = správaToolStripMenuItem.Visible != true;
    }
}