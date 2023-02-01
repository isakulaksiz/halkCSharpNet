namespace variables
{
    internal class Program
    {
        // static int x = 5;

        static void Main(string[] args)
        {

            //    Console.WriteLine("Hello, World!");

            //    if (true)
            //    {
            //        while (true)
            //        {
            //            if (true)
            //            {
            //                if (true)
            //                {
            //                    for (int i = 0; i < 5; i++)
            //                    {
            //                        if (true)
            //                        {
            //                            while (true)
            //                            {

            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }




            /*
             * sayısal, sözel, mantıksal
             */
            //Tam sayılar:
            byte eightByte = 255;


            sbyte signedByte = -128;

            short sixteen = 32767;


            ushort unSignedShort = 65535;

            int thirtytwo = 2147483647;

            long sixtyFour = 9223372036854775807;

            //ondalıklı sayılar
            double piDouble = 3.14;

            float piFloat = 3.14f;


            decimal piDecimal = 0.000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001M;


            //sözel
            char letter = 'P';


            string kelime = "Türkay";

            String Kelime = "Türkay";


            bool olurMu = false;


            var number = 42;
            var company = "Halkbank";

            //BMI formülü:
            //bmi = kilo / boy (m) ^ 2


            Console.WriteLine("Lütfen kilonuzu girin:");
            //string kiloDegeri = Console.ReadLine();
            try
            {
                int kilo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen boyunuzu metre cinsinden giriniz...");
                double boy = Convert.ToDouble(Console.ReadLine());
                var bmi = kilo / (boy * boy);

                Console.WriteLine($"BMI değeriniz; {bmi} olarak hesaplandı!");
            }
            catch (FormatException)
            {

                Console.WriteLine("Lütfen sayısal girdiğinize emin olun");
            }

            byte another = 15;
            int anotherValue = another;

            int x = 20;
            byte bayt = (byte)x;

            byte b1 = 255;
            byte b2 = 2;


            try
            {
                checked
                {
                    byte sonuc = (byte)(b1 + b2);
                    Console.WriteLine($" {b1} ve {b2} değerlerinin toplamı: {sonuc}");
                }
            }
            catch (OverflowException)
            {

                Console.WriteLine($"{b1} ve {b2} değerlerinin toplamı byte'ın sınırlarının dışında!");
            }









        }
    }
}