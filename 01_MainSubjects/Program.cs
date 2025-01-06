using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("MERHABA DÜNYA");
            //Console.Write("SELAM");


            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-ÇORBALAR");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine("");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion


            #region StringDeğişkenler
            ////string
            ////Değişken_türü değişken_adı;

            ////string name;
            ////name = "Zehra";
            ////Console.Write(name);


            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Zehra";
            //customerSurname = "Serçe";
            //customerPhone="+90 900 450 24 59";
            //customerEmail = "deneme@gmail.com";
            //district = "Beykoz";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("----------------------------------------------------");

            //Console.WriteLine("");

            //customerName = "Reyyan";
            //customerSurname = "Src";
            //customerPhone = "+90 884 767 49 93";
            //customerEmail = "test@gmail.com";
            //district = "Fatih";
            //city = "İstanbul";

            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("----------------------------------------------------");

            #endregion

            #region Int Değişkenler
            ////int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrices = 50;
            int pizzaPrices = 250;
            int lemonadePrices = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine("");
            Console.WriteLine("------Hamburger:" + hamburgerPrice + "TL");
            Console.WriteLine("------Pizza:" + pizzaPrices + "TL");
            Console.WriteLine("------Kızartmalar:" + friesPrices + "TL");
            Console.WriteLine("------Kola:" + cokePrice + "TL");
            Console.WriteLine("------Limonata:" + lemonadePrices + "TL");
            Console.WriteLine("------Su:" + waterPrice + "TL");
            Console.WriteLine("");
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine("");
            int hamburgerCount;
            int pizzaCount;
            int friesCount;
            int cokeCount;
            int lemonadeCount;
            int waterCount;

            int totalhamburgerPrice=0;
            int totalcokePrice = 0;
            int totalpizzaPrice = 0;
            int totalfriesPrices = 0;
            int totalwaterPrice = 0;
            int totallemonadePrice = 0;


            hamburgerCount = 3;
            pizzaCount = 0;
            friesCount = 1;
            cokeCount = 3;
            lemonadeCount = 0;
            waterCount = 3;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalcokePrice= cokeCount * cokePrice;
            totalfriesPrices = friesCount * friesPrices;
            totallemonadePrice = lemonadeCount * lemonadePrices;
            totalwaterPrice= waterCount * waterPrice;
            totalpizzaPrice=pizzaCount* pizzaPrices;


            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Hamburger Tutarı:" + totalhamburgerPrice + "TL");
            Console.WriteLine("Pizza Tutarı:" + totalpizzaPrice + "TL");
            Console.WriteLine("Kızartma Tutarı:" + totalfriesPrices + "TL");
            Console.WriteLine("Limonata Tutarı:" + totallemonadePrice + "TL");
            Console.WriteLine("Su Tutarı:" + totalwaterPrice + "TL");
            Console.WriteLine("Kola Tutarı:" + totalcokePrice + "TL");

            int totalPrice = totalhamburgerPrice + totalcokePrice + totalfriesPrices 
                + totalpizzaPrice + totalwaterPrice + totallemonadePrice;

            Console.WriteLine("Toplam Ödenecek tutar:" + totalPrice + "TL");


          


            #endregion









            Console.Read();


        }
    }
}

