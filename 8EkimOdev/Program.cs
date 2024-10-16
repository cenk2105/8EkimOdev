using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8EkimOdev
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci(1234, "Cenk", "Koc", 90, 100, "Karabuk");            
            int islem = 0;

            Console.WriteLine("1: Bilgi Goster , 2: Ortalama Goster, 3: Okul Goster , 4: Cikis Yap");
            try { 
                islem = Convert.ToInt16(Console.ReadLine());
            }
            catch ( Exception e) {  Console.WriteLine(e.Message); }

           
            switch (islem)
            {
                case 1:
                    ogrenci1.ogrenciBilgiGoster();
                    break;
                case 2:
                    ogrenci1.ogrenciOrtalamasiBul();
                    break;
                case 3:
                    Console.WriteLine(ogrenci1.okulGetir());
                    break;
                case 4:
                    Console.WriteLine("Cikis yapildi !!!");
                    break;
                default:
                    Console.WriteLine("Secim yapmadiniz !!!");
                    break;
            }

           
            
        
            Console.ReadLine();

        }
    }
}
