namespace Donguler_For_Loop;
class Program
{
    static void Main(string[] args)
    {
        // Ekrandan Girilen sayıya kadar olan tek sayıları ekrana yazdır.
        Console.Write("Bir Sayi Giriniz : ");
        int sayac = int.Parse(Console.ReadLine());
        for(int i = 1; i <= sayac; i++)
        {
            if(i%2==1)
            Console.WriteLine(i);
        }
        // 1 ile 1000 arasındaki tek ve çift sayiların kendi içlerinde toplamlarını ekrana yazdır.
        int tekToplam = 0;
        int ciftToplam = 0;
        for (int i = 1; i <= 1000; i++)
        {
            if (i%2 == 1)
            
                tekToplam += i; //tekToplam = tekToplam + i;
            else
                ciftToplam +=i; //tektoplam = tektOPLAM + İ;
        }  
            Console.WriteLine("Tek Toplamı : " + tekToplam);
            Console.WriteLine("Çift Toplamı : "+ciftToplam);

            //break, continue

            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                break;
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    continue;
                    Console.WriteLine(i);
                }
            }
    }
}
