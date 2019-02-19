using System;
using System.Windows.Forms;
using SystemProPodporuStudijnichPlanu.Logic;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCUKatedra : Form
    {
        public FormCUKatedra()
        {
            InitializeComponent();
        }
        public Katedra K
        {
            get
            {
                return new Katedra(Id, tb_zkr.Text, tb_název.Text);
            }
            set
            {
                tb_id.Text = K.Id_k.ToString();
                tb_zkr.Text = K.Zkr_k;
                tb_název.Text = K.Naz_k;
            }
        }
        public string Nazev
        {
            get => tb_název.Text;
            set => tb_název.Text = value;
        }
        public string Zkr
        {
            get => tb_zkr.Text;
            set => tb_zkr.Text = value;
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
        private void Bt_ok_Click(object sender, EventArgs e)
        {
            if (tb_název.Text == "" || tb_zkr.Text == "")
                MessageBox.Show("Musíte zadat název i zkratku katedry", "chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}