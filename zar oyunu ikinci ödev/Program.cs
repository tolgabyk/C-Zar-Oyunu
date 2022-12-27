using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zar_oyunu_ikinci_ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            zar_oyunu zarlarr = new zar_oyunu();

            zarlarr.kisi_bilgileri();
            zarlarr.zar();
            Console.ReadKey();

        }
        public class zar_oyunu
        {
            public string adi;
            public string soyadi;
            public int dogum_ayi;
            public int hak;
            public int puan;
            public int zar_Sayi;
            public List<int> eskiler;
            
            
      

            public void kisi_bilgileri()
            {
                Console.Write("Adınız: ");
                adi = Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyadi = Console.ReadLine();
                Console.Write("Doğum ayınız: ");
                dogum_ayi = Convert.ToInt32(Console.ReadLine());

            
            }

            public void zar()
            {
                
                puan = 0;
                hak = 0;
                eskiler = new List<int>();

                

                while (hak < 10 )
                {
                    Random secim = new Random();
                    zar_Sayi = secim.Next(1, 7);

                    if (adi.Length > soyadi.Length)
                    {
                        puan += 50;
                    }
                    else if (adi.Length == soyadi.Length)
                    {
                        puan += 25;
                    }
                    else if (adi.Length < soyadi.Length)
                    {
                        puan -= 10;
                    }



                    if (dogum_ayi <= 6)
                    {
                        puan += 30;
                    }
                    else if (dogum_ayi >= 7)

                    {
                        puan -= 20;
                    }




                    if (zar_Sayi == 1)
                    {
                        hak += 1;
                        Console.Write("Sayın {0} {1} -- KALAN HAKKINIZ: {2} -- Devam etmek için enter' a basınız... ", adi, soyadi,(10-hak));
                        Console.ReadLine();
                        puan -= 75;
                        
                        eskiler.Add(zar_Sayi);
                    }
                    else if (zar_Sayi == 6)
                    {
                        hak += 1;
                        Console.Write("Sayın {0} {1} -- KALAN HAKKINIZ: {2} -- Devam etmek için enter' a basınız... ", adi, soyadi, (10-hak));
                        Console.ReadLine();
                        puan += 100;
                        
                        eskiler.Add(zar_Sayi);


                    }
                    else
                    {
                        Console.Write("Sayın {0} {1} -- KALAN HAKKINIZ: {2} -- Devam etmek için enter' a basınız...", adi, soyadi,(10-hak));
                        Console.ReadLine();
                        eskiler.Add(zar_Sayi);
                    }

                }

                if (hak == 10 && puan >=500)
                {
                    Console.WriteLine("OYNANAN OYUN BOYUNCA GELEN ZARLAR: ");
                    foreach (int x in eskiler)
                    {
                        Console.Write(x);
                        Console.ReadLine();

                    }

                    Console.WriteLine("TEBRİKLER OYUNU KAZANDINIZ -- PUANINIZ: {0}",puan);
                    
                    
                }
                else if (hak == 10 && puan < 500)
                {
                    Console.WriteLine("OYNANAN OYUN BOYUNCA GELEN ZARLAR: ");
                    foreach (int x in eskiler)
                    {
                        Console.Write(x);
                        Console.ReadLine();


                    }
                
                    Console.Write("MAALESEF KAYBETTİNİZ TEKRAR DENEYİN -- PUANINIZ: {0}",puan);
                    
                }


            }
            

        
        }

    }
}
