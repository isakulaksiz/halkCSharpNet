//Ben her şeyi biliyorum:
//    0           1         2           3           4
string[] gunler = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };
//Ben sadece kaç adet olacağını biliyorum.
string[] ogrenciler = new string[16];
ogrenciler[0] = "Ahmet";
ogrenciler[1] = "Alaattin";
ogrenciler[15] = "Türkay";

Console.WriteLine(gunler[gunler.Length - 1]);

/*
 * Kullanıcının girdiği iki basamaklı bir sayıyı, okunuşuna çevirmek istiyoruz.
 *
 * 23 = yirmiüç
 * 4578 = 
 */

bool devamEtsinMi = true;

//string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
//string[] onlar = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };

while (devamEtsinMi)
{
    Console.WriteLine("iki basamaklı bir sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());
    //int onlarBasamagi = sayi / 10;
    //int birlerBasamagi = sayi % 10;

    Console.WriteLine($"{sayi} değerinin türkçe okunuşu: {yaziyaCevir(sayi)}");
    Console.WriteLine("Devam edelim mi? (E/H)");
    devamEtsinMi = Console.ReadLine().ToLower() == "e";


}

for (int dongudekiSayi = 1; dongudekiSayi < 100; dongudekiSayi++)
{
    //int onlarBasamagi = dongudekiSayi / 10;
    //int birlerBasamagi = dongudekiSayi % 10;

    Console.WriteLine($"{yaziyaCevir(dongudekiSayi)}");
}

string yaziyaCevir(int sayi)
{
    string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
    string[] onlar = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
    int onlarBasamagi = sayi / 10;
    int birlerBasamagi = sayi % 10;
    return $"{onlar[onlarBasamagi]} {birler[birlerBasamagi]}";
}