﻿namespace Diziler_ArraySiniflari_Metodlar;
class Program
{
    static void Main(string[] args)
    {
        //Sort
        int[] sayiDizisi = {23,12,4,86,72,3,11,17};
        Console.WriteLine("***** Sırasız Dizi *****");
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        Console.WriteLine("***** Sıralı Dizi *****");
        Array.Sort(sayiDizisi);

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        //Celar
        Console.WriteLine("***** Array Clear *****");
        //sayiDzisi Elemanlarını Kullanarak 2.indexten itibaren 2 tane elemanı sıfırlar.
        Array.Clear(sayiDizisi,2,2);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        
        //Reverse Metodu
        Console.WriteLine("***** Array Reverse  *****");
        Array.Reverse(sayiDizisi);

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        //IndexOf
        Console.WriteLine("***** Array IndexOf *****");
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));

        //Resize
        Console.WriteLine("***** Array Resize *****");
        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8] = 99;

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
    }
}
