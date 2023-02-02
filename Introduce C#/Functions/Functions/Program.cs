show("Ben");
show("bir");
show("metot");
show("yazdım");
show(".....");


int value = 8;

/*
 * 1. Bir kelime koleksionu içinden rastgele bir kelime seç
 * 2. Seçilen kelimenin harflerini *'a çevir
 * 3. *'lardan oluşan bulmacayı ekranda göster
 * 4. Kullanıcıdan harf iste
 * 5. Girilen harfi kelimede ara
 * 6. a) Eğer harf varsa harfin bulunduğu yerdeki * işaretini harfe çevir (**** - a**a)
 *    b) Eğer harf yoksa harf yoktur de ve harf hakkını bir azalt
 * 7. Kullanıcıdan tahmin iste   
 */

List<string> kelimeler = new List<string>() { "ayna" };
string kelime = rastgeleKelimeSecici(kelimeler);
string bulmaca = bulmacayaCevir(kelime);
ekrandaGoster(bulmaca);
var harf = harfIste();

if (harfVarMi(harf, kelime))
{
    var bulmacaYeni = yildiziHarfeDonustur(kelime, bulmaca, harf);
    ekrandaGoster(bulmacaYeni);
}
else
{
    ekrandaGoster("Harf bulunamadı");
}



string rastgeleKelimeSecici(List<string> kelimeler)
{
    Random random = new Random();
    int randomIndex = random.Next(0, kelimeler.Count);

    return kelimeler[randomIndex];
}

string bulmacayaCevir(string kelime)
{
    //ayna -> ****
    string bulmaca = string.Empty;
    for (int i = 0; i < kelime.Length; i++)
    {
        bulmaca += "*";
    }
    return bulmaca;
}

void ekrandaGoster(string ifade)
{
    Console.WriteLine(ifade);
}

char harfIste()
{
    Console.WriteLine("Bir harf giriniz...");

    return Convert.ToChar(Console.ReadLine());
}

bool harfVarMi(char harf, string kelime)
{
    return kelime.Contains(harf);
}

string yildiziHarfeDonustur(string secilenKelime, string bulmaca, char harf)
{
    return "a**a";
}






if (isEven(value))
{
    Console.WriteLine("çifttir");
}

void show(string message)
{
    Console.WriteLine(message);
}

bool isEven(int number)
{
    return number % 2 == 0;

}
