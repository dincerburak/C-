namespace Diziler;
class Program
{
    static void Main(string[] args)
    {
        //Dizi Tanımlama
        string[] renkler = new string[5];
        string[] hayvanlar = {"Kedi", "Köpek","Kuş","Maymun"};

        int[] dizi;
        dizi = new int[5];

        //Dizilere Değer Atama ve Erişim
        dizi[3] = 10;
        renkler[0] = "Mavi";
        
        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(renkler[0]); 
        Console.WriteLine(dizi[3]);

        //Döngülerle Dizi Kullanımı
        //Klavyeden Girilen n tane sayının ortaamasını hesaplayan program
        Console.Write("Dizinin Eleman Sayısını Giriniz : ");
        int diziUzunluğu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int [diziUzunluğu];
        for (int i = 0; i < diziUzunluğu; i++)
        {
            Console.Write("{0}. sayıyı giriniz : ", i+1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }
        int toplam = 0;
        foreach (var sayi in sayiDizisi)
        
            toplam +=sayi;
            Console.WriteLine("Ortalama : "+toplam/diziUzunluğu);
        

    }
}
