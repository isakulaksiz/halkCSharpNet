// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
   Kare: birimUzunluk
   Dikdörtgen: en ve boy
   Daire: yarı çap
   Üçgen: yükseklik ve alt kenar
 */

double alanHesapla(double birimUzunluk1, string sekil)
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

double alanHesapla(double birim1, double birim2, string sekil)
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

