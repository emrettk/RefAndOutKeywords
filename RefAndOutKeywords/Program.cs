using System;

namespace RefAndOutKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int b = 8;
            int c = b;
            b = 54;
            Console.WriteLine(c);

            /*Üst satırdaki kodlarda çıktı olarak 8 olacaktır.Int değer tipli bir değişken 
             olduğu için sonradan yaptığımız değişiklikten etkilenmedi*/
            Console.WriteLine("-------------Ref-------------");

            int d = 8;
            ref int e = ref d;
            d = 54;
            Console.WriteLine(d);
            /*Buradaki kodlarda ise biz değer tipli olan int değişkenini referans tipli 
              bir değişkene çevirdik."Ref" anahtar keyword sayesinde*/
            /*Ufak bir kod bloğu bile tekrardan olayı kavramaya çalışalım*/
            Console.WriteLine("-------------Before Ref-------------");
            var sayi = 5;
            var sayi2 = 7;
            int   sonuc=0 ;

            Topla(sayi, sayi2,sonuc);
            Console.WriteLine($"Sonuç {sayi}+{sayi2}={sonuc}");
            
            /*Bu kod bloğu çalıştığında "5+7=0" sonucu dönecektir.Int değişkenin değer tipli bir değişken olmasında kaynaklı.*/
            /*Şimdi gelin kodumuzda bir kaç değişiklik yapalım.*/
            Console.WriteLine("-------------After Ref-------------");
            var sayi3 = 5;
            var sayi4 = 7;
            int sonuc2 = 0;

            Topla2(sayi3, sayi4, ref sonuc2);/*Burda görüldüğü üzere değişkenimizin başına "ref" keywordunu koyduk.Buradaki kullanım nedeni metod
                                               içerisinde yapılan değişikliliğin değer türüne uygulanması içindir.*/
            Console.WriteLine($"Sonuç {sayi3}+{sayi4}={sonuc2}");
            /*Olay tamamen bundan ibaret diyebiliriz.Bir diğer keywordde "out" 'tu.
              Bu keywordün "ref"'den tek farkı ilk değer ataması yapılmamış olmasıdır.*/
           


            Console.ReadLine();



        }
        private static void Topla(int ilk,int ikinci, int  sonuc)
        {
            sonuc = ilk + ikinci;
        }
        private static void Topla2(int ilk, int ikinci, ref int sonuc2)
        {
            sonuc2 = ilk + ikinci;
        }
    }
}
