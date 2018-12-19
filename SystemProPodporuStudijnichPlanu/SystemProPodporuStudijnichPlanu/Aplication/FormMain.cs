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
    public partial class FormMain : Form
    {
        List<Predmet> predmetyFull = new List<Predmet>();
        List<Predmet> predmetyS1 = new List<Predmet>();
        List<Predmet> predmetyS2= new List<Predmet>();
        List<Predmet> predmetyS3= new List<Predmet>();
        List<Predmet> predmetyS4 = new List<Predmet>();
        List<Predmet> predmetyS5= new List<Predmet>();
        List<Predmet> predmetyS6= new List<Predmet>();
        List<Predmet> predmetyS7= new List<Predmet>();
        List<Predmet> predmetyS8= new List<Predmet>();
        List<Predmet> predmetyS9= new List<Predmet>();
        List<Predmet> predmetyS10 = new List<Predmet>();
        public FormMain()
        {
            InitializeComponent();
            Color c = System.Drawing.ColorTranslator.FromHtml("#e8212e");
            menuStripMain.BackColor = c;
            menuStripMain.ForeColor = Color.White;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Obnov();
        }

        private void Obnov()
        {
            lb_semestr1.DataSource = predmetyFull;
            lb_semestr1.DisplayMember = "NazInfo";
            KreditySum();
        }
        private void ObnovFull()
        {
            lb_semestr1.DataSource = predmetyFull;
            lb_semestr1.DisplayMember = "FullInfo";
            KreditySum();
        }
        private void KreditySum()
        {
            decimal sum = (decimal)0;
            foreach (Predmet a in predmetyFull)
            {
                sum += a.KreditPredmet;
            }
            nud_KredSem1.Value = sum;
        }

        private void ZmenaKredituVNUD(object sender, EventArgs e)
        {
            nud_celkemKred.Value = nud_KredSem1.Value + nud_KredSem2.Value + nud_KredSem3.Value + nud_KredSem4.Value + nud_KredSem5.Value + nud_KredSem6.Value;
            if (nud_KredSem1.Value < 15) 
                nud_KredSem1.BackColor = Color.LightCoral;
            else
                nud_KredSem1.BackColor = Color.LightGreen;
            if (nud_celkemKred.Value < 180)
                nud_celkemKred.BackColor = Color.LightCoral;
            else
                nud_celkemKred.BackColor = Color.LightGreen;

        }

        private void PredmetyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void UkonceniProgramu(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.EXIT_MESSAGE, Properties.Resources.EXIT_TITLE,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void Bt_proved_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            int IS=1;
            predmetyFull = db.GetPredmetFull(IS);
            ObnovFull();
        }

        private void NaplnitDatabáziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NacteniDat nd = new NacteniDat();
            string cesta = @"C:\Users\Tommi\Desktop\SPPSP\pomocné soubory\vspj_predmety_bez_anotace.txt";
            nd.Proved(cesta);
            DataAccess da = new DataAccess();
        }
    }
}
