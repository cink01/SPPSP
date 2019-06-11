﻿using System;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;
using System.Collections.Generic;
using System.Drawing;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCRUDmidstage : Form
    {
        List<Katedra> katedras = new List<Katedra>();
        List<Obor> obors = new List<Obor>();
        List<Garant> garants = new List<Garant>();
        List<Predmet> predmets = new List<Predmet>();
        public FormCRUDmidstage()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }
        private void FormCRUDmidstage_Load(object sender, EventArgs e)
        {
            Filling fill = new Filling();
            DataAccess da = new DataAccess();
            katedras = da.GetFullKatedra();
            obors = da.GetFullObor();
            garants = da.GetFullGarant();
            predmets = da.GetFullPredmet();
            fill.NaplnComboBox<Predmet>(cb_pre, predmets);
            fill.NaplnComboBox<Garant>(cb_garant, garants);
            fill.NaplnComboBox<Obor>(cb_obo, obors);
            fill.NaplnComboBox<Obor>(cmb_obo_pre, obors);
            fill.NaplnComboBox<Katedra>(cb_kat, katedras);
        }
        private void Bt_novy_Click(object sender, EventArgs e)
        {
            if (rb_garant.Checked == true)
            {
                NewGarant();
                return;
            }
            if (rb_predmet.Checked == true)
            {
                NewPredmet();
                return;
            }
            if (rb_obor.Checked == true)
            {
                NewObor();
                return;
            }
            if (rb_katedra.Checked == true)
            {
                NewKatedra();
                return;
            }
        }
        private void NewGarant()
        {
            using (FormCUGarant g = new FormCUGarant())
            {
                g.Text = "Založit nového garanta";
                DialogResult potvrzeni = g.ShowDialog();
                if (potvrzeni == DialogResult.OK)
                {
                    DataCrud x = new DataCrud();
                    try
                    {
                        x.InsertGarant(g.G);
                        DataAccess da = new DataAccess();
                        garants = da.GetFullGarant();
                        MessageBox.Show(Properties.Resources.Vlozeno_MESSAGE,
                            Properties.Resources.Vlozeno_TITLE,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void NewPredmet()
        {
            using (FormCUPredmet p = new FormCUPredmet())
            {
                p.Text = "Založit nový předmět";
                DialogResult potvrzeni = p.ShowDialog();
                if (potvrzeni == DialogResult.OK)
                {
                    DataCrud x = new DataCrud();
                    try
                    {
                        x.InsertPredmet(p.P);
                        ZaridVyber();
                        cb_pre.SelectedIndex = cb_pre.FindStringExact(p.P.ToString());
                        MessageBox.Show(Properties.Resources.Vlozeno_MESSAGE,
                            Properties.Resources.Vlozeno_TITLE,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void NewObor()
        {
            using (FormCUObor o = new FormCUObor())
            {
                o.Text = "Založit nový obor";
                DialogResult potvrzeni = o.ShowDialog();
                if (potvrzeni == DialogResult.OK)
                {
                    DataCrud x = new DataCrud();
                    try
                    {
                        x.InsertObor(o.O);
                        DataAccess da = new DataAccess();
                        obors = da.GetFullObor();
                        MessageBox.Show(Properties.Resources.Vlozeno_MESSAGE,
                            Properties.Resources.Vlozeno_TITLE,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void NewKatedra()
        {
            using (FormCUKatedra k = new FormCUKatedra())
            {
                k.Text = "Založit novou katedru";
                DialogResult potvrzeni = k.ShowDialog();
                if (potvrzeni == DialogResult.OK)
                {
                    DataCrud x = new DataCrud();
                    try
                    {
                        x.InsertKat(k.Zkr, k.Nazev);
                        DataAccess da = new DataAccess();
                        katedras = da.GetFullKatedra();
                        MessageBox.Show(Properties.Resources.Vlozeno_MESSAGE,
                            Properties.Resources.Vlozeno_TITLE,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void Bt_close_Click(object sender, EventArgs e) => Close();
        private void Cb_garant_Hledani(object sender, EventArgs e)
        {
            if (cmb_kat_gar.Text == "")
            {
                DataAccess da = new DataAccess();
                garants = da.GetFullGarant();
            }
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Garant>(cb_garant, garants);
            rb_garant.Checked = true;
        }
        private void Cmb_kat_gar_hledaní(object sender, EventArgs e)
        {
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Katedra>(cmb_kat_gar, katedras);
        }

        private void Cmb_kat_gar_SelectedIndexChanged(object sender, EventArgs e)
        {
            garants.Clear();
            DataAccess da = new DataAccess();
            Katedra temp = (Katedra)cmb_kat_gar.SelectedItem;
            garants = da.GetGarantByKatedra(temp.Id_k);
            Filling fill = new Filling();
            fill.NaplnComboBox<Garant>(cb_garant, garants);
        }
        private void Cb_predmet_Hledani(object sender, EventArgs e)
        {
            if (cmb_obo_pre.Text == "")
            {
                DataAccess da = new DataAccess();
                predmets = da.GetFullPredmet();
            }
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Predmet>(cb_pre, predmets);
            rb_predmet.Checked = true;
        }
        private void Cb_obor_Hledani(object sender, EventArgs e)
        {
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Obor>(cb_obo, obors);
            rb_obor.Checked = true;
        }

        private void Cb_katedra_Hledani(object sender, EventArgs e)
        {
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Katedra>(cb_kat, katedras);
            rb_katedra.Checked = true;
        }
        private void Cmb_obo_pre_Hledání(object sender, EventArgs e)
        {
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Obor>(cmb_obo_pre, obors);
        }
        private void Cmb_obo_pre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZaridVyber();
        }
        private void ZaridVyber()
        {
            string vyber = "";
            if (cb_semestry.SelectedIndex != -1)
                vyber = cb_semestry.SelectedItem.ToString();
            if (vyber == "")
                vyber = "všechny";
            VyberPresSemestr(vyber);
        }
        private void Bt_upravit_Click(object sender, EventArgs e)
        {
            if (rb_garant.Checked == true && cb_garant.SelectedIndex != -1)
            {
                EditGarant();
                return;
            }
            if (rb_predmet.Checked == true && cb_pre.SelectedIndex != -1)
            {
                EditPredmet();
                return;
            }
            if (rb_obor.Checked == true && cb_obo.SelectedIndex != -1)
            {
                EditObor();
                return;
            }
            if (rb_katedra.Checked == true && cb_kat.SelectedIndex != -1)
            {
                EditKatedra();
                return;
            }
        }
        private void EditGarant()
        {
            using (FormCUGarant Gara = new FormCUGarant())
            {
                Gara.Text = "Upravit Garanta";
                try
                {
                    Garant o = (Garant)cb_garant.SelectedItem;
                    Gara.Id = o.Id_v;
                    Gara.Jmeno = o.Jmeno_v;
                    Gara.Email = o.Email_V;
                    Gara.Tel = o.Tel_v;
                    Gara.Konz = o.Konz_v;
                    Gara.Kat = o.Id_k;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Properties.Resources.NelzeUlozit_MESSAGE + ex,
                                    Properties.Resources.Chyba_TITLE,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DataAccess a = new DataAccess();
                DialogResult potvrzeni = Gara.ShowDialog();
                if (potvrzeni == DialogResult.OK)
                {
                    DataCrud x = new DataCrud();
                    try
                    {
                        x.UpdateGarant(Gara.G);
                        garants = a.GetFullGarant();
                        cb_garant.Text = Gara.G.ToString();
                        Filling.FillGarantDetail(Gara.G, vypisGarant_Mid);
                        MessageBox.Show(Properties.Resources.Uprava_MESSAGE,
                                        Properties.Resources.Vlozeno_TITLE,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void EditPredmet()
        {
            using (FormCUPredmet Pred = new FormCUPredmet())
            {
                Pred.Text = "Upravit Předmět";
                try
                {
                    Predmet o = (Predmet)cb_pre.SelectedItem;
                    Pred.Id = o.Id_predmet;
                    Pred.Nazev = o.Name_predmet;
                    Pred.Zkr = o.Zkr_predmet;
                    Pred.Kredit = o.Kredit_predmet;
                    Pred.Obor = o.Id_obor;
                    Pred.Garant = o.Id_v;
                    Pred.Semestr = o.Semestr_predmet;
                    Pred.Orig = o.Id_orig;
                    Pred.Povinnost = o.Povinnost;
                    Pred.Prednaska = o.Prednaska;
                    Pred.Cv = o.Cviceni;
                    Pred.Cvk = o.Kombi;
                    Pred.Lab = o.Lab;
                    Pred.Jazyk = o.Jazyk;
                    Pred.Zakonceni = o.Zakonceni;
                    Pred.Popis = o.Popis;
                    Pred.Prerek = o.Prerekvizita;
                }
                catch { }
                DataAccess a = new DataAccess();
                DialogResult potvrzeni = Pred.ShowDialog();
                if (potvrzeni == DialogResult.OK)
                {
                    DataCrud x = new DataCrud();
                    try
                    {

                        x.UpdatePredmet(Pred.P);
                        ZaridVyber();
                        cb_pre.Text = Pred.P.ToString();
                        Filling.FillDetail(vypisPopisPredmetMid, Pred.P);
                        predmets = a.GetFullPredmet();
                        MessageBox.Show(Properties.Resources.Uprava_MESSAGE,
                                        Properties.Resources.Uprava_TITLE,
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void EditObor()
        {
            if (cb_obo.SelectedIndex != -1)
            {
                using (FormCUObor Obo = new FormCUObor())
                {
                    Obo.Text = "Upravit Obor";
                    try
                    {
                        Obor o = (Obor)cb_obo.SelectedItem;
                        Obo.Id = o.Id_obor;
                        Obo.Zkr = o.Zkr_obor;
                        Obo.Nazev = o.Name_obor;
                        Obo.Rok = o.Rok_obor;
                        Obo.P = o.P_obor;
                        Obo.Pv = o.Pv_obor;
                        Obo.V = o.V_obor;
                        Obo.Vs = o.Vs_obor;
                        Obo.Praxe = o.Praxe;
                        Obo.Zaver = o.Zaver;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Properties.Resources.NelzeUlozit_MESSAGE + ex,
                                        Properties.Resources.Chyba_TITLE,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    DataAccess a = new DataAccess();
                    DialogResult potvrzeni = Obo.ShowDialog();
                    if (potvrzeni == DialogResult.OK)
                    {
                        DataCrud x = new DataCrud();
                        try
                        {
                            x.UpdateObor(Obo.O);
                            obors = a.GetFullObor();
                            cb_obo.Text = Obo.O.ToString();
                            Filling.FillOborDetail(Obo.O, VypisOborMid);
                            MessageBox.Show(Properties.Resources.Uprava_MESSAGE,
                                            Properties.Resources.Uprava_TITLE,
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void EditKatedra()
        {
            if (cb_kat.SelectedIndex != -1)
            {
                using (FormCUKatedra Kat = new FormCUKatedra())
                {
                    Kat.Text = "Upravit Katedru";
                    try
                    {
                        Katedra o = (Katedra)cb_kat.SelectedItem;
                        Kat.Id = o.Id_k;
                        Kat.Zkr = o.Zkr_k;
                        Kat.Nazev = o.Naz_k;
                    }
                    catch { }
                    DataAccess a = new DataAccess();
                    DialogResult potvrzeni = Kat.ShowDialog();
                    if (potvrzeni == DialogResult.OK)
                    {
                        DataCrud x = new DataCrud();
                        try
                        {
                            x.UpdateKatedra(Kat.K);
                            katedras = a.GetFullKatedra();
                            cb_kat.Text = Kat.K.ToString();
                            MessageBox.Show(Properties.Resources.Uprava_MESSAGE,
                                            Properties.Resources.Uprava_TITLE,
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void Bt_smazat_Click(object sender, EventArgs e)
        {
            if (rb_garant.Checked == true)
            {
                DeleteGarant();
                return;
            }
            if (rb_predmet.Checked == true)
            {
                DeletePredmet();
                return;
            }
            if (rb_obor.Checked == true)
            {
                DeleteObor();
                return;
            }
            if (rb_katedra.Checked == true)
            {
                DeleteKatedra();
                return;
            }
        }
        public void DeleteGarant()
        {
            if (cb_garant.SelectedIndex != -1)
            {
                try
                {
                    Garant temp = (Garant)cb_garant.SelectedItem;
                    DataCrud dc = new DataCrud();
                    dc.DeleteGarant(temp.Id_v);
                    DataAccess da = new DataAccess();
                    garants = da.GetFullGarant();
                    cb_garant.Text = "";
                    Filling.ClearGarantDetail(vypisGarant_Mid);
                    MessageBox.Show(Properties.Resources.Delete_MESSAGE,
                        Properties.Resources.Delete_TITLE,
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Properties.Resources.NelzeSmazat_MESSAGE + ex,
                        Properties.Resources.Chyba_TITLE,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void DeletePredmet()
        {
            if (cb_pre.SelectedIndex != -1)
            {
                try
                {
                    Predmet temp = (Predmet)cb_pre.SelectedItem;
                    DataCrud dc = new DataCrud();
                    DataAccess da = new DataAccess();
                    dc.DeletePredmet(temp.Id_predmet);
                    predmets = da.GetFullPredmet();
                    cb_pre.Text = "";
                    Filling.ClearDetail(vypisPopisPredmetMid);
                    MessageBox.Show(Properties.Resources.Delete_MESSAGE,
                        Properties.Resources.Delete_TITLE,
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Properties.Resources.NelzeSmazat_MESSAGE + ex,
                        Properties.Resources.Chyba_TITLE,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void DeleteObor()
        {
            if (cb_obo.SelectedIndex != -1)
            {
                try
                {
                    Obor temp = (Obor)cb_obo.SelectedItem;
                    DataCrud dc = new DataCrud();
                    DataAccess da = new DataAccess();
                    dc.DeleteObor(temp.Id_obor);
                    obors = da.GetFullObor();
                    cb_obo.Text = "";
                    Filling.ClearOborDetail(VypisOborMid);
                    MessageBox.Show(Properties.Resources.Delete_MESSAGE,
                                    Properties.Resources.Delete_TITLE,
                                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Properties.Resources.NelzeSmazat_MESSAGE + ex,
                                    Properties.Resources.Chyba_TITLE,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void DeleteKatedra()
        {
            if (cb_kat.SelectedIndex != -1)
            {
                try
                {
                    Katedra temp = (Katedra)cb_kat.SelectedItem;
                    DataCrud dc = new DataCrud();
                    dc.DeleteKatedra(temp.Id_k);
                    DataAccess da = new DataAccess();
                    katedras = da.GetFullKatedra();
                    cb_kat.Text = "";
                    MessageBox.Show(Properties.Resources.Delete_MESSAGE,
                        Properties.Resources.Delete_TITLE,
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Properties.Resources.NelzeSmazat_MESSAGE + ex,
                        Properties.Resources.Chyba_TITLE,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Cb_semestry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vyber = cb_semestry.SelectedItem.ToString();
            if (vyber == "")
                vyber = "všechny";
            VyberPresSemestr(vyber);
        }
        private void VyberPresSemestr(string vyber)
        {
            int iobor = VratIdckoOboru();
            DataAccess da = new DataAccess();
            switch (vyber)
            {
                case "1":
                    {
                        predmets.Clear();
                        if (iobor == -1)
                            predmets = da.GetPredmetBySemestrFull(1);
                        else
                        {
                            predmets = da.GetPredmetBySemestr(1, iobor);
                        }
                    }
                    break;
                case "2":
                    {
                        predmets.Clear();
                        if (iobor == -1)
                            predmets = da.GetPredmetBySemestrFull(2);
                        else
                        {
                            predmets = da.GetPredmetBySemestr(2, iobor);
                        }
                    }
                    break;
                case "3":
                    {
                        predmets.Clear();
                        if (iobor == -1)
                            predmets = da.GetPredmetBySemestrFull(3);
                        else
                        {
                            predmets = da.GetPredmetBySemestr(3, iobor);
                        }
                    }
                    break;
                case "4":
                    {
                        predmets.Clear();
                        if (iobor == -1)
                            predmets = da.GetPredmetBySemestrFull(4);
                        else
                        {
                            predmets = da.GetPredmetBySemestr(4, iobor);
                        }
                    }
                    break;
                case "5":
                    {
                        predmets.Clear();
                        if (iobor == -1)
                            predmets = da.GetPredmetBySemestrFull(5);
                        else
                        {
                            predmets = da.GetPredmetBySemestr(5, iobor);
                        }
                    }
                    break;
                case "6":
                    {
                        predmets.Clear();
                        if (iobor == -1)
                            predmets = da.GetPredmetBySemestrFull(6);
                        else
                        {
                            predmets = da.GetPredmetBySemestr(6, iobor);
                        }
                    }
                    break;
                case "všechny":
                    {
                        predmets.Clear();
                        if (iobor == -1)
                            predmets = da.GetFullPredmet();
                        else
                        {
                            predmets = da.GetPredmetFullByObor(iobor);
                        }
                    }
                    break;
                case "neřazazeno":
                    {
                        predmets.Clear();
                        if (iobor == -1)
                            predmets = da.GetPredmetBySemestrFull(0);
                        else
                        {
                            predmets = da.GetPredmetBySemestr(0, iobor);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        private int VratIdckoOboru()
        {
            try
            {
                Obor temp = (Obor)cmb_obo_pre.SelectedItem;
                return (temp.Id_obor);
            }
            catch
            {
                return -1;
            }
        }
        private void Cb_pre_SelectedIndexChanged(object sender, EventArgs e)
        {
            vypisPopisPredmetMid.Visible = true;
            if (cb_pre.SelectedIndex == -1)
                vypisPopisPredmetMid.Visible = false;
            Filling fill = new Filling();
            fill.FillDetail(cb_pre, vypisPopisPredmetMid);
        }
        private void PovolitSprávuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x = DialogResult.Cancel;
            if (bt_novy.Visible != true)
                x = MessageBox.Show(Properties.Resources.PovoleniSpravce_MESSAGE, Properties.Resources.PovoleniSpravce_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            else
            {
                Schovka();
                povolitSprávuToolStripMenuItem.Text = "Povolit správu";
            }
            if (x == DialogResult.OK)
            {
                Schovka();
                povolitSprávuToolStripMenuItem.Text = "Zakázat správu";
            }
        }
        private void Schovka()
        {
            hromadnéNačteníToolStripMenuItem.Visible = hromadnéNačteníToolStripMenuItem.Visible != true;
            bt_novy.Visible = bt_novy.Visible != true;
            bt_upravit.Visible = bt_upravit.Visible != true;
            bt_smazat.Visible = bt_smazat.Visible != true;
            kb_d.Visible = kb_d.Visible != true;
            kb_e.Visible = kb_e.Visible != true;
            kb_n.Visible = kb_n.Visible != true;
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
                    if (MessageBox.Show(Properties.Resources.HromadneNacitani_MESSAGE, Properties.Resources.HromadneNacitani_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        cesta = openFileDialog.FileName;
                        NacteniDat nd = new NacteniDat();
                        nd.Proved(cesta);
                    }
                }
            }
        }
        private void PřidatPopisyKPředmětůmToolStripMenuItem_Click(object sender, EventArgs e)
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
                    if (MessageBox.Show(Properties.Resources.HromadneNacitani_MESSAGE, Properties.Resources.HromadneNacitani_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        cesta = openFileDialog.FileName;
                        NacteniDat nd = new NacteniDat();
                        nd.ProvedPopis(cesta);
                    }
                }
            }
        }
        private void Cb_garant_SelectedIndexChanged(object sender, EventArgs e)
        {
            vypisGarant_Mid.Visible = true;
            if (cb_garant.SelectedIndex == -1)
                vypisGarant_Mid.Visible = false;
            Filling f = new Filling();
            f.FillGarantDetail(cb_garant, vypisGarant_Mid);
        }
        private void Cb_kat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Cb_obo_SelectedIndexChanged(object sender, EventArgs e)
        {
            VypisOborMid.Visible = true;
            if (cb_obo.SelectedIndex == -1)
                VypisOborMid.Visible = false;
            Filling f = new Filling();
            f.FillOborDetail(cb_obo, VypisOborMid);
        }
        private void Rb_obor_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_obor.Checked == true)
                Zobrazovacka(1);
            if (rb_katedra.Checked == true)
                Zobrazovacka(2);
            if (rb_garant.Checked == true)
                Zobrazovacka(3);
            if (rb_predmet.Checked == true)
                Zobrazovacka(4);
        }
        private void Zobrazovacka(int vyber)
        {
            gb_g.Visible = gb_k.Visible = gb_o.Visible = gb_p.Visible = false;
            gb_g.Left = gb_k.Left = gb_o.Left = gb_p.Left = 3;
            cb_garant.Text = cb_kat.Text = cb_obo.Text = cb_pre.Text = "";
            vypisGarant_Mid.Location = new Point(186, 30);
            VypisOborMid.Location = new Point(186, 29);
            vypisPopisPredmetMid.Location = new Point(186, 28);
            vypisGarant_Mid.Visible = VypisOborMid.Visible = vypisPopisPredmetMid.Visible = false;
            switch (vyber)
            {
                case 1:
                    gb_o.Visible = true;
                    this.Size = new Size(590, 387);
                    break;
                case 2:
                    gb_k.Visible = true;
                    this.Size = new Size(205, 370);
                    break;
                case 3:
                    gb_g.Visible = true;
                    this.Size = new Size(491, 370);
                    break;
                case 4:
                    gb_p.Visible = true;
                    this.Size = new Size(590, 405);
                    break;
                default:
                    break;
            }
        }
    }
}