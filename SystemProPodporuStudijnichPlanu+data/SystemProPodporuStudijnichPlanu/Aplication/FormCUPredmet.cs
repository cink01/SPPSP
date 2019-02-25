using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCUPredmet : Form
    {
        public List<Obor> obors = new List<Obor>();
        public List<Garant> garants = new List<Garant>();
        public List<Predmet> predmets = new List<Predmet>();
        public FormCUPredmet()
        {
            Filling fill = new Filling();
            InitializeComponent();
            DataAccess da = new DataAccess();
            obors = da.GetFullObor();
            garants = da.GetFullGarant();
            predmets = da.GetFullPredmet();
            fill.NaplnComboBox<Garant>(cb_garant, garants);
            fill.NaplnComboBox<Obor>(cb_obor, obors);
            fill.NaplnComboBox<Predmet>(cb_prerek, predmets);
        }
        private void FormCUPredmet_Load(object sender, EventArgs e) { }
        public Predmet P
        {
            get => new Predmet(Id, Nazev, Zkr, Kredit, Obor, Garant, Semestr, Orig, Povinnost, Prednaska, Cv, Cvk, Lab, Jazyk, Zakonceni, Popis, Prerek);
        }
        public string Nazev
        {
            get => tb_nazev.Text;
            set => tb_nazev.Text = value;
        }
        public int Id
        {
            get
            {
                if (tb_id.Text == "")
                    return -1;
                else
                    return Convert.ToInt32(tb_id.Text);
            }
            set => tb_id.Text = value.ToString();
        }
        public string Zkr
        {
            get => tb_zkr.Text;
            set => tb_zkr.Text = value;
        }
        public int Orig
        {
            get => Convert.ToInt32(tb_orig.Text);
            set => tb_orig.Text = value.ToString();
        }
        public string Popis
        {
            get => rtb_popis.Text;
            set => rtb_popis.Text = value;
        }
        public int Kredit
        {
            get => Convert.ToInt32(nud_kredit.Value);
            set => nud_kredit.Value = Convert.ToDecimal(value);
        }
        public string Jazyk
        {
            get => tb_jazyk.Text;
            set => tb_jazyk.Text = value;
        }
        public int Semestr
        {
            get => Convert.ToInt32(nud_semestr.Value);
            set => nud_semestr.Value = Convert.ToDecimal(value);
        }
        public int Prednaska
        {
            get => Convert.ToInt32(nud_p.Value);
            set => nud_p.Value = Convert.ToDecimal(value);
        }
        public int Cv
        {
            get => Convert.ToInt32(nud_cv.Value);
            set => nud_cv.Value = Convert.ToDecimal(value);
        }
        public int Cvk
        {
            get => Convert.ToInt32(nud_cvk.Value);
            set => nud_cvk.Value = Convert.ToDecimal(value);
        }
        public int Lab
        {
            get => Convert.ToInt32(nud_lab.Value);
            set => nud_lab.Value = Convert.ToDecimal(value);
        }
        public string Zakonceni
        {
            get
            {
                if ("Zápočet" == cb_zakončení.GetItemText(cb_zakončení.SelectedItem))
                    return "ZA";
                else
                    return "ZK";

            }
            set
            {
                if (value == "ZA")
                    cb_zakončení.SelectedIndex = cb_zakončení.FindString("Zápočet");
                else
                    cb_zakončení.SelectedIndex = cb_zakončení.FindString("Zkouška");
            }
        }
        public string Povinnost
        {
            get => cb_povinnost.GetItemText(cb_povinnost.SelectedItem);
            set => cb_povinnost.SelectedIndex = cb_povinnost.FindString(value);
        }
        public int Obor
        {
            get
            {
                Obor k = (Obor)cb_obor.SelectedItem;
                return k.Id_obor;
            }
            set
            {
                //           fill.NastavIndexCombo<Obor>(cb_obor, obors, value);
                foreach (Obor k in obors)
                    if (k.Id_obor == value)
                        cb_obor.SelectedIndex = cb_obor.FindStringExact(k.ToString());
            }
        }
        public int Garant
        {
            get
            {
                Garant k = (Garant)cb_garant.SelectedItem;
                return k.Id_v;
            }

            set
            {
                foreach (Garant k in garants)
                    if (k.Id_v == value)
                        cb_garant.SelectedIndex = cb_garant.FindStringExact(k.ToString());
            }
        }
        public int Prerek
        {
            get
            {
                if (cb_prerek.SelectedIndex != -1)
                {
                    Predmet k = (Predmet)cb_prerek.SelectedItem;
                    return k.Id_predmet;
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                if (value != -1)
                {
                    foreach (Predmet k in predmets)
                        if (k.Id_predmet == value)
                            cb_prerek.SelectedItem = cb_prerek.FindString(k.ToString());
                }
            }
        }
        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Cb_garant_Hledání(object sender, EventArgs e)
        {
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Garant>(cb_garant, garants);
        }
        private void Cb_obor_Hledání(object sender, EventArgs e)
        {
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Obor>(cb_obor, obors);
        }
        private void Cb_povinnost_Hledaní(object sender, EventArgs e)
        {
        }
        private void Cb_prerek_Hledani(object sender, EventArgs e)
        {
            Filling fill = new Filling();
            fill.NajdiVComboBoxu<Predmet>(cb_prerek, predmets);
        }
        private void Cb_obor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            foreach (Obor o in obors)
                if (o.Name_obor == cb_obor.SelectedItem.ToString())
                    predmets = da.GetPredmetFullByObor(o.Id_obor);
        }
        private void Bt_ok_Click(object sender, EventArgs e)
        {
            if(tb_nazev.Text==""||tb_zkr.Text==""||cb_garant.SelectedIndex==-1||cb_obor.SelectedIndex==-1||cb_povinnost.SelectedIndex==-1||cb_zakončení.SelectedIndex==-1||tb_orig.Text==""||tb_jazyk.Text=="")
                MessageBox.Show("Všechny údaje musí být vyplněny, aby se zajistilo bezpečné uložení", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.DialogResult = DialogResult.OK;
        }
    }
}