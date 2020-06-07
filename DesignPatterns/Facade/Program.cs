using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.Save();
            Console.ReadLine();
        }
    }

    class Logging:ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    internal interface ILogging

    {
        void Log();
    }

    class Caching:ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    internal interface ICaching
    {
        void Cache();
    }

    class Authorize:IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("User Checked");
        }
    }
    class Validation:IValidate
    {
        public void Validate()
        {
            Console.WriteLine("Validated");
        }
    }

    internal interface IValidate
    {
        void Validate();
    }

    internal interface IAuthorize
    {
        void CheckUser();
    }

    class CustomerManager
    {
        private CCCFacade _concerns;
        //private ILogging _logging;
        //private ICaching _caching;
        //private IAuthorize _authorize;

        public CustomerManager(ILogging logging, ICaching caching, IAuthorize authorize)
        {
            _concerns=new CCCFacade();
            //_logging = logging;
            //_caching = caching;
            //_authorize = authorize;
        } 
        public CustomerManager()
        {
            _concerns=new CCCFacade();
            //_logging = logging;
            //_caching = caching;
            //_authorize = authorize;
        }

        public void Save()
        {
            _concerns.Caching.Cache();
            _concerns.Authorize.CheckUser();
            _concerns.Logging.Log();
            _concerns.Validation.Validate();
            //_logging.Log();
            //_caching.Cache();
            //_authorize.CheckUser();
            Console.WriteLine("Saved");
        }
    }

    /// <summary>
    /// CCC=>CrossCuttingConcerns
    /// </summary>
    class CCCFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;
        public IValidate Validation;

        public CCCFacade()
        {
            Logging=new Logging();
            Caching=new Caching();
            Authorize=new Authorize();
            Validation=new Validation();
        }
    }
}
