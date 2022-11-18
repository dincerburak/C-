namespace degisken;
class Program
{
    static void Main(string[] args)
    {
        string str ="Burak";
        char c = '1';
        byte b = 5;
        sbyte sb=4;
        
        short s = 6;
        ushort us= 7;

        Int16 i16= 9;
        int i = 10;
        Int32 i32 = 11;
        Int64 i64= 12;
        uint ui=13;

        long l = 13;
        ulong ul= 14;

        //reel sayilar
        float f = 15;
        double d =16;
        decimal de=17;

        bool b1=true;
        bool b2=false;
        
        DateTime dt= DateTime.Now; //O an ki saat tarih.
        Console.WriteLine(dt);

        object o1 = 'x';
        object o2 = 'y';
        object o3 = 4;
        object o4 = 4.3;

        // String ifadeler
        String str1= string.Empty;
        str1 = "Burak Dincer";
        string ad= "Burak";
        string soyad = "Dincer";
        string tamIsım = ad + " " + soyad;

        //intiger tanımlama şekilleri
        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        //boolean
        bool bool1 = 10>2;

        // Degisken Dönüşümleri
        string str20 = "20";
        int int20 =20;

        String yeniDeger = str20+int20.ToString();
        Console.WriteLine(yeniDeger); //sonuc 2020

        int int21= int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21); // Çıktısı 40

        //Convert.To... Detayları bak

       int  int22= int20 + int.Parse(str20); //bir diğer değişiklik yapma, str çevir ve int20 ile topla.çıktısı 40.

       //datetime
       string datetime = DateTime.Now.ToString("dd.MM.yyyy");
       Console.WriteLine(datetime);

        string hour = DateTime.Now.ToString("HH:mm");
       Console.WriteLine(hour); //o anki saati verir.
       
    }
}
