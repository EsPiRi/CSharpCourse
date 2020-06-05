using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Concrete;

namespace Northwind.Business
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
