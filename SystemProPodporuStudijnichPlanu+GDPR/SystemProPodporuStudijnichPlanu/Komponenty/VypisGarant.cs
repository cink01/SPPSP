using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using SystemProPodporuStudijnichPlanu.Logic;
using System;

namespace SystemProPodporuStudijnichPlanu.Komponenty
{
    public partial class VypisGarant : UserControl
    {
        public VypisGarant()
        {
            InitializeComponent();
        }
        public Garant G { get; set; }
        public void NaplnComboV(List<Predmet> p,string naz="")//upravit plneni comboboxu tak, aby nevracel stejne zaznamy
        {
            Filling f = new Filling();
            f.NaplnComboBoxDetailGarant(cmb_garantuje, p);
            cmb_garantuje.Text = naz;
        }
        public string Konzultace
        {
            get => tb_konz.Text;
            set => tb_konz.Text = value;
        }
        public string Katedra
        {
            get => tb_kat.Text;
            set => tb_kat.Text = value;
        }
        public string Telefon
        {
            get => tb_tel.Text;
            set => tb_tel.Text = value;
        }
        public string Email
        {
            get => tb_email.Text;
            set => tb_email.Text = value;
        }
    }
}