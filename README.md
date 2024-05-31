# C# İLE OOP TEMELLERİ: ADIM ADIM KATMANLI MİMARİ

Bu projede ASP .NET Core 7.0 ve MVC gibi en güncel Microsoft teknolojilerini kullanarak geliştirilmiş üç proje bulunmaktadır Demo-Proje,Product ve agriculture portfolyo projesi. Bu proje,  okulda  kullanabileceğiniz kapsamlı ve işlevsel bir web uygulaması sunar.

## Proje Özeti

Bu proje kapsamında:

- ASP.NET Core 7.0 (Visual Studio 2022 kullanarak)
- MVC (Model View Controller)
- Katmanlı Mimari
- Entity Framework Core
- ASP.NET Core Identity (Login ve Yetkilendirme)
- Repository Pattern

gibi modern yazılım geliştirme tekniklerini kullanarak profesyonel bir web uygulaması geliştirdim. SOLID ve Clean Code prensiplerini C# programlama dili ile uygulayarak, genişletilebilir ve sürdürülebilir bir kod tabanı oluşturmayı hedefledim.

## Proje Özellikleri

Bu projede:

- OOP tabanında "metot, sınıf, nesne" gibi kavramları uygulamalı olarak öğrendim ve kullandım.
- OOP tabanında veri tabanı uygulaması geliştirdim.
- Katmanlı Mimari Yapısı hakkında bilgi sahibi oldum ve bu yapıyı projede uyguladım.
- SQL veri tabanında DML komutlarını (Select, Insert, Update, Delete) etkin bir şekilde kullandım.
- Prosedürler ve tetikleyiciler yazdım.
- Entity, Facade, Business Logic gibi katmanları tanıdım ve projede uyguladım.
- Veri tabanında filtreleme işlemleri gerçekleştirdim.
- SQL'de en optimal veri tipleri ile tablo ve veri tabanı oluşturmayı öğrendim.
- Temel OOP yapısı hakkında bilgi sahibi oldum ve uygulamalı projeler geliştirdim.

## Kullanılan Teknolojiler

- **ASP.NET Core 7.0**
- **Visual Studio 2022**
- **Microsoft SQL Server 2022**
- **Entity Framework Core**
- **ASP.NET Core Identity**
- **MVC (Model View Controller)**
- **Repository Pattern**

## Kurulum ve Başlarken

### Gereksinimler

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) veya [Visual Studio Code](https://code.visualstudio.com/)
- SQL Server (veya başka bir veritabanı sunucusu)

### Kurulum Adımları

1. Bu depoyu klonlayın veya indirin:

    ```sh
    git clone https://github.com/kullanıcıadı/projeadı.git
    ```

2. Proje dizinine gidin:

    ```sh
    cd projeadı
    ```

3. Gerekli bağımlılıkları yükleyin:

    ```sh
    dotnet restore
    ```

4. Veritabanını oluşturun ve uygulayın:

    - `appsettings.json` dosyasındaki bağlantı dizesini (`ConnectionStrings:DefaultConnection`) kendi veritabanı ayarlarınıza göre güncelleyin.
    
    - Veritabanı migration'larını uygulayın:

      ```sh
      dotnet ef database update
      ```

### Kullanım

Uygulamayı çalıştırmak için aşağıdaki komutu kullanın:

```sh
dotnet run
