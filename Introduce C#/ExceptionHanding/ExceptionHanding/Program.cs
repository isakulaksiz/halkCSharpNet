try
{
    Console.WriteLine("Bir sayı girin");
    var bolunecek = int.Parse(Console.ReadLine());
    Console.WriteLine("Bir sayı daha girin");

    var bolen = Convert.ToInt32(Console.ReadLine());

    var sonuc = bolunecek / bolen;
    //Console.WriteLine("Her türlü çalışır...");
    Console.WriteLine($"{bolunecek}/{bolen} = {sonuc}");
}
catch (FormatException)
{

    Console.WriteLine("Değerler sayısal olmalı....");
}
//catch (DivideByZeroException)
//{
//	Console.WriteLine("Tam sayılar 0'a bölünemez");
//}
catch (Exception ex)
{
    Console.WriteLine($"Bir hata oluştu. Tipi ve Açıklaması: {ex.GetType().Name} {ex.Message}");
}
finally
{
    Console.WriteLine("Her türlü çalışır...");
}

