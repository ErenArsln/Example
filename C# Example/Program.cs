using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");

            Console.WriteLine("Hello World");

            // region nedir?
            // region fazla olan satırları tek satıra düşürmeye çelışan etikettir ve bu etikete isim verilebilir.
            #region 
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            #endregion

            #region tuple türü ile değer atama
            //Tuple değişkeni içerisnde birden fazla veyahut benzer türde değişken barındırabilir.
            (int a, string b) c = (1, "Eren"); //Burada 1 değeri a değerine, Eren değeri ise b değerine atama yapacaktır.
            (string isim, int yas, string cinsiyet) z = ("Mert", 27, "Erkek");
            #endregion

            #region Scope Nedir?
            //Tanımlamalarda ve algoritmik çalışmalarda karmaşıklığı önler.
            //Süslü parantez ile ayrılır ve algoritmalar süslü parantezin içerisine yazılır.
            //Scopelar iç içe tanılanabilir ÖR: {{}}.
            #endregion

            #region Metinsel Türlerin Dönüştürülmesi

            #region Parse Fonsiyonu
            //Parse: bir dönüşüm fonsiyonudur.
            string x = "15";
            int y = 7;
            short.Parse(x);//Burada metinsel olan x değişkenin sayısal bir değişken türü olan short değişken türüne döndürdük.
            Console.WriteLine(short.Parse(x) * y);// Şimdi ekranda işlemin çıktısnı alabiliriz.
            #endregion

            #region Operatörler
            string ad1 = "eren";
            string ad2 = "arslan";
            bool sonuc = ad1 == ad2;
            Console.WriteLine(sonuc);
            // ! Operatörü: Tersini yazdırır. Örneğin çıkan sonuc kodlamada false ise ekrana true yazdırır.
            int sayi1 = 10;
            int sayi2 = 7;
            Console.WriteLine("ÜNLEM OPERATÖRÜ ÇIKTISI");
            Console.WriteLine(sayi2 != sayi1);
            Console.WriteLine(!(sayi1 != sayi2));

            //Ternary Operatörü
            // Bu operatörün kendisi özetle if else koşulunun kısaltılmışıdır
            int takim = 1903;
            string eger = takim == 1903 ? "DOGRU CEVAP" : "YANLIŞ CEVAP";
            Console.WriteLine(eger);

            //İlk ikinokta üst üste olan kısıma kadar if kısmını gerçekleştirir geriye kalan kısım else kısmını gerçekleştirir.
            /*Burada yapılan kodlama kısacası eger= takim degiskeni 1903 ise dedik, soru işareti mecburi konulmalıdır. Sonra ekrana yazacak çıkyı söyledik
            daha sonra ikinokta üst üste koyarak else kısmıne geçtik takim egerki 1903 degilse ekrana yanlis yazsın dedik*/
            #endregion
            #endregion

            int takimD = 1903;
            string egerD = takimD == 1903 ? "DOGRU CEVAP" : "YANLIŞ CEVAP";
            Console.WriteLine(egerD);
            Console.ReadLine();

            Console.Write("eren");
        }
    }
}
