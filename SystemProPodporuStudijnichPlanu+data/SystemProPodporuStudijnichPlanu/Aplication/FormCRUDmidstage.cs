using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCRUDmidstage : Form
    {
        public FormCRUDmidstage()
        {
            InitializeComponent();
        }

        private void Bt_novy_Click(object sender, EventArgs e)
        {
            if (rb_garant.Checked == true)
            {
                FormCUGarant g = new FormCUGarant();
                g.Show();
            }
            if (rb_predmet.Checked == true)
            {
                FormCUPredmet p = new FormCUPredmet();
                p.Show();
            }
            if (rb_obor.Checked == true)
            {
                FormCUObor o = new FormCUObor();
                o.Show();
            }
            if (rb_katedra.Checked == true)
            {
                FormCUKatedra k = new FormCUKatedra();
                k.Show();
            }
        }

        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
