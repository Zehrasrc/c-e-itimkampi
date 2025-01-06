using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2.4.6.8
            //sarı,kırmızı,turuncu,mavi
            //ankara,istanbul,eskişehir,trabzon
            //Değişken Türü [] DiziAdı =new Değişen Türü[ElemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Kahire";
            //cities[2] = "Üsküp";
            //cities[3] = "Budapeşte";
            //cities[4] = "Lyon";

            //Console.WriteLine(cities[4]);
            //Console.WriteLine(cities[0]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[3] = 79;
            //numbers[5]=999;
            //numbers[9] = 762;

            //Console.WriteLine(numbers[2]);

            //string[] cities = { "Yunanistan", "Prag", "Atina", "İstanbul", "Ankara" };
            //Console.WriteLine(cities[4]);

            #endregion

            #region Dizidaki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Yeşil", "Turuncu", "Pembe", "Mor", "Mavi" };

            //for (int i = 0; i < colors.Length; i++)
            //    Console.WriteLine(colors[i]);

            //int[] numbers = { 1, 4, 56, 99, 119, 178, 269, 453, 765, 1232, 1400, 7456 };
            //for ( int i =0; i< numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '-', '/' };
            //for ( int i = 0; i< symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 31, 25, 129, 695 };
            //int maxNumber = myArray[0];

            //for ( int i=0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber )
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "zehra", "deniz", "buse" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 4, 7, 43, 290, 96, 83, 198, 105, 654 };
            //Array.Sort(numbers);
            //for ( int i =0; i < numbers.Length;  i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 4, 7, 43, 290, 96, 83, 198, 105, 654 };

            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotlar
            //string[] customers = { "ali", "buse", "çınar", "yağmur" };
            //int index = Array.IndexOf(customers, "buse");
            //Console.WriteLine(index);

            //int[] numbers = { 29, 56, 49, 97, 5 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max());
            //Console.WriteLine("Dizinin En Küçük Elemanı: " + numbers.Min());




            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for( int i =0; i< cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //for( int i =0; i< cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for ( int i = 0; i< numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 1, 34, 45, 98, 365, 986, 243, 451, 0};

            //Console.WriteLine("Çift Sayılar: ");
            //Console.WriteLine();
            //for ( int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Tek Sayılar: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion
            Console.Read();
        }
       
    }
}
