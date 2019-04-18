using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Komponenty;

namespace SystemProPodporuStudijnichPlanu.Logic
{
    public class Filling
    {
        public StringComparison Comp { get; set; } = StringComparison.OrdinalIgnoreCase;
        public DataAccess da;
        public Kredity kr;
        public Filling() => da = new DataAccess();
        /// <summary>
        /// Funkce vytvořená na plnění ComboBoxu Listem.
        /// Data Listů jsou ve formě přepravky a všechny přepravky 
        /// mají přetíženou funkci ToString(), aby bylo dosaženo
        /// daného formátování dat v přepravce a tato funkce šla
        /// použít pro všechny přepravky
        /// </summary>
        /// <typeparam name="T">Třída přepravky</typeparam>
        /// <param name="cb">ComboBox, který má být naplněn</param>
        /// <param name="li">List s hodnotami</param>
        public void NaplnComboBox<T>(ComboBox cb, List<T> li)
        {
            //vyčištění dat v comboboxu
            cb.DataSource = null;
            cb.Items.Clear();
            //pro každou položku v listu se přidá jako item 
            try
            {
                foreach (T temp in li)
                    cb.Items.Add(temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.Resources.Chyba_TITLE + ": " + ex);
            }
        }
        /// <summary>
        /// Funkce využítá k vyhledávání položek v comboboxu.
        /// K vyhledávání se využívá text v políčku v samotném comboboxu
        /// a tato hodnota se porovnává s daty v listech
        /// 
        /// </summary>
        /// <typeparam name="T">Třída přepravky</typeparam>
        /// <param name="x">ComboBox, ve kterém chceme vyhledávat</param>
        /// <param name="temp">List s položkami ComboBoxu</param>
        public void NajdiVComboBoxu<T>(ComboBox x, List<T> temp)
        {
            //uvolnění ComboBoxu
            x.Items.Clear();
            //nastavení defaultní šírky
            int sirka = 1;
            foreach (T o in temp)
            //prohledávání všech prvků v listu a porovnávání se zadaným textem
            {
                if (o.ToString().IndexOf(x.Text, Comp) >= 0)
                //pakliže se najde prvek obsahující x.Text, tak se přidá do ComboBoxu
                {
                    x.Items.Add(o);
                    //přepočítání šířky rozbalené komponenty
                    int tmp = TextRenderer.MeasureText(o.ToString(), x.Font).Width;
                    if (sirka < tmp)
                        sirka = tmp;
                }
            }
            x.DropDownWidth = sirka;
        }
        public void DynSirka<T>(ComboBox x, List<T> temp)
        //funkce nevyužitá/pridana do hledání, aby se nemusely listy procházet vícekrát
        {
            int sirka = 1;
            foreach (T o in temp)
            {
                if (o.ToString().IndexOf(x.Text, Comp) >= 0)
                {
                    int tmp = TextRenderer.MeasureText(o.ToString(), x.Font).Width;
                    if (sirka < tmp)
                        sirka = tmp;
                }
            }
            x.DropDownWidth = sirka;
        }
        public void FillSemestrLB(ListBox x, int izaz, int sem, out Kredity kr, out List<Predmet> predmets)
        {
            x.DataSource = null;
            x.Items.Clear();
            kr = new Kredity();
            List<Predmet> tmp = new List<Predmet>();
            da.CheckExistVyber(sem, izaz, out int Exist);
            if (Exist > 0)
                try
                {
                    tmp = da.GetPredmetZVyberu(sem, izaz);
                    foreach (Predmet n in tmp)
                    {
                        x.Items.Add(n);
                        kr.Suma += n.Kredit_predmet;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Properties.Resources.Chyba_TITLE + ": " + ex);
                }
            else
                tmp = null;
            predmets = tmp;
        }
        public void FillOborDetail(ComboBox cb, VypisObor v)
        {
            try
            {
                Obor o = (Obor)cb.SelectedItem;
                DataAccess da = new DataAccess();
                v.Zkr = o.Zkr_obor;
                v.Rok = o.Rok_obor;
                v.P = o.P_obor.ToString();
                v.Pv = o.Pv_obor.ToString();
                v.V = o.V_obor.ToString();
                v.Vs = o.Vs_obor.ToString();
                v.Praxe = o.Praxe;
                v.Zaver = o.Zaver;
            }
            catch { }
        }
        public void FillGarantDetail(ComboBox cb, VypisGarant v)
        {
            try
            {
                Garant g = (Garant)cb.SelectedItem;
                DataAccess da = new DataAccess();
                v.Konzultace = g.Konz_v;
                v.Telefon = g.Tel_v;
                v.Email = g.Email_V;
                v.Katedra = da.GetKatedraById(g.Id_k);
                v.NaplnComboV(da.GetPredmetByGarant(g));
            }
            catch { }
        }
        public void FillGarantDetail(ListBox LB, VypisGarant v)
        {
            try
            {
                Predmet x = (Predmet)LB.SelectedItem;
                DataAccess da = new DataAccess();
                Garant g = da.GetFullGarantById(x.Id_v);
                v.Konzultace = g.Konz_v;
                v.Katedra = da.GetKatedraById(g.Id_k);
                v.Email = g.Email_V;
                v.Telefon = g.Tel_v;
                v.NaplnComboV(da.GetPredmetByGarant(g));
            }
            catch { }
        }
        public void FillDetail(ListBox LB, VypisPopisPredmet v)
        {
            try
            {
                Predmet x = (Predmet)LB.SelectedItem;
                DataAccess da = new DataAccess();
                if (x.Prerekvizita <= 0)
                    v.Prerekvizita = "Není";
                else
                    v.Prerekvizita = da.GetPredmetById(x.Prerekvizita);
                v.Popis = x.Popis;
                v.Kredit = x.Kredit_predmet.ToString();
                v.Povinnost = x.Povinnost;
                v.Zkr = x.Zkr_predmet;
                v.Zakončení = x.Zakonceni;
                v.Jazyk = x.Jazyk;
                v.Prednaska = x.Prednaska.ToString();
                v.Cviceni = x.Cviceni.ToString();
                v.Kombi = x.Kombi.ToString();
                v.Lab = x.Lab.ToString();
                v.Semestr = x.Semestr_predmet.ToString();
                v.Garant = da.GetGarantById(x.Id_v);
            }
            catch { }
        }
        public void FillDetail(ComboBox cb, VypisPopisPredmet v)
        {
            try
            {
                Predmet x = (Predmet)cb.SelectedItem;
                DataAccess da = new DataAccess();
                if (x.Prerekvizita <= 0)
                    v.Prerekvizita = "Není";
                else
                    v.Prerekvizita = da.GetPredmetById(x.Prerekvizita);
                v.Popis = x.Popis;
                v.Kredit = x.Kredit_predmet.ToString();
                v.Povinnost = x.Povinnost;
                v.Zkr = x.Zkr_predmet;
                v.Zakončení = x.Zakonceni;
                v.Jazyk = x.Jazyk;
                v.Prednaska = x.Prednaska.ToString();
                v.Cviceni = x.Cviceni.ToString();
                v.Kombi = x.Kombi.ToString();
                v.Lab = x.Lab.ToString();
                v.Garant = da.GetGarantById(x.Id_v);
                v.Semestr = x.Semestr_predmet.ToString();

            }
            catch { }
        }
        public void FillDetail(ListBox LB, VypisPopisPredmet v, List<Predmet> lp)
        //nepoužívaná metoda
        {
            try
            {
                foreach (Predmet x in lp)
                {
                    if (LB.SelectedItem == (object)x.ToString())
                    {
                        DataAccess da = new DataAccess();
                        if (x.Prerekvizita <= 0)
                            v.Prerekvizita = "Není";
                        else
                            v.Prerekvizita = da.GetPredmetById(x.Prerekvizita);
                        v.Popis = x.Popis;
                        v.Semestr = x.Semestr_predmet.ToString();
                        v.Kredit = x.Kredit_predmet.ToString();
                        v.Povinnost = x.Povinnost;
                        v.Zkr = x.Zkr_predmet;
                        v.Zakončení = x.Zakonceni;
                        v.Jazyk = x.Jazyk;
                        v.Prednaska = x.Prednaska.ToString();
                        v.Cviceni = x.Cviceni.ToString();
                        v.Kombi = x.Kombi.ToString();
                        v.Lab = x.Lab.ToString();
                        v.Garant = da.GetGarantById(x.Id_v);
                    }
                }
            }
            catch { }
        }
        public static void FillDetail(VypisPopisPredmet v, Predmet x)
        {
            DataAccess da = new DataAccess();
            if (x.Prerekvizita <= 0)
                v.Prerekvizita = "Není";
            else
                v.Prerekvizita = da.GetPredmetById(x.Prerekvizita);
            v.Popis = x.Popis;
            v.Semestr = x.Semestr_predmet.ToString();
            v.Kredit = x.Kredit_predmet.ToString();
            v.Povinnost = x.Povinnost;
            v.Zkr = x.Zkr_predmet;
            v.Zakončení = x.Zakonceni;
            v.Jazyk = x.Jazyk;
            v.Prednaska = x.Prednaska.ToString();
            v.Cviceni = x.Cviceni.ToString();
            v.Kombi = x.Kombi.ToString();
            v.Lab = x.Lab.ToString();
            v.Garant = da.GetGarantById(x.Id_v);
        }
        public static void FillOborDetail(Obor o, VypisObor v)
        {
            v.Zkr = o.Zkr_obor;
            v.Rok = o.Rok_obor;
            v.P = o.P_obor.ToString();
            v.Pv = o.Pv_obor.ToString();
            v.V = o.V_obor.ToString();
            v.Vs = o.Vs_obor.ToString();
            v.Praxe = o.Praxe;
            v.Zaver = o.Zaver;
        }
        public static void FillGarantDetail(Garant g, VypisGarant v)
        {
            DataAccess da = new DataAccess();
            v.Konzultace = g.Konz_v;
            v.Telefon = g.Tel_v;
            v.Email = g.Email_V;
            v.Katedra = da.GetKatedraById(g.Id_k);
        }
        public static void ClearDetail(VypisPopisPredmet v)
        {
            v.Prerekvizita = v.Popis = v.Semestr = v.Kredit =
            v.Povinnost = v.Zkr = v.Zakončení = v.Jazyk =
            v.Prednaska = v.Cviceni = v.Kombi = v.Lab = v.Garant = "";
        }
        public static void ClearOborDetail(VypisObor v)
        {
            v.Rok = v.Zkr = v.P = v.Pv = v.V = v.Vs = v.Praxe = v.Zaver = "";
        }
        public static void ClearGarantDetail(VypisGarant v)
        {
            v.Konzultace = v.Telefon = v.Email = v.Katedra = "";
        }
        public void VypoctiPovinnostiKredity(List<Predmet> collection, Kredity kr)
        {
            try
            {
                foreach (Predmet n in collection)
                {
                    switch (n.Povinnost)
                    {
                        case "Povinný předmět":
                        case "Cizí jazyk": kr.Povinne += n.Kredit_predmet; break;
                        case "Povinně volitelný": kr.PVolitelny += n.Kredit_predmet; break;
                        case "Volitelný předmět": kr.Volitelny += n.Kredit_predmet; break;
                        case "Volitelný předmět (sportovní aktivita)": kr.Sport += n.Kredit_predmet; break;
                        default: break;
                    }
                }
            }
            catch { }
        }
        public void VratHodnotuPoSmazani(Predmet n, NumericUpDown NUDP, NumericUpDown NUDPV, NumericUpDown NUDV, NumericUpDown celkem, int id_o)
        {
            switch (n.Povinnost)
            {
                case "Povinný předmět":
                case "Cizí jazyk":
                    NUDP.Value -= n.Kredit_predmet;
                    break;
                case "Volitelný předmět":
                case "Volitelný předmět (sportovní aktivita)":
                    NUDV.Value -= n.Kredit_predmet;
                    break;
                case "Povinně volitelný":
                    NUDPV.Value -= n.Kredit_predmet;
                    break;
                default:
                    break;
            }
            DataAccess da = new DataAccess();
            Obor obor = da.GetOborById(id_o);
            celkem.Value = (NUDP.Value + NUDPV.Value + NUDV.Value);
            NUDP.BackColor = obor.P_obor <= NUDP.Value ? Color.LightGreen : Color.LightCoral;
            NUDPV.BackColor = obor.Pv_obor <= NUDPV.Value ? Color.LightGreen : Color.LightCoral;
            NUDV.BackColor = obor.V_obor <= NUDV.Value ? Color.LightGreen : Color.LightCoral;
            celkem.BackColor = 180 <= celkem.Value ? Color.LightGreen : Color.LightCoral;
        }
        public void NaplnNUDyPovinn(NumericUpDown NUDP, NumericUpDown NUDPV, NumericUpDown NUDV, Kredity kredity, Obor obor)
        //vložit kontrolu podle oboru a požadavků
        {
            NUDP.Value = kredity.Povinne;
            NUDPV.Value = kredity.PVolitelny;
            decimal temp = (kredity.Volitelny + kredity.Sport);
            NUDV.Value = temp;
            NUDP.BackColor = obor.P_obor <= kredity.Povinne ? Color.LightGreen : Color.LightCoral;
            NUDPV.BackColor = obor.Pv_obor <= kredity.PVolitelny ? Color.LightGreen : Color.LightCoral;
            NUDV.BackColor = obor.V_obor <= temp ? Color.LightGreen : Color.LightCoral;
            if (kredity.Suma >= 180)
                if (kredity.Sport > obor.Vs_obor && kredity.Volitelny < (obor.V_obor / 2))
                    MessageBox.Show(Properties.Resources.MocSportu);
        }
        public void NastavIndexCombo<T>(ComboBox x, /*List<T> t,*/ string z)
        {
            x.SelectedIndex = x.FindString(z);
        }
        public void NastavIndexCombo<T>(ComboBox x, List<T> t, int z)
        {
            foreach (T k in t)
                if (Convert.ToInt32(k) == z)
                    x.SelectedIndex = x.FindString(k.ToString());
        }

        public void NovyZaznam(Zaznam zaz, int mazat = 0)
        {
            try
            {
                DataCrud x = new DataCrud();
                if (mazat == 1)
                    x.DeleteZaznam(zaz.Id_zaznam);//smazání starého
                x.InsertZaznam(zaz);//založení nového
                for (int i = 1; i <= zaz.PocetSem; i++)
                    x.InsertPS(zaz.Zkr_zaznam, i);
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

        public void NaplnComboBoxDetailGarant(ComboBox cb, List<Predmet> li)
        {
            //vyčištění dat v comboboxu
            cb.DataSource = null;
            cb.Items.Clear();
            //pro každou položku v listu se přidá jako item 
            try
            {
                foreach (Predmet temp in li)
                    cb.Items.Add(temp.GetNazOb());
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.Resources.Chyba_TITLE + ": " + ex);
            }
        }
    }
}