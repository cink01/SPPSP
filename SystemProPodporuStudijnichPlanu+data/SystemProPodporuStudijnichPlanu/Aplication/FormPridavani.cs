using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public FormPridavani()
        {
            InitializeComponent();
        }
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
        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Lb_vypis_SelectedIndexChanged(object sender, EventArgs e)//predelat podle videa a nejspis vyuzit tlacitka a v selectu urobit popis na kazdou stranu na popis urobit funkci a tu vyuzivat tady i ve formMain
        {
            Filling fill = new Filling();
            fill.FillDetail(lb_vypis, vypisPopisPredmet, predmetySeznam);
        }
        private void Lb_chci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Bt_add_Click(object sender, EventArgs e)
        {
            try
            {
              /*  Predmet temp = (Predmet)lb_vypis.SelectedItem;
                var moveables = predmetySeznam.Where(x => x.ToString() == temp.ToString());
                predmetyAdd.AddRange(moveables);
                predmetySeznam = predmetySeznam.Except(predmetyAdd).ToList();*/
                  foreach (Predmet n in predmetySeznam)
                  {
                      if ((object)lb_vypis.SelectedItem == (object)(n.ToString()))
                      {
                          var moveables = predmetySeznam.Where(x => x.Name_predmet == n.Name_predmet);
                          predmetyAdd.AddRange(moveables);
                          predmetySeznam = predmetySeznam.Except(predmetyAdd).ToList();
                      }
                  }
                RefreshSeznam(); RefreshAdd();
            }
            catch { }
        }
        private void Bt_rem_Click(object sender, EventArgs e)
        {
            try
            {
            /*    Predmet temp = (Predmet)lb_chci.SelectedItem;
                var moveables = predmetyAdd.Where(x => x.ToString() == temp.ToString());
                predmetySeznam.AddRange(moveables);
                predmetyAdd = predmetyAdd.Except(predmetySeznam).ToList();*/
                  foreach (Predmet n in predmetyAdd)
                  {
                      if ((object)lb_chci.SelectedItem == (object)(n.Name_predmet))
                      {
                          var moveables = predmetyAdd.Where(x => x.Name_predmet == n.Name_predmet);
                          predmetySeznam.AddRange(moveables);
                          predmetyAdd = predmetyAdd.Except(predmetySeznam).ToList();
                      }
                  }
                RefreshSeznam(); RefreshAdd();
            }
            catch { }
        }
    }
}
