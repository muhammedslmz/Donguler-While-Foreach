using System;
namespace Donguler_While_Foreach
{
    class Program 
    {
        static void Main(string[]args)
        {
            //while
            Console.Write("Lütfen sayı giriniz: ");
            int sayi =Convert.ToInt32(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            char character='a';
            while(character<='z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine("***Foreach***");

            string[]arabalar= {"BMW","Ford","Audi"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba); 
            }
        }
    }
}