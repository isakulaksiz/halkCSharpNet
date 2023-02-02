string kelime = "halkbank";
Console.WriteLine("aranacak harfi girin");
var arananHarf = Console.ReadLine();
var harfVarMi = kelime.Contains(arananHarf);

//if (harfVarMi)
//{
//    Console.WriteLine($"{kelime} içinde {arananHarf} harfi vardır");
//}
//else
//{
//    Console.WriteLine($"{kelime} içinde {arananHarf} harfi yoktur");

//}

var durum = harfVarMi ? "vardır" : "yoktur";
int x = 5;
string sonuc = x % 2 == 0 ? "Çift" : "Tek";



Console.WriteLine($"{kelime} içinde {arananHarf} harfi {durum}");

/*
 * 1. şifre en az 6 karakterden oluşmalı
 * 2. hem harf, hem sayı hem de alfanumerik olmayan karakter olmalı. = Güçlü
 * 3. (Harf + sayı),(harf+alfanumerik!) = Orta
 * 4. Tek bir türden oluşuyorsa =  Zayıf
 */
Console.WriteLine("Şifrenizi girin");
string sifre = Console.ReadLine();
if (sifre.Length >= 6)
{
    char[] sifreKarakterleri = sifre.ToCharArray();
    bool harfMi = false;
    bool sayiMi = false;
    bool alfaNumerikDegilMi = false;

    foreach (var karakter in sifreKarakterleri)
    {
        if (char.IsLetter(karakter))
        {
            harfMi = true;
        }
        else if (char.IsDigit(karakter))
        {
            sayiMi = true;
        }
        else
        {
            alfaNumerikDegilMi = true;
        }
    }

    if (harfMi && sayiMi && alfaNumerikDegilMi)
    {
        Console.WriteLine("Güçlü");
    }
    else if ((harfMi && sayiMi) || (harfMi && alfaNumerikDegilMi) || (sayiMi && alfaNumerikDegilMi))
    {
        Console.WriteLine("Orta");
    }
    else
    {
        Console.WriteLine("Zayıf");
    }


}
else
{
    Console.WriteLine("Şifre en az 6 karakterden oluşmalı");
}