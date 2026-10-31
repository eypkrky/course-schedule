# Course Schedule

Öğretim elemanı, derslik, ders, bölüm ve fakülte yönetimi ile ders programı oluşturmayı sağlayan Windows Forms uygulaması.

## Özellikler

- Rol tabanlı giriş ekranı
- Fakülte, bölüm, öğretim elemanı, ders, grup ve derslik yönetimi
- Otomatik ders dağıtımı
- Takvim üzerinden manuel ders atama ve silme
- Öğretim elemanı çakışması ve sınıf kapasitesi gibi kısıt kontrolleri
- SQL Server üzerinde kalıcı veri yönetimi

## Teknolojiler

- C# / .NET 10
- Windows Forms
- Microsoft SQL Server
- `Microsoft.Data.SqlClient`
- MetroModernUI

## Proje Yapısı

- `CourseSchedule(Kaynak Kodları)/`: Uygulamanın kaynak kodu ve çözüm dosyası
- `CourseSchedule_DB.sql`: Veritabanı kurulum scripti
- `CourseScheduleErDiyagramı.png`: ER diyagramı
- `GPFinalRaporTaslagi.pdf` ve `AirportDB.pdf`: Teslim/analiz dokümanları

## Kurulum

1. SQL Server'ı yerelde çalıştırın.
2. `CourseSchedule_DB.sql` dosyasını SQL Server Management Studio'da çalıştırın.
3. Bağlantı ayarını gerekirse `CourseSchedule(Kaynak Kodları)/DatabaseHelper.cs` içinde kendi SQL Server örneğinize göre güncelleyin.
4. `CourseSchedule(Kaynak Kodları)/CourseSchedule.slnx` dosyasını Visual Studio ile açın ve derleyin; ya da proje klasöründe `dotnet build` çalıştırın.

## Gereksinimler

- .NET 10 SDK ve Windows
- SQL Server / SQL Server Express
- Visual Studio 2022 veya daha yeni bir sürüm (önerilir)

## Durum

Kaynak kodu .NET 10 ile başarıyla derlenmektedir. `MetroModernUI` paketinin modern .NET hedefi için uyumluluk uyarısı vermesi mümkündür.

## Ekip

Eyüp Karakaya ve Kağan Kemal Üre
