
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değikenler

            //    strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + patatoPrice + " - Gramaj: " + 
            //    patatoGram + " - Toplam Tutar: " + patatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + 
            //    tomatoGram + " - Toplam Tutar: " + tomato
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice+"TL" )  ;
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice +"TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + patatoPrice + "TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;


            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double patatoTotalPrice = patatoGram * patatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + 
            //    appleGram + " - Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + 
            //    orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + TotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice +
            //    strawberryTotalPrice + tomatoTotalPrice + patatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //    Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice+ " TL") ;
            #endregion

            #region Char Değişkenler

            //char symbol;

            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;


            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soy Adı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("--------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber+" - Yolcu Ad Soyad : " + passengerName + " " 
            //    + passengerSurname + " " + passengerDistrict + "/ " + passengerCity + " " + passengerAge + " ");



            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrices, computerPrice, chairPrice, tvPraice;
            //shoesPrices = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPraice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse( Console.ReadLine());

            //int totalPrice= shoesCount*shoesPrices + computerCount*computerPrice + chairCount*chairPrice
            //    + tvCount*tvPraice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, excam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1= double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2= double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //excam3= double.Parse(Console.ReadLine());

            //result=(exam1+ exam2+ excam3 ) /3 ;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Giişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.Write("Seçtiğiniz Cinsiyet: " + gender);

            #endregion
            


            Console.Read();

}
  