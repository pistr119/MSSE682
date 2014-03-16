using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;

namespace OLAPManager.Models.Service
{

    /// <summary>
    /// Class is for Factory design pattern, introduced in MSSE W4 Slides.  Enhanced with "Singleton" pattern, slide 41, W5
    /// </summary>
    public class Factory  
    {
        private Factory() { } //singleton pattern, slide42, W5
        private static Factory factory = new Factory();
        public static Factory GetInstance() { return factory; }


        public IService GetService(string serviceName) {
            Type type;
            Object obj = null;

            try
            {
                type = Type.GetType(GetImplName(serviceName)); //looks up impl name in app.config
                obj = Activator.CreateInstance(type); //Dynamically instantiates implementation class
            }
            catch(Exception e)
            {
                Console.WriteLine ("Exception occurred:  {0}:", e);
                throw new Exception(e.Message);
            }

            return (IService)obj;
        
        }

        /// <summary>
        /// method looks up implementation name in app.config file
        /// </summary>
        /// <param name="servicename"></param>
        /// <returns></returns>
        private string GetImplName(string servicename) 
        {
            NameValueCollection settings = ConfigurationManager.AppSettings;
            return settings.Get(servicename);

        }
    }
}