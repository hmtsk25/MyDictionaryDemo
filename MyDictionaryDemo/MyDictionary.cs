using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] Anahtarlar; //Key değerlerini tutmak için bir dizi oluşturuyoruz
        TValue[] Degerler;  //Value değerlerini tutmak için bir dizi oluşturuyoruz

        //Parametresiz yapıcı metodumuzla ilk MyDictionary nesnesini ürettiğimizde sıfır elemanlı anahtar/değer dizilerimizi oluşturuyoruz
        public MyDictionary()
        {
            Anahtarlar = new TKey[0];
            Degerler = new TValue[0];
        }

        // TKey ve TValue türünden aldığımız parametreleri dizilerimizin boyutlarını artırarak oluşturduğumuz MyDictionary nesnemize ekliyoruz
        public void Add(TKey key, TValue value)
        {
            //Dizi boyutunu artırırken elemanlarımızı kaybetmemek için yedek diziler oluşturup asıl dizilerimizin adreslerini alıyoruz.
            TKey[] tempKeyArray = Anahtarlar;
            TValue[] tempValueArray = Degerler;

            Anahtarlar = new TKey[Anahtarlar.Length + 1];
            Degerler = new TValue[Degerler.Length + 1];

            //döngünün yedeklediğimiz dizideki eleman sayısı kadar dönmesini sağlıyoruz. Bu sayede yedeklerimizi asıl dizilerimize aktarabiliyoruz.
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                Anahtarlar[i] = tempKeyArray[i];
                Degerler[i] = tempValueArray[i];
            }

            //Döngü sonrasında parametre olarak aldığımız değerleri eleman sayılarını artırdığımız dizilerimize ekliyoruz
            Anahtarlar[Anahtarlar.Length - 1] = key;
            Degerler[Degerler.Length - 1] = value;

        }

        //Eklediğimiz elemanları konsol ekranında yazdırıyoruz
        public void Yazdir()
        {
            for (int i = 0; i < Anahtarlar.Length; i++)
            {
                Console.WriteLine($"({Anahtarlar[i]}, {Degerler[i]})");
            }
        }

    }
}
