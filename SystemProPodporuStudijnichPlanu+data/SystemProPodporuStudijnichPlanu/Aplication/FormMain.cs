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
            urceniZvolenehoListu = 0;
            if (cmb_zaznam.Items.Count <= 1)
            {
                var text = "Není založen žádný plán. Chcete vytvořit nový?";
                var titul = "Prázný záznam";
                var res = MessageBox.Show(text, titul, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                    VytvorZaznam();
            }
        }
        private void RefreshList(ListBox x, int vyber)
        {
            VratZaznamData(out int izaz, out _, out _, out _, out _);
            DataAccess da = new DataAccess();
            urceniZvolenehoListu = 0;
            da.FillSemestrLB(x, izaz, vyber, out decimal sum, out List<Predmet> p);
            NaplnVybranyList(vyber, p);
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
            //temp.Clear();
            VratZaznamData(out int id_z, out _, out _, out _, out _);
            int vyber = (int)nud_PridatDoSem.Value;
            FormPridavani FP = new FormPridavani();
            int count;
            if (vyber == 1 || vyber == 3 || vyber == 5 || vyber == 7 || vyber == 9 || vyber == 11)
            {
                count = 1;
                FP.PredmetySeznam = predmetyLichy;
            }
            else
            {
                count = 2;
                FP.PredmetySeznam = predmetySudy;
            }
            FP.RefreshSeznam();
            DialogResult potvrzeni = FP.ShowDialog();
            if (potvrzeni == DialogResult.OK)
            {
                if (count == 1)
                    predmetyLichy = FP.PredmetySeznam;
                if (count == 2)
                    predmetySudy = FP.PredmetySeznam;
                foreach (Predmet p in FP.PredmetyAdd)
                {
                    data.InsertVyber(p.Id_predmet, vyber, id_z);
                }
                RefreshList(VratListBox(vyber), vyber);
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
        private void RefreshZaznamy(string zkratka="")
        {
            cmb_zaznam.DataSource = null;
            DataAccess db = new DataAccess();
            db.FillZaznamCB(cmb_zaznam);
            cmb_zaznam.SelectedIndex = cmb_zaznam.FindStringExact(zkratka);

        }
        private void FillPopisyDoFormu(string popis, decimal kredity, string povin)
        {
            try
            {
                nud_kredpop.Value = kredity;
                richTextBox1.Text = popis;
                textBox1.Text = povin;
            }
            catch { }
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
            VratZaznamData(out int idz, out string _, out int obor, out string _, out int semestry);
            tb_obor.Text = obor.ToString();
            tb_semest.Text = semestry.ToString();
            Viditelnost(semestry);
            nud_PridatDoSem.Maximum = semestry;
            DataAccess db = new DataAccess();
            predmetyLichy = db.GetPredmetFullLichyVyber(obor, idz);
            predmetySudy = db.GetPredmetFullSudyVyber(obor, idz);
            Sporty = db.GetPredmetBySemestr(0, obor);
            predmetyLichy.AddRange(Sporty);
            predmetySudy.AddRange(Sporty);
            for (int i = 1; i <= semestry; i++)
                NaplnitIndividualy(i);
        }
        private void Lb_semestr1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(1);
        }
        private void Lb_semestr2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectnutiListu(2);
        }
        private void Lb_semestr3_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        private void NaplnitIndividualy(int semestry = 0)
        {
            try
            {
                var test = new List<Predmet>();
                if (1 <= semestry)
                {
                    RefreshList(VratListBox(semestry), semestry);
                }
                if (2 <= semestry)
                {
                    RefreshList(VratListBox(semestry), semestry);
                }
                if (3 <= semestry)
                {
                    RefreshList(VratListBox(semestry), semestry);
                }
                if (4 <= semestry)
                {
                    RefreshList(VratListBox(semestry), semestry);
                }
                if (5 <= semestry)
                {
                    RefreshList(VratListBox(semestry), semestry);
                }
                if (6 <= semestry)
                {
                    RefreshList(VratListBox(semestry), semestry);
                }
                if (7 <= semestry)
                {
                    RefreshList(VratListBox(semestry), semestry);
                }
                if (8 <= semestry)
                {
                    RefreshList(VratListBox(semestry), semestry);
                }
                if (9 <= semestry)
                {
                    RefreshList(VratListBox(semestry), semestry);
                }
                if (10 <= semestry)
                {
                    RefreshList(VratListBox(semestry), semestry);
                }
                if (11 <= semestry)
                {
                    RefreshList(VratListBox(semestry), semestry);
                }
                if (12 <= semestry)
                {
                    RefreshList(VratListBox(semestry), semestry);
                }
            }
            catch { }
        }
        private void Bt_smaz_Click(object sender, EventArgs e)
        {
            DataRowView DZ = cmb_zaznam.SelectedItem as DataRowView;
            int id_z = Convert.ToInt32(DZ.Row["id_zaznam"].ToString());
            decimal sum = VratNudVal(urceniZvolenehoListu) - nud_kredpop.Value;
            DataAccess da = new DataAccess();
            MazatZVyberu(VratListBox(urceniZvolenehoListu), VyberListu(urceniZvolenehoListu), id_z, urceniZvolenehoListu);
            VyberNudVal(sum, urceniZvolenehoListu);
        }
        public void MazatZVyberu(ListBox LB, List<Predmet> p, int id_z, int sem) //přesunuto z DataAccess do main vyresit zapis a nebo reset lichy a sudy aby se to dalo presunout pryc
        {
            DataAccess da = new DataAccess();
            int x = 0;
            foreach (Predmet n in p)
            { 
                if ((object)LB.SelectedItem == (object)(n.Name_predmet))
                {
                    x = n.Id_predmet;
                    if (sem == 0 || sem == 2 || sem == 4 || sem == 6 || sem == 8 || sem == 10 || sem == 12)
                        predmetySudy.Add(n);
                    else
                        predmetyLichy.Add(n);
                }
            }
            int id = da.GetVyberId(id_z, x, sem);
            LB.Items.Remove(LB.SelectedItem);
            DataCrud dc = new DataCrud();
            dc.DeleteVyber(id);
        }
        private void ClearListy()
        {
            Sporty.Clear();
            predmetySudy.Clear();
            predmetyLichy.Clear();
            for (int i = 1; i <= 12; i++)
                ClearLB(i);
        }
        public void ClearLB(int i)
        {
            ListBox x = VratListBox(i);
            VyberNudVal(0, i);
            try
            {
                x.DataSource = null;
                x.Items.Clear();
            }
            catch { }
        }
        private void Cmb_obor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillHlavniListy();
        }
        private void VytvořitNovýZáznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VytvorZaznam();
        }
        private void VytvorZaznam()
        {
            string zkratka = "";
            using (FormCUZaznam Zaznam = new FormCUZaznam())
            {
                Zaznam.Text = "Vytvořit nový záznam";
                Zaznam.Schov = true;
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
                    zkratka = Zaznam.Zkr;
                    MessageBox.Show("Vložení proběhlo úspěšně", "Vloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            RefreshZaznamy(zkratka);
        }
        private void UpravitZáznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmb_zaznam.SelectedIndex != -1)
            {
                VratZaznamData(out int id_z, out string zkr, out _, out string rok_o, out int PocSem);
                using (FormCUZaznam Zaznam = new FormCUZaznam())
                {
                    Zaznam.Text = "Upravit záznam";
                    Zaznam.Schov = false;
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
        }
        private void PovolitSprávceToolStripMenuItem_Click(object sender, EventArgs e) => správaToolStripMenuItem.Visible = správaToolStripMenuItem.Visible != true;
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

        private int urceniZvolenehoListu;
        private void DeselectnutiListu(int i)
        {
            bt_smaz.Visible = true;
            switch (i)
            {
                case 55:
                    {
                        DataAccess da = new DataAccess();
                        da.GetDetail(VratListBox(urceniZvolenehoListu), VyberListu(urceniZvolenehoListu), out string popis, out decimal kredity, out string povin);
                        FillPopisyDoFormu(popis, kredity, povin);
                        break;
                    }
                case 12:
                    {
                        urceniZvolenehoListu = 12;
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        goto case 55;
                    }
                case 11:
                    {
                        urceniZvolenehoListu = 11;
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr12.SelectedIndex = -1;
                        goto case 55;
                    }
                case 10:
                    {
                        urceniZvolenehoListu = 10;
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        goto case 55;
                    }
                case 9:
                    {
                        urceniZvolenehoListu = 9;
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        goto case 55;
                    }
                case 8:
                    {
                        urceniZvolenehoListu = 8;
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        goto case 55;
                    }
                case 7:
                    {
                        urceniZvolenehoListu = 7;
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        goto case 55;
                    }
                case 6:
                    {
                        urceniZvolenehoListu = 6;
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        goto case 55;
                    }
                case 5:
                    {
                        urceniZvolenehoListu = 5;
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        goto case 55;
                    }
                case 4:
                    {
                        urceniZvolenehoListu = 4;
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        goto case 55;
                    }
                case 3:
                    {
                        urceniZvolenehoListu = 3;
                        lb_semestr1.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        goto case 55;
                    }
                case 2:
                    {
                        urceniZvolenehoListu = 2;
                        lb_semestr1.SelectedIndex = lb_semestr12.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        goto case 55;
                    }
                case 1:
                    {
                        urceniZvolenehoListu = 1;
                        lb_semestr12.SelectedIndex = lb_semestr2.SelectedIndex = lb_semestr3.SelectedIndex = lb_semestr4.SelectedIndex = lb_semestr5.SelectedIndex = lb_semestr6.SelectedIndex = lb_semestr7.SelectedIndex = lb_semestr8.SelectedIndex = lb_semestr9.SelectedIndex = lb_semestr10.SelectedIndex = lb_semestr11.SelectedIndex = -1;
                        goto case 55;
                    }
                default:
                    urceniZvolenehoListu = -1;
                    break;
            }
        }
        //listy na plnění listboxu a praci kolem něch(mazání a vypis popisu)
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
                default:
                    break;
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
        private decimal VratNudVal(int vyber)
        {
            switch (vyber)
            {
                case 12:
                    {
                        return nud_KredSem12.Value;
                    }
                case 11:
                    {
                        return nud_KredSem11.Value;
                    }
                case 10:
                    {
                        return nud_KredSem10.Value;
                    }
                case 9:
                    {
                        return nud_KredSem9.Value;
                    }
                case 8:
                    {
                        return nud_KredSem8.Value;
                    }
                case 7:
                    {
                        return nud_KredSem7.Value;
                    }
                case 6:
                    {
                        return nud_KredSem6.Value;
                    }
                case 5:
                    {
                        return nud_KredSem5.Value;
                    }
                case 4:
                    {
                        return nud_KredSem4.Value;
                    }
                case 3:
                    {
                        return nud_KredSem3.Value;
                    }
                case 2:
                    {
                        return nud_KredSem2.Value;
                    }
                case 1:
                    {
                        return nud_KredSem1.Value;
                    }
                default:
                    return -1;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}