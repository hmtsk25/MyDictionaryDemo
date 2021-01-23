using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(123, "Ömer");
            ogrenciler.Add(12412, "Burak");
            ogrenciler.Add(546, "Mustafa");

            ogrenciler.Yazdir();

        }
    }
}
