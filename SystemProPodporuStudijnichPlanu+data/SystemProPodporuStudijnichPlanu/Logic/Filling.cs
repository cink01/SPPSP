using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        public void FillSemestrLB(ListBox x, int izaz, int sem, out decimal sum, out List<Predmet> predmets)
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
            sum = kr.Suma;
        }
        public void GetDetail(ListBox LB,/* List<Predmet> p,*/ out string popis, out decimal kredity, out string povin, out decimal idcko)
        {
            idcko = kredity = 0;
            povin = popis = "";
            try
            {
                Predmet x = (Predmet)LB.SelectedItem;
                popis = x.Popis;
                kredity = x.Kredit_predmet;
                povin = x.Povinnost;
                idcko = x.Id_predmet;
            }
            catch{}
            /* foreach (Predmet x in p)
                 if ((object)x == (object)LB.SelectedItem)
                 {
                     popis = x.Popis;
                     kredity = x.Kredit_predmet;
                     povin = x.Povinnost;
                     idcko = x.Id_predmet;
                 }*/
        }
    }
}