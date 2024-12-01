using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___07_ForEachLoop__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste,Koleksiyon,Dizi

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach(int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;
            //foreach(int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3, 4,5,8
            //};
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba" ;

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}








            #endregion

            #region Örnek Sınav Sistemi

            //Console.Write("** Ogi Eğitim Kampı Sınav Uygulaması **");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("-----------------------------");

            ////Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma

            //Console.Write("Sınıfınızda Kaç Öğrenci Var:");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------");


            ////Öğrenci İsimlerini Ve Not Ortalamalarını Saklayacak Diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];
            
            //for(int i =0;i<studentCount; i++)
            //{
            //    Console.Write($"{i+1}.Öğrencinin İsmini Giriniz:");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her Öğrenci İçin 3 Sınav Notu Girişi
            //    for(int j=0;j<3;j++)
            //    {
            //        Console.Write($"{studentNames[i]} Adlı Öğrencinin {j + 1}.Sınav Notunu Giriniz:");
            //        double value=double.Parse(Console.ReadLine());
            //        totalExamResult += value;//Notları Topluyoruz
                    
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            ////Sınav Ortalamaları
            //Console.WriteLine("-----------------------------");
            //for (int i = 0;i<studentCount;i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} Adlı Öğrencinin Ortalaması : {studentExamAvg[i]}");
            //    //Öğrencilerin Ortalaması Ve Geçip Kalma Durumları
            //    if(studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersi Geçti:");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersten Kaldı");
            //    }
            //    Console.WriteLine("-----------------------------");
            //}


            #endregion

            Console.Read();
        }
    }
}
