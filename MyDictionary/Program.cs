using System;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericDictionary<int, string> adSoyadNu = new MyGenericDictionary<int, string>();
            adSoyadNu.Add(123, "Buse Akyüz");
            adSoyadNu.Add(345, "Alper Akyüz");
            adSoyadNu.Add(567, "Büşra Akyüz");
            adSoyadNu.Add(890, "Engin Demiroğ");
            adSoyadNu.Add(999, "Demiroğ Engin");

            Console.WriteLine("Öğrenci No: " + adSoyadNu.Items1[0] + " " + "Ad Soyad: " + adSoyadNu.Items2[0]);
            Console.WriteLine("Öğrenci No: " + adSoyadNu.Items1[1] + " " + "Ad Soyad: " + adSoyadNu.Items2[1]);
            Console.WriteLine("Öğrenci No: " + adSoyadNu.Items1[2] + " " + "Ad Soyad: " + adSoyadNu.Items2[2]);
            Console.WriteLine("Öğrenci No: " + adSoyadNu.Items1[3] + " " + "Ad Soyad: " + adSoyadNu.Items2[3]);
            Console.WriteLine("Öğrenci No: " + adSoyadNu.Items1[4] + " " + "Ad Soyad: " + adSoyadNu.Items2[4]);

        }
    }
}