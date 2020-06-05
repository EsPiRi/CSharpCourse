using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        //private sadece bulunduğu class içerisinde kullanılabilir.
        private string Name;
        //protected bulunduğu classlarda ve inheritance ilişkisi bulunan classlarda kullanılabilir.
        protected int Id { get; set; }


        public void Save()
        {

        }

        public void Delete()
        {

        }
    }

    class Student : Customer
    {
        public void Save2()
        {

        }
    }

    //internal başka classlarda using keywordunu kullanmadan dahil etmeyi saglar.
    internal class Course2
    {
        public string Name { get; set; }
        
        //private class sadece içiçe classlarda kullanılabilir. Aksi halde private veya protected class olmaz.
        private class NestedClass
        {
            
        }
    }
//public başka projelerde de using kullanılmak suretiyle classtan obje üretilmesini sağlar.
    public class Course
    {
        public string Name { get; set; }
        
        //private class sadece içiçe classlarda kullanılabilir. Aksi halde private veya protected class olmaz.
        private class NestedClass
        {
            
        }
    }

}
