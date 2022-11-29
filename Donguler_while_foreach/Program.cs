namespace Donguler_while_foreach;
class Program
{
    static void Main(string[] args)
    {
        //While
        //1 den başlayarak konsoldan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp konsola a yazdırma.
         Console.Write("Bİr Sayı Griniz : ");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam =0;
        while (sayac <=sayi)
        {
            toplam+=sayac;
            sayac++;
        }
         Console.WriteLine(toplam/sayi);

         //'a' dan 'z' ye kadar tüm harfleri konsola yazdırma.
         char character = 'a';
         while (character <= 'z')
         {
             Console.WriteLine(character);
             character ++;
         }
         Console.WriteLine("***** Foreach *****");
         String[] arabalar = {"BMW", "FORD", "TOYOTA","NISSAN"};
         foreach (var araba in arabalar)
         {
             Console.WriteLine(araba);
         }
    }
}
