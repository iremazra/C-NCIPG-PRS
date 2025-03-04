// See https://aka.ms/new-console-template for more information
using _27._02._2025_PRS_AbstractionÖdevi.Classes;

Console.WriteLine("Hello, World!\n");


BMW bMW = new BMW();
Mercedes mercedes = new Mercedes();
Porsche porsche = new Porsche();

Console.WriteLine("BMW:"+ bMW.GoFast()+bMW.Swim()+bMW.Fly());
Console.WriteLine("Mercedes:" + mercedes.Swim() + mercedes.Fly());
Console.WriteLine("Porsche:" + porsche.Fly());

Console.WriteLine("*****************************");
Console.WriteLine("*****************************");

GenelMudur genelMudur = new GenelMudur();
Mudur mudur= new Mudur();
Programcı programcı = new Programcı();
Stajyer stajyer= new Stajyer();

Console.WriteLine("Genel müdür maaşı:"+stajyer.MaasinizNedir());
Console.WriteLine("Müdür maaşı:"+mudur.MaasinizNedir());
Console.WriteLine("Programcı maaşı:"+programcı.MaasinizNedir());
Console.WriteLine("Stajyer maaşı:" + stajyer.MaasinizNedir());

 float toplamMaas= genelMudur.MaasinizNedir() + mudur.MaasinizNedir() + programcı.MaasinizNedir() + stajyer.MaasinizNedir();
Console.WriteLine("Toplam Maas:" + toplamMaas);

Console.WriteLine("*****************************");
Console.WriteLine("*****************************");

BMWYakit bMWYakit = new BMWYakit();
MercedesYakit mercedesYakit = new MercedesYakit();
PorscheYakit porscheYakit = new PorscheYakit();

bMWYakit.marka();
mercedesYakit.marka();
porscheYakit.marka();

Console.WriteLine("BMW'nin 1 saatte tükettiği yakıt miktarı:" + bMWYakit.birSaatlikYakit().ToString());
Console.WriteLine("Mercedes'in 1 saatte tükettiği yakıt miktarı:" + mercedesYakit.birSaatlikYakit().ToString());
Console.WriteLine("Porsche'nin 1 saatte tükettiği yakıt miktarı:" + porscheYakit.birSaatlikYakit().ToString());

float besSaatteToplamYakit=bMWYakit.toplamYakit(5)+mercedesYakit.toplamYakit(5)+porscheYakit.toplamYakit(5);
Console.WriteLine("Araçların 5 saate tükettiği toplam yakıt:"+besSaatteToplamYakit.ToString()+"L");


//ARRAY NEDİR?

/*Array (Dizi), aynı türdeki verileri bir arada saklamaya yarayan bir veri yapısıdır.
  Dizi, bellekte sabit bir boyutta yer kaplar ve elemanlarına indeks (index) numarası ile erişilir.
  Dizinin ilk elemanı 0. indekstir.
  
  int[] sayilar = new int[7]; // 7 elemanlı bir integer dizisi oluşturur.
  sayilar[0] = 12;  // İlk elemana 12 değeri atanır.
  sayilar[1] = 3;  // İkinci elemana 3 değeri atanır.
  

  int[] sayilar = { 15, 24, 38, -9, 0 }; //Dizi tanımlanırken başlangıç değerleri bu şekilde de atanabilir.
  Console.WriteLine(sayilar[0]); // Dizinin elemanlarına bu şekilde erişebiliriz //Çıktı=15
  Console.WriteLine(sayilar[3]); // Dizinin elemanlarına bu şekilde erişebiliriz //Çıktı=-9
  

 */

