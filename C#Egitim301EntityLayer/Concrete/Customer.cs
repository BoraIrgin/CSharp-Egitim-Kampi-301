using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Egitim301EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerDistrict { get; set; }
        public List<Order> Orders { get; set; }
        public bool CustomerStatus { get; set; }

        /*
         * SOLID Prensipleri
         * 
         * S: Single Responsibility Principle (Tek Sorumluluk Prensibi)(Bir sınıfın sadece bir sorumluluğu olmalıdır)
         * O: Open/Closed Principle (Açık/Kapalı Prensibi)(Bir sınıfın değişime kapalı, genişlemeye açık olması gerekir)
         * L: Liskov Substitution Principle (Liskov Yerine Geçme Prensibi)(Bir sınıfın alt sınıfları, üst sınıfın yerine geçebilmelidir)
         * I: Interface Segregation Principle (Arayüz Ayrımı Prensibi)(Bir sınıf, kullanmadığı arayüzleri implement etmemelidir)
         * D: Dependency Inversion Principle (Bağımlılıkların Tersine Çevrilmesi Prensibi)(Bir sınıf, üst sınıflara değil, alt sınıflara bağımlı olmalıdır)
         */
    }
}
