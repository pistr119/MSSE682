using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
using OLAPManager.Models.Service;

namespace OLAPManager.Models.Business
{

    /// <summary>
    /// Business layer supertype, from MSSE 680 W6 slides
    /// </summary>
    public abstract class Manager
    {

        private Factory factory = Factory.GetInstance();

        protected IService GetService(string name)  //not intended for outside inheritance
        {
            return factory.GetService(name);
        }
    }
}