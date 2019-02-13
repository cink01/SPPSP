using System;
using System.Data;
using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu.Aplication
{
    public partial class FormCUZaznam : Form
    {
        public bool Schov { get; set; }
        public string Id
        {
            get => tb_id.Text;
            set => tb_id.Text = value;
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
        public string Obor
        {
            get
            {
                DataRowView DV = cmb_obor.SelectedItem as DataRowView;
                return DV.Row["rok_obor"].ToString();
            }
            set => cmb_obor.SelectedIndex = cmb_obor.FindStringExact(value);
        }
        public FormCUZaznam()
        {
            if (Schov == true)
            {
                l_id.Visible = false;
                tb_id.Visible = false;
            }
            DataAccess a = new DataAccess();
            InitializeComponent();
            a.FillOborCB(cmb_obor);
        }
        /*  List<Obor> obors = new List<Obor>();
  public FormCUZaznam()
  {
      if (Schov == true)
      {
          l_id.Visible = false;
          tb_id.Visible = false;
      }
      DataAccess a = new DataAccess();
      Filling fill = new Filling();
      InitializeComponent();
      obors.Clear();
      obors = a.GetFullObor();
      fill.NaplnComboBox<Obor>(cmb_obor,obors);
  }*/
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
            if(tb_id.Text!="")
            {
                bt_info.Visible = true;
            }
        }

        private void Bt_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Změna oboru povede k smazání zadaných předmětů v semestrech.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
