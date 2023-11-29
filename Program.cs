namespace Proje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dil seçiniz TR - EN");
            string dil = Console.ReadLine().ToUpper();

            string msg1 = "1.sayıyı giriniz: ", msg2 = "2.sayıyı giriniz: ", msg3 = "İşlem seçiniz: ", msg4 = "İşlemin sonucu:", msg5 = "Hatalı giriş yaptınız";

            if (dil == "EN")
            {
                msg1 = "Enter first number: ";
                msg2 = "Enter second number";
                msg3 = "Select operation";
                msg4 = "Result";
                msg5 = "İncorrect operation selected";
            }

            Console.WriteLine(msg1);
            double sayi1 = double.Parse(Console.ReadLine());
            Console.WriteLine(msg2);
            double sayi2 = double.Parse(Console.ReadLine());
            Console.WriteLine(msg3);
            string islem = Console.ReadLine();
            if (islem == "+")
            {
                double sonuc = sayi1 + sayi2;
                Console.WriteLine(msg4 + " " + sonuc);
            }
            else if (islem == "-")
            {
                double sonuc = sayi1 - sayi2;
                Console.WriteLine(msg4 + " " + sonuc);
            }
            else if (islem == "*")
            {
                double sonuc = sayi1 * sayi2;
                Console.WriteLine(msg4 + " " + sonuc);
            }
            else if (islem == "/")
            {
                double sonuc = sayi1 / sayi2;
                Console.WriteLine(msg4 + " " + sonuc);
            }
            else { Console.WriteLine(msg5); }
        }
    }
}