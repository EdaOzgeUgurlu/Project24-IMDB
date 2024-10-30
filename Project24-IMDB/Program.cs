using Project24_IMDB;
using System.Globalization;
public class Program
{
    public static void Main(string[] args)
    {
        // Film listesini tutacak bir liste oluşturuyoruz.
        List<Film> filmler = new List<Film>();
        string devam; // Kullanıcının devam etmek isteyip istemediğini tutacak değişken

        // Kullanıcıdan film bilgileri almak için döngü
        do
        {
            // Yeni bir Film nesnesi oluşturuyoruz.
            Film yeniFilm = new Film();

            // Kullanıcıdan film ismini alıyoruz.
            Console.Write("Film İsmini Girin: ");
            yeniFilm.Isim = Console.ReadLine();

            double imdbPuani; // Geçici bir değişken tanımlıyoruz
            Console.Write("IMDB Puanını Girin (0-10 arasında): ");

            // Kullanıcıdan geçerli bir IMDB puanı almak için döngü
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out imdbPuani) || imdbPuani < 0 || imdbPuani > 10)
            {
                // Kullanıcıdan tekrar geçerli bir puan girmesini istiyoruz
                Console.Write("Geçerli bir IMDB puanı girin (0-10 arasında): ");
            }

            // Geçerli IMDB puanını filme atıyoruz
            yeniFilm.ImdbPuani = imdbPuani;

            // Yeni film nesnesini film listesine ekliyoruz
            filmler.Add(yeniFilm);

            // Kullanıcıya başka bir film eklemek isteyip istemediğini soruyoruz
            Console.Write("Başka bir film eklemek ister misiniz? (evet/hayır): ");
            devam = Console.ReadLine().ToLower();
        } while (devam == "evet"); // Kullanıcı "evet" derse döngü başa döner

        // Tüm filmleri listelemek için
        Console.WriteLine("\nTüm Filmler:");
        foreach (var film in filmler)
        {
            // Her bir film bilgilerini yazdırıyoruz
            Console.WriteLine($"Film İsmi: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
        }

        // IMDB puanı 4 ile 9 arasında olan filmleri listelemek için
        Console.WriteLine("\nIMDB Puanı 4 ile 9 arasında olan Filmler:");
        foreach (var film in filmler)
        {
            // Geçerli koşula uyan filmleri yazdırıyoruz
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
            {
                Console.WriteLine($"Film İsmi: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
            }
        }

        // İsmi 'A' ile başlayan filmleri listelemek için
        Console.WriteLine("\nİsmi 'A' ile başlayan Filmler:");
        foreach (var film in filmler)
        {
            // İsmi 'A' ile başlayan filmleri yazdırıyoruz
            if (film.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Film İsmi: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
            }
        }
    }
}