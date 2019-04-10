using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;

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
        public bool Lichy
        {
            set
            {
                if (value == true)
                {
                    cmb_semestr.Items.Remove("2");
                    cmb_semestr.Items.Remove("4");
                    cmb_semestr.Items.Remove("6");
                }
                else
                {
                    cmb_semestr.Items.Remove("1");
                    cmb_semestr.Items.Remove("3");
                    cmb_semestr.Items.Remove("5");
                }
                cmb_semestr.SelectedIndex = cmb_semestr.FindStringExact("Všechny");
            }
        }
        public FormPridavani()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }
        private void Bt_close_Click(object sender, EventArgs e) => Close();
        private void Lb_vypis_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filling fill = new Filling();
            fill.FillDetail(lb_vypis, vypisPopisPredmet, predmetySeznam);
        }
        private void Lb_vypis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                bt_add.PerformClick();
        }

        private void Lb_chci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                bt_rem.PerformClick();
        }
        private void Bt_ok_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;
        private void Cb_semestry_SelectedIndexChanged(object sender, EventArgs e) => RefreshR();
        public void RefreshAdd()
        {
            lb_chci.DataSource = null;
            lb_chci.Items.Clear();
            decimal sum = 0;
            foreach (Predmet n in predmetyAdd)
            {
                sum += n.Kredit_predmet;
                lb_chci.Items.Add(n.ToString());
            }
            nud_kredity.Value = sum;
        }
        public void RefreshSeznam()
        {
            lb_vypis.DataSource = null;
            lb_vypis.Items.Clear();
            foreach (Predmet n in predmetySeznam)
            {
                lb_vypis.Items.Add(n.ToString());
            }
        }
        private void RefreshR()
        {
            string vyber = cmb_semestr.SelectedItem.ToString();
            int semestr;
            if (vyber != "Všechny")
            {
                try
                {
                    semestr = Convert.ToInt32(vyber);
                }
                catch
                {
                    semestr = 0;
                }
                lb_vypis.DataSource = null;
                lb_vypis.Items.Clear();
                foreach (Predmet p in predmetySeznam)
                {
                    if (p.Semestr_predmet == semestr)
                    {
                        lb_vypis.Items.Add(p.ToString());
                    }
                }
                return;
            }
            else
                RefreshSeznam();
        }
        private void Bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Predmet n in predmetySeznam)
                {
                    if ((object)lb_vypis.SelectedItem == (object)(n.ToString()))
                    {
                        var moveables = predmetySeznam.Where(x => x.Name_predmet == n.Name_predmet);
                        predmetyAdd.AddRange(moveables);
                        predmetySeznam = predmetySeznam.Except(predmetyAdd).ToList();
                    }
                }
                RefreshR(); RefreshAdd();
            }
            catch { }
        }
        private void Bt_rem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Predmet n in predmetyAdd)
                {
                    if ((object)lb_chci.SelectedItem == (object)(n.Name_predmet))
                    {
                        var moveables = predmetyAdd.Where(x => x.Name_predmet == n.Name_predmet);
                        predmetySeznam.AddRange(moveables);
                        predmetyAdd = predmetyAdd.Except(predmetySeznam).ToList();
                    }
                }
                RefreshR(); RefreshAdd();
            }
            catch { }
        }
    }
}