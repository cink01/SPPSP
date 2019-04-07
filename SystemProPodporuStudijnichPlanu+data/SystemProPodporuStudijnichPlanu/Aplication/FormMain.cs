using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Aplication;
using SystemProPodporuStudijnichPlanu.Logic;

namespace SystemProPodporuStudijnichPlanu
{
    public partial class FormMain : Form
    {
        private const int ZaDvaSemestry = 40;
        private const int ZaJedenSemestr = 20;
        private const int ZaPrvniSemestr = 15;
        public List<Predmet> predmetyLichy = new List<Predmet>();
        public List<Predmet> predmetySudy = new List<Predmet>();
        public List<Predmet> Sporty = new List<Predmet>();
        public FormMain()
        {
            InitializeComponent();
            RefreshZaznamy("Doporučené AI");
            //  menuStripMain.BackColor = ColorTranslator.FromHtml("#e8212e");
            VyplnPotrebnyZeZaznamu();
            urceniZvolenehoListu = 0;
            if (cmb_zaznam.Items.Count <= 1)
            {
                DialogResult res = MessageBox.Show(Properties.Resources.Uvod_MESSAGE, Properties.Resources.Uvod_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                    VytvorZaznam();
            }
        }
        private void RefreshList(ListBox x, int vyber)
        {
            VratZaznamData(out int izaz, out _, out _, out _);
            Filling fill = new Filling();
            urceniZvolenehoListu = 0;
            fill.FillSemestrLB(x, izaz, vyber, out Kredity sum, out List<Predmet> p);
            NaplnVybranyList(vyber, p);
            VyberNudVal(sum.Suma, vyber);
        }
        private void ZmenaKredituVNUD(object sender, EventArgs e)
        {
            //celkové kredity
            nud_celkemKred.Value = nud_KredSem1.Value + nud_KredSem2.Value + nud_KredSem3.Value + nud_KredSem4.Value + nud_KredSem5.Value + nud_KredSem6.Value + nud_KredSem7.Value + nud_KredSem8.Value + nud_KredSem9.Value + nud_KredSem10.Value + nud_KredSem11.Value + nud_KredSem12.Value;
            nud_celkemKred.BackColor = nud_celkemKred.Value < 180 ? Color.LightCoral : Color.LightGreen;
            //individuální semestry
            nud_KredSem1.BackColor = nud_KredSem1.Value < ZaPrvniSemestr ? Color.LightCoral : Color.LightGreen;
            nud_KredSem2.BackColor = nud_KredSem2.Value + nud_KredSem1.Value < ZaDvaSemestry || nud_KredSem2.Value == ZaJedenSemestr ? Color.LightCoral : Color.LightGreen;
            nud_KredSem3.BackColor = nud_KredSem3.Value + nud_KredSem2.Value < ZaDvaSemestry || nud_KredSem3.Value == ZaJedenSemestr ? Color.LightCoral : Color.LightGreen;
            nud_KredSem4.BackColor = nud_KredSem4.Value + nud_KredSem3.Value < ZaDvaSemestry || nud_KredSem4.Value == ZaJedenSemestr ? Color.LightCoral : Color.LightGreen;
            nud_KredSem5.BackColor = nud_KredSem5.Value + nud_KredSem4.Value < ZaDvaSemestry || nud_KredSem5.Value == ZaJedenSemestr ? Color.LightCoral : Color.LightGreen;
            nud_KredSem6.BackColor = nud_KredSem6.Value + nud_KredSem5.Value < ZaDvaSemestry || nud_KredSem6.Value == ZaJedenSemestr ? Color.LightCoral : Color.LightGreen;
            nud_KredSem7.BackColor = nud_KredSem7.Value + nud_KredSem6.Value < ZaDvaSemestry || nud_KredSem7.Value == ZaJedenSemestr ? Color.LightCoral : Color.LightGreen;
            nud_KredSem8.BackColor = nud_KredSem8.Value + nud_KredSem7.Value < ZaDvaSemestry || nud_KredSem8.Value == ZaJedenSemestr ? Color.LightCoral : Color.LightGreen;
            nud_KredSem9.BackColor = nud_KredSem9.Value + nud_KredSem8.Value < ZaDvaSemestry || nud_KredSem9.Value == ZaJedenSemestr ? Color.LightCoral : Color.LightGreen;
            nud_KredSem10.BackColor = nud_KredSem10.Value + nud_KredSem9.Value < ZaDvaSemestry || nud_KredSem10.Value == ZaJedenSemestr ? Color.LightCoral : Color.LightGreen;
            nud_KredSem11.BackColor = nud_KredSem11.Value + nud_KredSem10.Value < ZaDvaSemestry || nud_KredSem11.Value == ZaJedenSemestr ? Color.LightCoral : Color.LightGreen;
            nud_KredSem12.BackColor = nud_KredSem12.Value + nud_KredSem11.Value < ZaDvaSemestry || nud_KredSem12.Value == ZaJedenSemestr ? Color.LightCoral : Color.LightGreen;

        }
        private void UkonceniProgramu(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.EXIT_MESSAGE, Properties.Resources.EXIT_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void PripravPresun(int v, int o, int z)
        {
            Sporty.Clear();
            predmetyLichy.Clear();
            predmetySudy.Clear();
            DataAccess da = new DataAccess();
            Sporty = da.SportyNotInVyber(v, o, z);
            predmetyLichy = da.GetPredmetFullLichyVyberKromeSportu(o, z);
            predmetySudy = da.GetPredmetFullSudyVyberKromeSportu(o, z);
        }
        private void Bt_proved_Click(object sender, EventArgs e)
        {
            if (cmb_zaznam.SelectedIndex >= 0)
            {
                // DataAccess da = new DataAccess();
                VratZaznamData(out int id_z, out _, out int id_o, out int PocSem);
                int vyber = (int)nud_PridatDoSem.Value;
                PripravPresun(vyber, id_o, id_z);
                using (FormPridavani FP = new FormPridavani())
                {
                    FP.Text = "Přidání předmětu do " + vyber + ". semestru";
                    if (vyber == 1 || vyber == 3 || vyber == 5 || vyber == 7 || vyber == 9 || vyber == 11)
                    {
                        predmetyLichy.AddRange(Sporty);
                        FP.PredmetySeznam = predmetyLichy;
                        FP.Lichy = true;
                    }
                    else
                    {
                        predmetySudy.AddRange(Sporty);
                        FP.PredmetySeznam = predmetySudy;
                        FP.Lichy = false;
                    }
                    FP.RefreshSeznam();
                    DialogResult potvrzeni = FP.ShowDialog();
                    if (potvrzeni == DialogResult.OK)
                    {
                        DataCrud data = new DataCrud();
                        foreach (Predmet p in FP.PredmetyAdd)
                        {
                            data.InsertVyber(p.Id_predmet, vyber, id_z);
                        }
                        RefreshList(VratListBox(vyber), vyber);
                        ObnovPovinn(id_o, PocSem);
                    }
                }
            }
        }
        public void ObnovPovinn(int id_o, int PocSem)
        {
            DataAccess da = new DataAccess();
            Filling fill = new Filling();
            Kredity kr = new Kredity();
            for (int i = 1; i <= PocSem; i++)
                fill.VypoctiPovinnostiKredity(VyberListu(i), kr);
            Obor obor = da.GetOborById(id_o);
            fill.NaplnNUDyPovinn(nud_pKr, nud_pvKr, nud_vKr, kr, obor);
        }
        private void Cmb_zaznam_SelectedIndexChanged(object sender, EventArgs e)
        {
            VyplnPotrebnyZeZaznamu();
            bt_delZaz.Visible = false;
            if (cmb_zaznam.SelectedIndex >= 0)
            {
                bt_delZaz.Visible = true;
                FillHlavniListy();
                Zaznam z = (Zaznam)cmb_zaznam.SelectedItem;
                ObnovPovinn(z.Id_obor, z.PocetSem);
            }
        }
        private void VyplnPotrebnyZeZaznamu()
        {
            try
            {
                Zaznam z = (Zaznam)cmb_zaznam.SelectedItem;
                Viditelnost(z.PocetSem);
                nud_PridatDoSem.Maximum = z.PocetSem;
            }
            catch { }
        }
        List<Zaznam> zaznams = new List<Zaznam>();
        private void RefreshZaznamy(string zkratka = "")
        {
            cmb_zaznam.DataSource = null;
            Filling f = new Filling();
            DataAccess db = new DataAccess();
            zaznams = db.GetFullZaznam();
            f.NaplnComboBox<Zaznam>(cmb_zaznam, zaznams);
            f.NastavIndexCombo<Zaznam>(cmb_zaznam, /*zaznams,*/zkratka);
        }
        private void VratZaznamData(out int id_z, out string zkr, out int id_o, out int PocSem)
        {
            try
            {
                Zaznam z = (Zaznam)cmb_zaznam.SelectedItem;
                id_z = z.Id_zaznam;
                zkr = z.Zkr_zaznam;
                id_o = z.Id_obor;
                PocSem = z.PocetSem;
            }
            catch
            {
                id_z = id_o = PocSem = -1;
                zkr = "";
                MessageBox.Show(Properties.Resources.NevybranZaznam_MESSAGE);
            }
        }
        private void FillHlavniListy()
        {
            ClearListy();
            VratZaznamData(out _, out _, out _, out int semestry);
            Viditelnost(semestry);
            nud_PridatDoSem.Maximum = semestry;
            for (int i = 1; i <= semestry; i++)
                RefreshList(VratListBox(i), i);
        }
        private void Lb_semestr1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VratListBox(1).SelectedIndex != -1)
                DeselectnutiListu(1);
        }
        private void Lb_semestr2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VratListBox(2).SelectedIndex != -1)
                DeselectnutiListu(2);
        }
        private void Lb_semestr3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VratListBox(3).SelectedIndex != -1)
                DeselectnutiListu(3);
        }
        private void Lb_semestr4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VratListBox(4).SelectedIndex != -1)
                DeselectnutiListu(4);
        }
        private void Lb_semestr5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VratListBox(5).SelectedIndex != -1)
                DeselectnutiListu(5);
        }
        private void Lb_semestr6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VratListBox(6).SelectedIndex != -1)
                DeselectnutiListu(6);
        }
        private void Lb_semestr7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VratListBox(7).SelectedIndex != -1)
                DeselectnutiListu(7);
        }
        private void Lb_semestr8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VratListBox(8).SelectedIndex != -1)
                DeselectnutiListu(8);
        }
        private void Lb_semestr9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VratListBox(9).SelectedIndex != -1)
                DeselectnutiListu(9);
        }
        private void Lb_semestr10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VratListBox(10).SelectedIndex != -1)
                DeselectnutiListu(10);
        }
        private void Lb_semestr11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VratListBox(11).SelectedIndex != -1)
                DeselectnutiListu(11);
        }
        private void Lb_semestr12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VratListBox(12).SelectedIndex != -1)
                DeselectnutiListu(12);
        }
        private void Bt_smaz_Click(object sender, EventArgs e)
        {
            try
            {
                VratZaznamData(out int id_z, out _, out int id_o, out _);
                decimal sum = VratNudVal(urceniZvolenehoListu) - Convert.ToDecimal(vypisPopisPredmet.Kredit);
                MazatZVyberu(VratListBox(urceniZvolenehoListu), id_z, urceniZvolenehoListu, id_o);
                VyberNudVal(sum, urceniZvolenehoListu);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.NevybranZaznam_MESSAGE);
            }
        }
        public void MazatZVyberu(ListBox LB, int id_z, int sem, int id_o)
        //přesunuto z DataAccess do main vyresit zapis a nebo reset lichy a sudy aby se to dalo presunout pryc
        {
            DataAccess da = new DataAccess();
            Predmet temp = (Predmet)LB.SelectedItem;
            if (sem == 0 || sem == 2 || sem == 4 || sem == 6 || sem == 8 || sem == 10 || sem == 12)
                predmetySudy.Add(temp);
            else
                predmetyLichy.Add(temp);
            int id = da.GetVyberId(id_z, temp.Id_predmet, sem);
            LB.Items.Remove(LB.SelectedItem);
            DataCrud dc = new DataCrud();
            dc.DeleteVyber(id);
            Filling fill = new Filling();
            fill.VratHodnotuPoSmazani(temp, nud_pKr, nud_pvKr, nud_vKr, nud_celkemKred, id_o);
        }
        private void ClearListy()
        {
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
        private void VytvořitNovýZáznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VytvorZaznam();
        }
        private void VytvorZaznam()
        {
            using (FormCUZaznam Zaznam = new FormCUZaznam())
            {
                Zaznam.Text = "Vytvořit nový záznam";
                Zaznam.Schov = true;
                DialogResult potvrzeni = Zaznam.ShowDialog();
                if (potvrzeni == DialogResult.OK)
                //po potvrzení okna záznamu
                {
                    Filling fill = new Filling();
                    fill.NovyZaznam(Zaznam.Zaz);
                    RefreshZaznamy(Zaznam.Zkr);
                }
            }

        }
        private void UpravitZáznamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmb_zaznam.SelectedIndex != -1)
            {
                VratZaznamData(out int id_z, out string zkr, out int ido, out int PocSem);
                using (FormCUZaznam Zaznam = new FormCUZaznam())
                {
                    Zaznam.Text = "Upravit záznam";
                    Zaznam.Schov = false;
                    Zaznam.Id = id_z;
                    Zaznam.Zkr = zkr;
                    Zaznam.Obor = ido;
                    Zaznam.Semestr = PocSem;
                    int oborOld = ido;
                    DataAccess a = new DataAccess();
                    DialogResult potvrzeni = Zaznam.ShowDialog();
                    if (potvrzeni == DialogResult.OK)
                    {
                        DataCrud dc = new DataCrud();
                        int oborNew = Zaznam.Obor;
                        try
                        {
                            if (oborNew == oborOld)//pakliže se obor nezmění
                            {
                                //úprava záznamu
                                dc.UpdateZaznamPrepocet(Convert.ToInt32(Zaznam.Id), Zaznam.Zkr, Zaznam.Semestr, a.GetZaznamSemestr(id_z));
                            }
                            else//když se obor změní
                            {
                                Filling fill = new Filling();
                                fill.NovyZaznam(Zaznam.Zaz, 1);
                            }
                            RefreshZaznamy(Zaznam.Zkr);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(Properties.Resources.NelzeUlozit_MESSAGE + ex,
                                            Properties.Resources.Chyba_TITLE,
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void SprávaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCRUDmidstage x = new FormCRUDmidstage())
            {
                string zaznamText = cmb_zaznam.SelectedItem.ToString();
                x.Text = "Vyhledávání";
                //x.Show();
                if (DialogResult.Cancel == x.ShowDialog())
                {
                    RefreshZaznamy(zaznamText);
                }
            }
        }
        private void ZměnyVeliZic(int i)
        {
            vypisPopisPredmet.Left = i > 6 ? 680 : 428;
            vypisGarantMain.Left = i > 6 ? 780 : 528;
            bt_zobrazDGar.Left = i > 6 ? 682 : 428;
            vypisPopisPredmet.Visible = vypisGarantMain.Visible = bt_zobrazDGar.Visible = bt_smaz.Visible = false;
            nud_celkemKred.Left = nud_pKr.Left = nud_pvKr.Left = nud_vKr.Left = i > 6 ? 1012 : 761;
            lb_celkem.Left = i > 6 ? 929 : 674;
            l_pkr.Left = i > 6 ? 860 : 605;
            l_pvk.Left = i > 6 ? 866 : 611;
            l_vk.Left = i > 6 ? 859 : 604;
            gb_max.Size = i > 6 ? new Size(1074, 654) : new Size(820, 654);
            this.Size = i > 6 ? new Size(1116, 731) : new Size(860, 731);
            Tma();
        }
        private void Viditelnost(int i)
        {
            ZměnyVeliZic(i);
            switch (i)
            {
                case 12:
                    {
                        nud_KredSem12.Visible = lb_semestr12.Visible = l_s12.Visible = true;
                        goto case 11;
                    }
                case 11:
                    {
                        nud_KredSem11.Visible = lb_semestr11.Visible = l_s11.Visible = true;
                        goto case 10;
                    }
                case 10:
                    {
                        nud_KredSem10.Visible = lb_semestr10.Visible = l_s10.Visible = true;
                        goto case 9;
                    }
                case 9:
                    {
                        nud_KredSem9.Visible = lb_semestr9.Visible = l_s9.Visible = true;
                        goto case 8;
                    }
                case 8:
                    {
                        nud_KredSem8.Visible = lb_semestr8.Visible = l_s8.Visible = true;
                        goto case 7;
                    }
                case 7:
                    {
                        nud_KredSem7.Visible = lb_semestr7.Visible = l_s7.Visible = true;
                        goto case 6;
                    }
                case 6:
                    {
                        nud_KredSem6.Visible = lb_semestr6.Visible = l_s6.Visible = true;
                        goto case 5;
                    }
                case 5:
                    {
                        nud_KredSem5.Visible = lb_semestr5.Visible = l_s5.Visible = true;
                        goto case 4;
                    }
                case 4:
                    {
                        nud_KredSem4.Visible = lb_semestr4.Visible = l_s4.Visible = true;
                        goto case 3;
                    }
                case 3:
                    {
                        nud_KredSem3.Visible = lb_semestr3.Visible = l_s3.Visible = true;
                        goto case 2;
                    }
                case 2:
                    {
                        nud_KredSem2.Visible = lb_semestr2.Visible = l_s2.Visible = true;
                        goto case 1;
                    }
                case 1:
                    {
                        nud_KredSem1.Visible = lb_semestr1.Visible = l_s1.Visible = true;
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
                lb_semestr4.Visible = lb_semestr3.Visible = lb_semestr2.Visible = lb_semestr1.Visible =
                l_s1.Visible = l_s2.Visible = l_s3.Visible = l_s4.Visible = l_s5.Visible = l_s6.Visible =
                l_s7.Visible = l_s8.Visible = l_s9.Visible = l_s10.Visible = l_s11.Visible = l_s12.Visible = false;
        }
        private int urceniZvolenehoListu;
        private void DeselectnutiListu(int i)
        {
            bt_smaz.Visible = true;
            bt_zobrazDGar.Visible = true;
            vypisPopisPredmet.Visible = true;
            vypisGarantMain.Visible = false;
            switch (i)
            {
                case 12:
                    {
                        lb_semestr1.SelectedIndex =
                        lb_semestr2.SelectedIndex =
                        lb_semestr3.SelectedIndex =
                        lb_semestr4.SelectedIndex =
                        lb_semestr5.SelectedIndex =
                        lb_semestr6.SelectedIndex =
                        lb_semestr7.SelectedIndex =
                        lb_semestr8.SelectedIndex =
                        lb_semestr9.SelectedIndex =
                        lb_semestr10.SelectedIndex =
                        lb_semestr11.SelectedIndex = -1;
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
            try
            {
                Filling fill = new Filling();
                fill.FillDetail(VratListBox(i), vypisPopisPredmet);
                urceniZvolenehoListu = i;
                nud_PridatDoSem.Value = (decimal)i;
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.ChybneNacteni_MESSAGE, Properties.Resources.Chyba_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //listy na plnění listboxu a praci kolem něch(mazání a vypis popisu)
        /// <summary>
        /// tato část inicializuje listi pro každý semestr
        /// </summary>
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
        private void Bt_zobrazDGar_Click(object sender, EventArgs e)
        {
            vypisGarantMain.Visible = true;
            Filling f = new Filling();
            f.FillGarantDetail(VratListBox(urceniZvolenehoListu), vypisGarantMain);
        }
        private void ListyZmacknutiKlavesy(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bt_zobrazDGar.PerformClick();
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                bt_smaz.PerformClick();
                return;
            }
        }
        private void Bt_delZaz_Click(object sender, EventArgs e)
        {
            if (cmb_zaznam.SelectedIndex != -1)
            {
                try{
                    DataCrud dc = new DataCrud();
                    dc.DeleteZaznam(((Zaznam)cmb_zaznam.SelectedItem).Id_zaznam);
                    RefreshZaznamy();
                }catch { }
            }
        }
        private void Bt_addZaz_Click(object sender, EventArgs e)
        {
            vytvořitNovýZáznamToolStripMenuItem.PerformClick();
        }

        private void KulateButton1_Click(object sender, EventArgs e)
        {
            upravitZáznamToolStripMenuItem.PerformClick();
        }

        private void OAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.oApp_MESSAGE, 
                                Properties.Resources.oApp_TITLE, 
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                Process.Start("https://github.com/cink01/SPPSP/blob/master/dokumentace/ZP_VSPJ_SPPSP.docx");
            }
        }
    }
}