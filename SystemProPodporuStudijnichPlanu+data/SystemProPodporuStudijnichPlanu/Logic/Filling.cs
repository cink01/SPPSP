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
        public void NaplnComboBox<T>(ComboBox cb, List<T> li)
        {
            cb.DataSource = null;
            cb.Items.Clear();
            try
            {
                foreach (T temp in li)
                    cb.Items.Add(temp);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba" + ex);
            }
        }
        public void NajdiVComboBoxu<T>(ComboBox x, List<T> temp)
        {
            x.Items.Clear();
            int sirka = 1;
            foreach (T o in temp)
            {
                if (o.ToString().IndexOf(x.Text, Comp) >= 0)
                {
                    x.Items.Add(o);
                    int tmp = TextRenderer.MeasureText(o.ToString(), x.Font).Width;
                    if (sirka < tmp)
                        sirka = tmp;
                }
            }
            x.DropDownWidth = sirka;
        }
        public void FillSemestrLB(ListBox x, int izaz, int sem, out Kredity kr, out List<Predmet> predmets)
        //misto sum udelat prepravku pro nekolik promennych
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
                    MessageBox.Show("Chyba" + ex);
                }
            else
                tmp = null;
            predmets = tmp;
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
        {
            try
            {
                foreach (Predmet x in lp)
                {
                    if ((object)LB.SelectedItem == (object)(x.ToString()))
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
        public void VypoctiPovinnostiKredity(List<Predmet> collection, Kredity kr)
        {
            try
            {
                foreach (Predmet n in collection)
                {
                    if (n.Povinnost == "\"Povinný předmět\"" || n.Povinnost == "\"Cizí jazyk\"")
                    {
                        kr.Povinne += n.Kredit_predmet;
                        continue;
                    }
                    if (n.Povinnost == "\"Volitelný předmět\"")
                    {
                        kr.Volitelny += n.Kredit_predmet;
                        continue;
                    }
                    if (n.Povinnost == "\"Povinně volitelný\"")
                    {
                        kr.PVolitelny += n.Kredit_predmet;
                        continue;
                    }
                    if (n.Povinnost == "\"Volitelný předmět (sportovní aktivita)\"")
                    {
                        kr.Sport += n.Kredit_predmet;
                        continue;
                    }
                }
            }
            catch { }
        }
        public void VratHodnotuPoSmazani(Predmet n, NumericUpDown NUDP, NumericUpDown NUDPV, NumericUpDown NUDV, NumericUpDown celkem, int id_o)
        {
            switch (n.Povinnost)
            {
                case "\"Povinný předmět\"":
                case "\"Cizí jazyk\"":
                    NUDP.Value -= n.Kredit_predmet;
                    break;
                case "\"Volitelný předmět\"":
                case "\"Volitelný předmět (sportovní aktivita)\"":
                    NUDV.Value -= n.Kredit_predmet;
                    break;
                case "\"Povinně volitelný\"":
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
                    MessageBox.Show("Máte zapsáno více sportů a počet volitelných není dostatečný");
        }
    }
}