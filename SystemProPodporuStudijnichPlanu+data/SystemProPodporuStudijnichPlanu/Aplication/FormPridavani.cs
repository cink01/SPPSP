﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu
{
    public partial class FormPridavani : Form
    {
        List<Predmet> predmetySeznam = new List<Predmet>();
        List<Predmet> predmetyAdd = new List<Predmet>();
        public List<Predmet> PredmetySeznam
        {
            set => this.predmetySeznam = value;
            get => predmetySeznam;
        }
        public List<Predmet> PredmetyAdd
        {
            set => this.predmetyAdd = value;
            get => predmetyAdd;
        }
        public FormPridavani()
        {
            InitializeComponent();
        }
        public void RefreshAdd()
        {
            lb_chci.DataSource = null;
            lb_chci.Items.Clear();
            foreach (Predmet n in predmetyAdd)
            {
                lb_chci.Items.Add(n.FullInfo);
            }
        }
        public void RefreshSeznam()
        {
            lb_vypis.DataSource = null;
            lb_vypis.Items.Clear();
            foreach (Predmet n in predmetySeznam)
            {
                lb_vypis.Items.Add(n.FullInfo);
            }
        }
        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lb_vypis_SelectedIndexChanged(object sender, EventArgs e)//predelat podle videa a nejspis vyuzit tlacitka a v selectu urobit popis na kazdou stranu na popis urobit funkci a tu vyuzivat tady i ve formMain
        {
            try
            {
                foreach (Predmet n in predmetySeznam)
                {
                    if ((object)lb_vypis.SelectedItem == (object)(n.FullInfo))
                    {
                        Predmet x = new Predmet(n.Id_predmet,n.Name_predmet,n.Zkr_predmet,n.Kredit_predmet,n.Id_obor,n.Id_v,n.Semestr_predmet,n.Id_orig,n.Povinnost,n.Prednaska,n.Cviceni,n.Kombi,n.Lab,n.Jazyk,n.Zakonceni,n.Popis);
                        predmetyAdd.Add(x);
                        predmetySeznam.Remove(x);
                        //lb_vypis.Items.Remove(lb_vypis.SelectedItem);
                    }
                }
            }
            catch { }
            RefreshSeznam(); RefreshAdd();
        }

        private void Lb_chci_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Predmet n in predmetyAdd)
                {
                    if ((object)lb_chci.SelectedItem == (object)(n.FullInfo))
                    {
                        Predmet x = new Predmet(n.Id_predmet, n.Name_predmet, n.Zkr_predmet, n.Kredit_predmet, n.Id_obor, n.Id_v, n.Semestr_predmet, n.Id_orig, n.Povinnost, n.Prednaska, n.Cviceni, n.Kombi, n.Lab, n.Jazyk, n.Zakonceni, n.Popis);
                        predmetySeznam.Add(x);
                        predmetyAdd.Remove(x);
                        //lb_chci.Items.Remove(lb_chci.SelectedItem );

                    }
                }
            }
            catch { }
            RefreshSeznam(); RefreshAdd();
        }
    }
}
