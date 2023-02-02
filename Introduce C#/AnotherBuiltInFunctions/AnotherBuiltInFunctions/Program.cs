string kelime = "adana";
//kelime içerisinde aranacak harfin yerlerini bulan kod parçası
//örnek a harfi arandığında 1. ve 5. sırada olduğunu söylesin.

int index = kelime.IndexOf('a', 2);
//Console.WriteLine(index);
int aranacakIndex = 0;
while (kelime.IndexOf('a', aranacakIndex) != -1)
{
    int bulunanIndex = kelime.IndexOf('a', aranacakIndex);
    aranacakIndex = bulunanIndex + 1;
    Console.WriteLine($"{kelime} kelimesinde a harfi {bulunanIndex}. indexte!");
}
