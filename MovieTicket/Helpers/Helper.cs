using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:/Users/ogune/Desktop/Dersler/OOP/MovieTicket/MovieTicket/Picture/";
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Avatar",
                    category = Enums.Category.Macera,
                    minute = "2 Saat 40 Dakika",
                    price = 50,
                    movieStory = "Pandora adında uzaktaki bir gezegene gittikten sonra Avatar programı ile kaynakların sömürülmesi amaçlanmaktadır. Avatar bedenine zihnini aktaran Jake Sully, Pandora’nın doğası ve oranın yerlileri olan Na’vi ile kurduğu bağ sayesinde projenin zararları konusunda aydınlanıyor ve projeye karşı gelip kendi türüne karşı savaşmaya karar veriyor.",
                    picturePath = basePath + "avatar.jpg"
                },
                new Movie()
                {
                    movieName = "Nefesini Tut",
                    category = Enums.Category.Gerilim,
                    minute = "1 Saat 28 Dakika",
                    price = 40,
                    movieStory = "Kız kardeşi ve kendisi için daha iyi bir hayata başlamak isteyen Rocky, sevgilisi Money ve arkadaşı Alex ile zengin bir kör adamın sahip olduğu evin soygununa katılmayı kabul eder. Fakat kör adamın göründüğü gibi birisi olmadığını fark ettiklerinde, adamın yeni kurbanları olmadan önce evden kaçmanın bir yolunu bulmak zorundadırlar.",
                    picturePath = basePath + "dont_breathe.jpg"
                },
                new Movie()
                {
                    movieName = "Gladyatör",
                    category = Enums.Category.Aksiyon,
                    minute = "2 Saat 35 Dakika",
                    price = 50,
                    movieStory = "Roma’da bir general olan Maximus, imparatorluğun hiyerarşik basamaklarında gitgide yükselmiştir. Babasının kendisini kayırmak yerine Maximus adındaki bir generali el üstünde tutması da tahtın asıl varisi olan Commodus’u rahatsız etmektedir. İmparator Marcus Aurelius'u öldürerek tahta oturan Commodus, Maximus ve ailesinin öldürülmesini emreder.",
                    picturePath = basePath + "gladiator.jpg"
                },
                new Movie()
                {
                    movieName = "Yıldızlararası",
                    category = Enums.Category.Bilim_Kurgu,
                    minute = "2 Saat 49 Dakika",
                    price = 60,
                    movieStory = "Dünya üzerindeki yaşamımız sona ererken, bir grup araştırmacı insanlık tarihinin en önemli görevini üstlenirler; Bulunduğumuz galaksinin ötesine yolculuk ederek insanlığın, yıldızların ötesinde yaşamını sürdürmesinin mümkün olup olmayacağını keşfe çıkarlar.",
                    picturePath = basePath + "interstellar.jpg"
                },
                new Movie()
                {
                    movieName = "Terminal",
                    category = Enums.Category.Komedi,
                    minute = "2 Saat 8 Dakika",
                    price = 50,
                    movieStory = "Krakozhia isimli bir ülkenin vatandaşı olan Viktor Navorski, JFK hava limanına giriş yaptığı an pasaportunun geçersiz olması nedeniyle Amerika'ya girme hakkını kaybeder. Ülkesine geri dönmek zorunda kalan talihsiz adam bu esnada havaalanında televizyonda yayınlanan haber bültenindeki bir habere takılır. Ülkesi Krakozhia'da sivil savaş çıkmıştır ve ABD artık ülkesini resmi olarak tanımamaktadır.",
                    picturePath = basePath + "the_terminal.jpg"
                },
                new Movie()
                {
                    movieName = "Titanik",
                    category = Enums.Category.Romantik,
                    minute = "3 Saat 14 Dakika",
                    price = 40,
                    movieStory = "Avrupa`da bir kaç yıl geçirdikten sonra Amerika`ya dönmekte olan, Jack adlı genç bir ressam ile nişanlısı ve annesiyle Philadelphia`ya giden Rose adlı genç bir kız da vardır. İki genç, yola çıkılmasından dört buçuk gün sonra buz dağına çarpması sonucu batacak gemide şans eseri tanışacak, aralarındaki sınıf farkına aldırmaksızın birbirlerine yakınlaşacaktır.",
                    picturePath = basePath + "titanic.jpg"
                }
            };
        }
    }
}
