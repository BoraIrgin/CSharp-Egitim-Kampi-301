using C_Egitim301DataAccesLayer.Repositories;
using C_Egitim301EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Egitim301DataAccesLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, Abstract.ICategoryDal
    {

    }
}
