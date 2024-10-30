# Film Değerlendirme Uygulaması

## İçindekiler
- [Proje Hakkında](#proje-hakkında)
- [Özellikler](#özellikler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Kod Yapısı](#kod-yapısı)

## Proje Hakkında
Film Değerlendirme Uygulaması, kullanıcıların film bilgilerini girmesine ve bu filmleri farklı kriterlere göre filtrelemesine olanak tanıyan basit bir konsol uygulamasıdır. Kullanıcı, her film için ismi ve IMDB puanını belirtebilir. Uygulama, girilen filmleri listeleme ve belirli kriterlere göre filtreleme işlevselliğine sahiptir.

## Özellikler
- Kullanıcıdan film ismi ve IMDB puanı alma.
- Girilen filmleri listeleme.
- IMDB puanı 4 ile 9 arasında olan filmleri filtreleme.
- İsmi 'A' ile başlayan filmleri filtreleme.
- Kullanıcı dostu hata mesajları ile kullanıcıyı yönlendirme.

## Kurulum
Projenin çalışabilmesi için aşağıdaki adımları izleyin:

1. **Gereksinimler**: 
   - .NET SDK (en az .NET 5.0) veya Visual Studio (C# geliştirme desteği ile).
   - Git (projenin klonlanması için).

2. **Projenin Klonlanması**:
   Terminal veya komut istemcisini açın ve aşağıdaki komutu kullanarak projeyi klonlayın:
   ```bash
   git clone https://github.com/kullaniciadi/projeadi.git
   ```

3. **Proje Klasörüne Gitme**:
   ```bash
   cd projeadi
   ```

4. **Gerekli Paketlerin Yüklenmesi**: Eğer projeniz bağımlılıklara sahipse, bunları yüklemek için aşağıdaki komutu kullanın:
   ```bash
   dotnet restore
   ```

## Kullanım
1. **Uygulamayı Başlatın**: Terminalde aşağıdaki komutu girerek uygulamayı başlatın:
   ```bash
   dotnet run
   ```

2. **Film Bilgilerini Girin**:
   - Konsolda "Film İsmini Girin:" ifadesi göreceksiniz. Film ismini girin ve "Enter" tuşuna basın.
   - Ardından, "IMDB Puanını Girin (0-10 arasında):" ifadesi ile karşılaşacaksınız. 0 ile 10 arasında bir puan girin. Geçersiz bir puan girerseniz, hata mesajı alacaksınız ve tekrar girmeniz istenecek.

3. **Filmleri Listeleme**: 
   - Uygulama, eklediğiniz tüm filmleri ve IMDB puanı 4 ile 9 arasında olan filmleri listeleyecek.
   - Ayrıca, ismi 'A' ile başlayan filmleri de ayrı bir başlık altında listeleyecektir.

4. **Devam Etme Seçeneği**: Uygulama, yeni bir film eklemek isteyip istemediğinizi soracak. "evet" veya "hayır" yazarak yanıt verebilirsiniz.

## Kod Yapısı
Proje, temel olarak `Film` sınıfını ve `Program` sınıfını içermektedir.

### Film Sınıfı
```csharp
public class Film
{
    public string Isim { get; set; }
    public double ImdbPuani { get; set; }
}
```
- **Isim**: Filmin adı.
- **ImdbPuani**: Filmin IMDB puanı.

### Program Sınıfı
- Kullanıcıdan veri alma, doğrulama ve listeleme işlevlerini içerir. Bu sınıf, kullanıcı arayüzü ile doğrudan etkileşimde bulunur.

