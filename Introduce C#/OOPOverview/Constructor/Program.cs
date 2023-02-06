// See https://aka.ms/new-console-template for more information
using Constructor;

Console.WriteLine("Hello, World!");
Ekmek ekmek = new Ekmek();

Ekmek e2 = new Ekmek { Tur = "Çavdar", Adet = 2 };
//Object initializer; nesne oluşturmayı kolaylaştırır ama bu constructor'dan vazgeçmenize sebep olmaz. Constructor, ihtiyaç duyulan yapıyı yönetir.

ReportGenerator reportGenerator = new ReportGenerator("satis.xslx");
