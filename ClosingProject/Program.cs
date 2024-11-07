using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using ClosingProject;

List<Cars> arabalar = new List<Cars>();
while (true)
{
    Console.WriteLine("Araba Üretmek ister misiniz? (e/h)"); // Kullanıcıdan araba üretip üretmek istemediğini soruyoruz.
    string cevap = Console.ReadLine().ToLower();

    if (cevap != "e" && cevap != "h") // Cevap evete veya hayır eşit değilse döngüye giriyor
    {
        Console.WriteLine("Lütfen geçerli bir cevap giriniz ('e' veya 'h') ");
    }
    else if (cevap == "h") // Cevap hayır verilirse.
    {
        Console.WriteLine("Araba üretimi iptal edildi.");
        break;
    }
    Cars newCar = new Cars(); // burda arabayı üretmeye başlıyoruz

    Console.WriteLine("** Lütfen bir Seri Numarası giriniz. **"); // Kullanıcıdan bir Seri numarası alıyoruz.
    Console.Write("Seri Numarası : ");
    string seriNum = Console.ReadLine().ToLower();
    newCar.SeriNumarası = seriNum;

MarkaAl:
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("** Lütfen Aracınızın Markasını giriniz. **"); // Aracın markasını alıyoruz.
    Console.Write("Marka : ");
    string marka = Console.ReadLine().ToLower();
    if (marka.All(char.IsLetter)) // Sadece harflerden olup olmadığını kontrol ediyoruz
    {
        newCar.Marka = marka;
    }
    else
    {
        Console.WriteLine("Marka sadece harflerden oluşmalıdır. Lütfen tekrar deneyin."); // Harflerden oluşmuyorsa bu hata blokuna giriyor
        goto MarkaAl;
    }

ModelAl:
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("** Lütfen Aracınızın Modelini giriniz. **"); // Aracın Modelini alıyoruz.
    Console.Write("Model : ");
    string model = Console.ReadLine().ToLower();
    if (model.All(char.IsLetter)) // Yine Harflerden oluşup oluşmadını kontrol bloku
    {
        newCar.Model = model;
    }
    else
    {
        Console.WriteLine("Marka sadece harflerden oluşmalıdır. Lütfen tekrar deneyin."); // rakam yada başka bir şey içeriyorsa bu kod blokuna giriyor
        goto ModelAl;
    }

RenkAl:
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("** Lütfen Aracınızın Rengini giriniz. **"); // Aracın Rengini alıyoruz.
    Console.Write("Renk : ");
    string Renk = Console.ReadLine().ToLower();
    if (Renk.All(char.IsLetter)) // Yine Harf kontrolü yapıyoruz
    {
        newCar.Renk = Renk;
    }
    else
    {
        Console.WriteLine("Renk sadece harflerden oluşmalıdır. Lütfen tekrar deneyin.");
        goto RenkAl;
    }

    Console.WriteLine("-------------------------------------------");
kapıSayısı:
    Console.WriteLine(" ** Lütfen Arabınızda kaç kapı olduğunu giriniz. ** ");
    Console.Write("Kapı Sayısı : ");

    // Kullanıcıdan alınan kapı sayısı kontrolü TRY-CATCH blokuna giriyor
    try
    {
        newCar.KapıSayısı = Convert.ToInt32(Console.ReadLine());
    }

    catch (FormatException)
    {
        Console.WriteLine("Lütfen Sadece rakam giriniz."); // eğer girilen kapı sayısı 2 değilde 2a ise hata döndürüyor
        goto kapıSayısı;
    }

    arabalar.Add(newCar); // Üretilen arabayı listemize ekliyoruz.
    newCar.UretimTarih = DateTime.Now; // Üretim Tarihini anlık olarak alıyoruz.

son:
    Console.WriteLine("Başka araba üretmek istiyor musunuz? (e/h)");
    string son = Console.ReadLine().ToLower();

    if (son == "e") // Eğer "e" verilirse döngüye devam etmeyip, bir daha sormamış oluyoruz.
    {
        continue;
    }
    else if (son == "h") // cevap hayır ise işlemi sonladırıyor
    {
        Console.WriteLine("Araba Üretim işlemi sona erdi");
        break; // döngüden çıkıyoruz.
    }
    else
    {
        Console.WriteLine("Lütfen geçerli bir cevap giriniz (e/h)");
        goto son;
    }
}
Console.WriteLine("-------------------------------------------");
Console.WriteLine("↓↓ Üretilen Arabalar ↓↓ "); // arabaları üretip yazdırıyoruz

foreach (var car in arabalar)
{
    Console.WriteLine($"Seri Numarası : {car.SeriNumarası} || Marka : {car.Marka} || Model : {car.Model} || Renk : {car.Renk} || Kapı Sayısı : {car.KapıSayısı} || Üretim Tarihi : {car.UretimTarih}");
}