using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCUZaznam : Form
    {
        public Zaznam Zaz
        {
            get =>new Zaznam(Id, Zkr, Obor, Semestr);
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
            this.BackColor = Color.White;
            errorProvider_Zaznam_zkratka.SetIconAlignment(tb_zkr, ErrorIconAlignment.MiddleRight);
            errorProvider_Zaznam_zkratka.SetIconPadding(tb_zkr, 2);
            errorProvider_Zaznam_zkratka.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            errorProvider_Zaznam_obor.SetIconAlignment(cmb_obor, ErrorIconAlignment.MiddleRight);
            errorProvider_Zaznam_obor.SetIconPadding(cmb_obor, 2);
            errorProvider_Zaznam_obor.BlinkStyle = ErrorBlinkStyle.NeverBlink;
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
            Filling f = new Filling();
            f.FillOborDetail(cmb_obor, VypisObor_Zaznam);
        }
        private void Bt_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.ZmenaOboru_WAR_MESSAGE, 
                            Properties.Resources.Upozorneni_TITLE, 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Cmb_obor_DropDown(object sender, EventArgs e)
        {
            /* Filling f = new Filling();
             f.DynSirka<Obor>(cmb_obor, obors);*/
        }
        private void Tb_zkr_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider_Zaznam_zkratka.Clear();
            if (tb_zkr.Text.Length == 0)
            {
                errorProvider_Zaznam_zkratka.SetError(tb_zkr, "Označení je vyžadováno.");
                e.Cancel = true;
            }
        }
        private void Cmb_obor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider_Zaznam_obor.Clear();
            if (cmb_obor.SelectedIndex == -1)
            {
                errorProvider_Zaznam_obor.SetError(cmb_obor, "Musí být vybrán obor.");
                e.Cancel = true;
            }
        }
        private void Bt_ok_Click(object sender, EventArgs e)
        {
            if (tb_zkr.Text != "" && cmb_obor.SelectedIndex != -1)
            {
                this.DialogResult = DialogResult.OK;
                return;
            }
            else
            {
                MessageBox.Show("Všechny požadované políčka musí byt vyplněny.");
            }
        }

        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}