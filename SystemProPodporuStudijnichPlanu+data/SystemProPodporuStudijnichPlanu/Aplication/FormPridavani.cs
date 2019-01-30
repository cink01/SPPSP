using System;
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
    }
}
