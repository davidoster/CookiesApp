using System;
using System.Diagnostics;

namespace CookiesApp.Services
{
    // this uses different Service implementations such as
    // ClicksCounter
    // UserSettings
    // IdentityUser
    // and stores to the browser inside a cookie the key,value pair that is supplied by the cookie
    public class CookieCategory<IServiceImplementor> : ICookieCategory, IServiceProvider //<KeyValuePair, IServiceImplementor> : IServiceProvider
    {
        //private readonly KeyValuePair _keyValuePair;
        private readonly IServiceImplementor _serviceImplementor;

        public CookieCategory()
        {

        }

        public CookieCategory(IServiceImplementor serviceImplementor) //(KeyValuePair keyValuePair, IServiceImplementor serviceImplementor)
        {
            //_keyValuePair = keyValuePair;
           _serviceImplementor = serviceImplementor;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType.GetType() == typeof(ClicksCounter))
            {
                return _serviceImplementor;
            }
            if(serviceType.GetType() == typeof(UserSettings))
            {
                return _serviceImplementor;
            }
            return null;
        }

        public void ManageClicks(ClicksCounter clicksCounter)
        {
            clicksCounter.IncrementClicks();
            Debug.WriteLine(clicksCounter.GetClicks());
            //if(_serviceProvider.GetType() == typeof (ClicksCounter))
            //{
            //    var myClicksCounter = new ClicksCounter(_serviceProvider);
            //    myClicksCounter.IncrementClicks();
            //    Debug.WriteLine(myClicksCounter.GetClicks());
            //}

        }

        public void ManageUserSettings(UserSettings userSettings)
        {
            throw new NotImplementedException();
        }
    }
}
