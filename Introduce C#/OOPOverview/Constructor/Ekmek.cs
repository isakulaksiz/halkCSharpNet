namespace Constructor
{
    public class Ekmek
    {
        public int Adet { get; set; }
        public string Tur { get; set; }

        public Ekmek() : this(1, "Beyaz")
        {
            //Adet = 1;
            //Tur = "Beyaz";
        }


        public Ekmek(int adet) : this(adet, "Beyaz")
        {
            //Adet = adet;
            //Tur = "Beyaz";
        }

        public Ekmek(string tur) : this(1, tur)
        {
            //Adet = 1;
            //Tur = tur;
        }

        public Ekmek(int adet, string tur)
        {
            Adet = adet;
            Tur = tur;
            //method();
        }

    }
}
