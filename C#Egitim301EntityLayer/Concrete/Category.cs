using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Egitim301EntityLayer.Concrete
{
    public class Category
    {
        public string CategoryName { get; set; }
        public int CategoryID { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }


    }
}
/*
 * Field-Variable-Property
 * int x;(bir sınıfın içerisine doğrudan tanımlanırsa bu bir field'dır)
 * public int X { get; set; }(bir sınıfın içerisine tanımlanırsa bu bir property'dir)
 * void test(){}(bir sınıfın içerisine tanımlanırsa bu bir variable'dır)
*/