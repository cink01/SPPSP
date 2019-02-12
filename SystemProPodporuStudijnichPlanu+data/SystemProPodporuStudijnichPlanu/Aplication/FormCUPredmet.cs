using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCUPredmet : Form
    {
        public List<Obor> obors = new List<Obor>();
        public List<Garant> garants = new List<Garant>();
        public StringComparison Comp { get; set; } = StringComparison.OrdinalIgnoreCase;
        public FormCUPredmet()
        {
            InitializeComponent();
        }
        private void FormCUPredmet_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            obors = da.GetFullObor();
            garants = da.GetFullGarant();
            da.FillCbGarantFList(cb_garant, garants);
            da.FillCbOborFList(cb_obor, obors);
        }
        public string Nazev
        {
            get => tb_nazev.Text;
            set => tb_nazev.Text = value;
        }
        public string Id
        {
            get => tb_id.Text;
            set => tb_id.Text = value;
        }
        public string Zkr
        {
            get => tb_zkr.Text;
            set => tb_zkr.Text = value;
        }
        public string Orig
        {
            get => tb_orig.Text;
            set => tb_orig.Text = value;
        }
        public string Popis
        {
            get => rtb_popis.Text;
            set => rtb_popis.Text = value;
        }
        public string Kredit
        {
            get => nud_kredit.Value.ToString();
            set => nud_kredit.Value = Convert.ToDecimal(value);
        }
        public string Jazyk
        {
            get => tb_jazyk.Text;
            set => tb_jazyk.Text = value;
        }
        public string Semestr
        {
            get => nud_semestr.Value.ToString();
            set => nud_semestr.Value = Convert.ToDecimal(value);
        }
        public string Prednaska
        {
            get => nud_p.Value.ToString();
            set => nud_p.Value = Convert.ToDecimal(value);
        }
        public string Cv 
        {
            get => nud_cv.Value.ToString();
            set => nud_cv.Value = Convert.ToDecimal(value);
        }
        public string Cvk
        {
            get => nud_cvk.Value.ToString();
            set => nud_cvk.Value = Convert.ToDecimal(value);
        }
        public string Lab 
        {
            get => nud_lab.Value.ToString();
            set => nud_lab.Value = Convert.ToDecimal(value);
        }
        public string Zakonceni
        {
            get => cb_zakončení.GetItemText(cb_zakončení.SelectedItem);
            set => cb_zakončení.SelectedIndex = cb_zakončení.FindStringExact(value);
        }
        public string Povinnost 
        {
            get => cb_povinnost.GetItemText(cb_povinnost.SelectedItem);
            set => cb_povinnost.SelectedIndex = cb_povinnost.FindStringExact(value);
        }
        public string Obor 
        {
            get
            {
                DataRowView DV = cb_obor.SelectedItem as DataRowView;
                return DV.Row["rok_obor"].ToString();
            }
            set => cb_obor.SelectedIndex = cb_obor.FindStringExact(value);
        }
        public string Garant
        {
            get
            {
                DataRowView DV = cb_garant.SelectedItem as DataRowView;
                return DV.Row["jmeno_v"].ToString();
            }
            set => cb_garant.SelectedIndex = cb_garant.FindStringExact(value);
        }
        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Cb_garant_Hledání(object sender, EventArgs e)
        {
            cb_garant.Items.Clear();
            foreach (Garant g in garants)
            {
                if (g.Jmeno_v.IndexOf(cb_garant.Text, Comp) >= 0)
                {
                    cb_garant.Items.Add(g.Jmeno_v);
                }
            }
        }
        private void Cb_obor_Hledání(object sender, EventArgs e)
        {
            cb_obor.Items.Clear();
            foreach (Obor o in obors)
            {
                if (o.Name_obor.IndexOf(cb_obor.Text, Comp) >= 0)
                {
                    cb_obor.Items.Add(o.Name_obor);
                }
            }
        }

        private void Cb_povinnost_Hledaní(object sender, EventArgs e)
        {

        }


    }
}
/* 
 private void HledaniTextuvCb<T>(ComboBox c,List<T> l)
 {
     c.Items.Clear();
     //chb_exist.Checked = false;
     foreach (T o in l)
     {
         if (o.Name_obor.IndexOf(c.Text, Comp) >= 0)
         {
             cb_obor.Items.Add(o.Name_obor);
             //  chb_exist.Checked = true;
         }
     }
  }
*/