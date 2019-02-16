namespace SystemProPodporuStudijnichPlanu.Logic
{
    public class Katedra
    {
        public int Id_k { get; set; }
        public string Zkr_k { get; set; }
        public string Naz_k { get; set; }
        public Katedra() { }
        public Katedra(string zkr_k, string naz_k)
        //constructor bez id
        {
            DataAccess da = new DataAccess();
            Id_k = da.GetKatedraId(Naz_k);
            Zkr_k = zkr_k;
            Naz_k = naz_k;
        }
        //full constructor
        public Katedra(int id_k, string zkr_k, string naz_k)
        {
            Id_k = id_k;
            Zkr_k = zkr_k;
            Naz_k = naz_k;
        }
        public override string ToString() => Naz_k;
        public int ToInt() => Id_k;
    }
}
