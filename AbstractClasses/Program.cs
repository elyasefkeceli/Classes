using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    //Abstrack classlar normal classlardan farklı olarak ortak olan veya ortak olmayan operasyonlar içerebilir.
    //Tamamlanmış veya tamamlanmamış operasyonlar içerebilir.Bu yüzden new lenemez.
    //Bir class tek bir class ı inherit edebiliği için bir class sadece bir abstrack sınıfı inherit edebilir.
    //Abstrack sınıflar constraction içerebilir.Constraction sadece new de çalışabilir.Onu inherit eden sınıf newlendiği zaman çalışacaktır.Kendi başına çalışamazlar.
    //Abstract bir classın constraction ı protected olmaı gerekir.Çünkü sadece inherit edilebildiği yerde çalışır.
    class Program
    {
        static void Main(string[] args)
        {
            Amevzuat aMevzuat = new Amevzuat();
            aMevzuat.Degerlendir();
            aMevzuat.Kaydet();
            Console.ReadLine();
        }
    }
    abstract class MevzuatBase
    {
        protected MevzuatBase()
        {

        }
       public abstract void Degerlendir();
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi.");
        }
    }
    class Amevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("AMevzuatına göre değerlendirildi.");
        }
    }
    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("BMevzuatına göre değerlendirildi.");
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("eklendi");
        }
        public void Update()
        {
            Console.WriteLine("güncellendi");
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
