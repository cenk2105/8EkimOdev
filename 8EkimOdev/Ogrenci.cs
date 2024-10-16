using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8EkimOdev
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private double vize;
        private double final;
        private string okul;

        public Ogrenci(int ogrenciNo,string isim,string soyisim,double vize,double final,string okul)
        {
            this.ogrenciNo = ogrenciNo;
            this.isim = isim;
            this.soyisim = soyisim;
            this.vize = vize;
            this.final = final;
            this.okul = okul;
        }

        public void ogrenciBilgiGoster()
        {
            Console.WriteLine($"Numara : {this.ogrenciNo} \nIsim : {this.isim}\n" +
                              $"Soyisim : {this.soyisim}\nVize : {this.vize}\n" +
                              $"Final : {this.final}\nOkul : {this.okul}");
        }

        public void ogrenciOrtalamasiBul()
        {
            double ortalama = this.vize * 0.4 + this.final * 0.6;
            Console.WriteLine("{0} ogrencinin ortalamasi : {1}",this.isim,ortalama);
        }
        public string okulGetir()
        {
            return this.okul;
        }
        

        
        


    }
}
