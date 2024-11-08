# 🚗 Araba Üretim Programı
Bu program, kullanıcıların arabalarını üretmesine olanak sağlar. Program, kullanıcıdan arabaların çeşitli özelliklerini alır ve üretim bilgilerini saklar. Üretilen arabaların verileri bir listede tutulur ve program sonunda bu arabaların bilgileri kullanıcıya gösterilir.

# ⚙️ Özellikler
• Kullanıcı, seri numarası, marka, model, renk, ve kapı sayısı gibi araba özelliklerini girebilir.

• Program, yalnızca harflerden oluşan marka, model ve renk girişlerine izin verir.

• Kapı sayısı, kullanıcıdan rakam olarak alınır ve hata kontrolü yapılır.

• Kullanıcı, bir araba üretildikten sonra başka bir araba üretmek isteyip istemediğini seçebilir.

• Üretilen arabaların tüm bilgileri ekranda listelenir.

# 🚗 Nasıl Çalışır?
## 1. Araba Üretme İsteği:
• Program başladığında, kullanıcıya "Araba üretmek ister misiniz?" sorusu sorulur. (Evet/Hayır)

## 2. Araba Özellikleri:
• Kullanıcı, araba özelliklerini girmek için yönlendirilir:

• Seri Numarası: Araba için benzersiz bir seri numarası girilir.

• Marka: Yalnızca harflerden oluşan bir marka adı girilir.

• Model: Yalnızca harflerden oluşan bir model adı girilir.

• Renk: Araba rengi yalnızca harflerden oluşan bir değer olmalıdır.

• Kapı Sayısı: Kullanıcıya kapı sayısını rakam olarak girilmesi istenir. Eğer geçersiz bir değer girilirse, hata mesajı görüntülenir ve tekrar girilmesi istenir.
## 3. Araba Üretim İşlemi:

•Tüm özellikler girildikten sonra, araba üretilir ve listemize eklenir.

•Üretim Tarihi: Araba üretildiği anın tarihi otomatik olarak kaydedilir.
## 4. Tekrar Araba Üretme:
• Kullanıcı, başka bir araba üretmek isteyip istemediğini belirleyebilir. Eğer evet derse, süreç baştan başlar. Hayır derse, üretim işlemi sonlandırılır.
## 5. Üretilen Arabaların Listesi:
• Son olarak, üretilen arabaların tüm bilgileri ekranda listelenir.

# 🖥️ Kodun Detayları
## Bu program C# dilinde yazılmıştır ve aşağıdaki işlevselliği içerir:

1. Kullanıcı Girdisi Kontrolleri:
Marka, model, ve renk gibi değerler yalnızca harflerden oluşmalıdır. Eğer kullanıcı yanlış bir şey girerse, program hata mesajı verir ve doğru girdi alınana kadar tekrar sormaya devam eder.
Kapı sayısı rakam olmalıdır, aksi takdirde program kullanıcıyı uyarır ve doğru girdi alınana kadar tekrar sorar.
2. Geriye Dönüş Yapma:
Kullanıcı "Araba üretmek ister misiniz?" sorusuna e veya h dışında bir cevap verdiğinde, geçerli bir cevap girene kadar program tekrar sorar.
3. Gelişmiş Hata Kontrolleri:
Kapı sayısı için, kullanıcı geçersiz bir giriş yaparsa, try-catch bloğu kullanılarak hatalar yönetilir ve kullanıcıya doğru formatta girdi yapması sağlanır.
4. Veri Depolama ve Listeleme:
Üretilen arabalar, Cars sınıfı üzerinden bir listede saklanır. Bu liste, program sonunda ekranda gösterilir.

# 📦 Nasıl Çalıştırılır?
1. Bu projeyi bilgisayarınıza indirin veya kopyalayın.
2. Visual Studio veya herhangi bir C# destekleyen IDE'yi kullanarak projeyi açın.
3. Projeyi çalıştırın ve arabanızın özelliklerini girmeye başlayın!

# 🛠️ Kod Örneği
```csharp
// Araba üretimi başlatılır
Cars newCar = new Cars();

// Kullanıcıdan seri numarası alınır
Console.Write("Seri Numarası : ");
string seriNum = Console.ReadLine().ToLower();
newCar.SeriNumarası = seriNum;

// Marka, model, renk ve kapı sayısı bilgileri alınır
Console.Write("Marka : ");
string marka = Console.ReadLine().ToLower();
newCar.Marka = marka;

// Diğer veriler alındıktan sonra, araba üretimi tamamlanır
arabalar.Add(newCar); 
newCar.UretimTarih = DateTime.Now;  // Üretim tarihi kaydedilir
```
# 📝 Notlar:
1. Eğer "e" yanıtını verirseniz, yeni araba üretmeye devam edebilirsiniz.
2. "h" yanıtı verirseniz, işlem sonlanır.
3. Üretilen arabaların bilgileri listelendiğinde, her bir araba için seri numarası, marka, model, renk, kapı sayısı, ve üretim tarihi görüntülenir.

# 🚀 Başka Özellikler?
1. Gelecekte, arabalara daha fazla özellik eklenebilir, örneğin motor tipi, fiyat gibi.
2. Programın daha karmaşık hale getirilmesi için veritabanı bağlantısı eklenebilir, böylece arabalar daha kalıcı olarak saklanabilir.
# 🎉 Teşekkürler!
### Bu projeyi kullandığınız için teşekkür ederiz! 🚗💨
