using System.Windows.Forms;

namespace SystemProPodporuStudijnichPlanu.Logic
{
    public class Kredity
    {
        public Kredity()
        {
            Suma = 0;
            Povinne = 0;
            PVolitelny = 0;
            Volitelny = 0;
            Sport = 0;
        }
        public Kredity(decimal suma, decimal povinne, decimal pVolitelny, decimal volitelny, decimal sport)
        {
            Suma = suma;
            Povinne = povinne;
            PVolitelny = pVolitelny;
            Volitelny = volitelny;
            Sport = sport;
        }
        public void PridatKr(int pridavek,int vyber)
        {
            switch(vyber)
            {
                case 1: Suma += pridavek;break;
                case 2: Povinne += pridavek;break;
                case 3: PVolitelny += pridavek;break;
                case 4: Volitelny += pridavek;break;
                case 5: Sport += pridavek;break;
                default:break;
            }
        }
        public decimal Suma { get; set; }
        public decimal Povinne { get; set; }
        public decimal PVolitelny { get; set; }
        public decimal Volitelny { get; set; }
        public decimal Sport { get; set; }
        public void NaplnNUD(NumericUpDown sum, NumericUpDown pov, NumericUpDown pv, NumericUpDown v, NumericUpDown s)
        {
            sum.Value = Suma;
            pov.Value = Povinne;
            pv.Value = PVolitelny;
            v.Value = Volitelny;
            s.Value = Sport;
        }
    }
}