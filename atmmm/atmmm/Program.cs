using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmmm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;

            //bakiye görüntüleme 
            //para çekme
            //para yatırma
            // q ya basarak çıkış yap



            Console.WriteLine("Atmye hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz:" + bakiye);
                Console.ReadLine();

            }

            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");

                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kalan tutar:" + (bakiye - cekilecek_tutar));
                Console.ReadLine();

            }

            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                int yatirilacak_tutar = Convert.ToInt32((Console.ReadLine()));
                Console.WriteLine("Yeni bakiyeniz:" + (bakiye + yatirilacak_tutar));
                Console.ReadLine();
            }
            else if (secim == "q")
            {
                Console.WriteLine("Atmden çıkış yapılıyor");
                Console.WriteLine("çıkış yapıldı iyi günler...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
                Console.ReadLine();


            }
        }
    }
} 


