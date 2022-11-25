namespace Hata_Yonetimi;
class Program
{
    static void Main(string[] args)
    {
        /* try
        {
            Console.Write("Bir Sayi Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş Olduğunuz Sayi : " +sayi);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Hata :  "+ex.Message.ToString());
            
        }
        finally
        {
            Console.Write("İşlem Tamamlandı");
        }
            */
        try
        {
            int a = int.Parse("-2000000000000");
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine("Boş Değer Girdiniz : ");
            Console.WriteLine(ex);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Veri Tipi Uygun Değil. !  ");
            Console.WriteLine(ex);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Çok küçük ya da büyük bir değer girdiniz!.");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("İşlem Başarıyla Tamamlandı.! ");
        }
        
    }
}
