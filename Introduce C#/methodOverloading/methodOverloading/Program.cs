// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Geometri geometri = new Geometri();
geometri.AlanHesapla(3, "daire");
geometri.AlanHesapla(3, 5, "dikdörtgen");


/*
   Kare: birimUzunluk
   Dikdörtgen: en ve boy
   Daire: yarı çap
   Üçgen: yükseklik ve alt kenar
 */


public class Geometri
{
    public double AlanHesapla(double birimUzunluk1, string sekil)
    {
        double sonuc = 0.0;
        switch (sekil)
        {
            case "daire":
                sonuc = Math.PI * Math.Pow(birimUzunluk1, 2);
                break;
            case "kare":
                sonuc = Math.Pow(birimUzunluk1, 2);
                break;
            default:
                break;
        }

        return sonuc;
    }

    public double AlanHesapla(double birim1, double birim2, string sekil)
    {
        double sonuc = 0.0;
        switch (sekil)
        {
            case "üçgen":
                sonuc = birim1 * birim2 / 2;

                break;
            case "dikdörtgen":
                sonuc = birim1 * birim2;
                break;
        }
        return sonuc;
    }
}

