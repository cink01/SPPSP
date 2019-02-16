using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCUZaznam : Form
    {
        public Zaznam Zaz
        {
            get
            {
                return new Zaznam(Id, Zkr, Obor, Semestr);
            }
        }
        public List<Obor> obors = new List<Obor>();
        public bool Schov { get; set; }
        public int Id
        {
            get
            {
                try
                {
                    return Convert.ToInt32(tb_id.Text);
                }
                catch (Exception)
                {
                    return -1;
                }

            }
            set => tb_id.Text = value.ToString();
        }
        public int Semestr
        {
            get => (int)nud_semestr.Value;
            set => nud_semestr.Value = Convert.ToDecimal(value);
        }
        public string Zkr
        {
            get => tb_zkr.Text;
            set => tb_zkr.Text = value;
        }
        public int Obor
        {
            get
            {
                Obor k = (Obor)cmb_obor.SelectedItem;
                return k.Id_obor;
            }
            set
            {
                foreach (Obor k in obors)
                    if (k.Id_obor == value)
                        cmb_obor.SelectedIndex = cmb_obor.FindStringExact(k.ToString());
            }
        }
        public FormCUZaznam()
        {
            if (Schov == true)
            {
                l_id.Visible = false;
                tb_id.Visible = false;
            }
            DataAccess da = new DataAccess();
            Filling fill = new Filling();
            InitializeComponent();
            obors = da.GetFullObor();
            obors.RemoveAt(0);
            fill.NaplnComboBox<Obor>(cmb_obor, obors);
        }
        private void FormCUZaznam_Load(object sender, EventArgs e)
        {
            if (Schov == true)
            {
                l_id.Visible = false;
                tb_id.Visible = false;
            }

        }
        private void Cmb_obor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tb_id.Text != "") && (this.Text == "Upravit záznam"))
            {
                bt_info.Visible = true;
            }
        }
        private void Bt_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Změna oboru povede k smazání zadaných předmětů v semestrech.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Cmb_obor_DropDown(object sender, EventArgs e)
        {
           /* Filling fill = new Filling();
            fill.NajdiVComboBoxu<Obor>(cmb_obor, obors);*/
        }
    }
}