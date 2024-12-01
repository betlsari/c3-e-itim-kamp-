using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___MakingDecision__
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region IF Else

            //Console.Write("Lütfen Şifreyi giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;

            //Console.Write("Başkenti Giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz:");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler Hatalı");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz:");
            //number = int.Parse(Console.ReadLine());

            //if(number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result;

            //Console.Write("Sınav1:");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların Ortalaması:" + average);

            //if(average>0 & average<=50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if(average>50 & average<=70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if(average>70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84 & average <=100)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //else
            //{
            //    result = "HATA!";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız:");
            //city = Console.ReadLine();

            //if(city=="adana" | city=="ankara" | city=="bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Write("Lütfen Kullanıcı Adını Giriniz:");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu Kullanıcı Adı Kabul Edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}



            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.Sayıyı Giriniz:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sayıyı Giriniz:");
            //int number2 = int.Parse(Console.ReadLine());


            //int result = number1 % number2;

            //Console.Write("Birinci Sayının İkinici Sayıya Bölümünde Kalan Değer:"+result);

            //Console.Write("Lütfen Bir Sayı Giriniz:");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir:");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}

            #endregion

            #region Char Değişkenler İle Karar Yapıları

            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz:");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması


            //Console.WriteLine("** Ogi Restoran **");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ara Sıcaklar");
            //Console.WriteLine("3-Ana Yemekler");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını Görmek İstediğiniz Menüyü Seçiniz:");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Çorbalar --------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Kelle Paça");
            //    Console.WriteLine("3-Tavuk Suyu");
            //    Console.WriteLine("4-Tarhana");
            //    Console.WriteLine("5-İşkembe");
            //    Console.WriteLine("------------ Çorbalar --------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ara Sıcaklar --------------");
            //    Console.WriteLine("1-Patates Kızartması");
            //    Console.WriteLine("2-Sigara Böreği");
            //    Console.WriteLine("3-Paçanga Böreği");
            //    Console.WriteLine("4-Yaprak Sarma");
            //    Console.WriteLine("5-İçli Köfte");
            //    Console.WriteLine("------------ Ara Sıcaklar --------------");
            //    Console.WriteLine();
            //}

            //if(menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Ana Yemekler --------------");
            //    Console.WriteLine("1-Urfa Kebap");
            //    Console.WriteLine("2-Adana Kebap");
            //    Console.WriteLine("3-Beyti Sarma");
            //    Console.WriteLine("4-İskender");
            //    Console.WriteLine("5-Pideli Köfte");
            //    Console.WriteLine("------------ Ana Yemekler --------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ Tatlılar --------------");
            //    Console.WriteLine("1-Künefe");
            //    Console.WriteLine("2-Katmer");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("4-Kadayıf");
            //    Console.WriteLine("5-Süt Helvası");
            //    Console.WriteLine("------------ Tatlılar --------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ İçecekler --------------");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Fanta");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("4-Şalgam");
            //    Console.WriteLine("5-Su");
            //    Console.WriteLine("------------ İçecekler --------------");
            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız:");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.Write("Ocak");
            //        break;
            //    case 2:
            //        Console.Write("Şubat");
            //        break;
            //    case 3:
            //        Console.Write("Mart");
            //        break;
            //    case 4:
            //        Console.Write("Nisan");
            //        break;
            //    case 5:
            //        Console.Write("Mayıs");
            //        break;
            //    case 6:
            //        Console.Write("Haziran");
            //        break;
            //    case 7:
            //        Console.Write("Temmuz");
            //        break;
            //    case 8:
            //        Console.Write("Ağustos");
            //        break;
            //    case 9:
            //        Console.Write("Eylül");
            //        break;
            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasım");
            //        break;
            //    case 12:
            //        Console.Write("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Giriş");
            //        break;

            //}


            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("Lütfen Birinci Sayıyı Giriniz");
            //number1=int.Parse(Console.ReadLine());
            //Console.Write("Lütfen İkinci Sayıyı Giriniz");
            //number2=int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz:");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam:" + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark:" + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım:" + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm:" + result);
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Sembol");
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
