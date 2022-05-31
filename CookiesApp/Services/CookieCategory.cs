using System;
using System.Diagnostics;

namespace CookiesApp.Services
{
    // this uses different Service implementations such as
    // ClicksCounter
    // UserSettings
    // IdentityUser
    // and stores to the browser inside a cookie the key,value pair that is supplied by the cookie
    public class CookieCategory<KeyValuePair, IServiceProvider> //: ICookieCategory
    {
        private readonly IServiceProvider _serviceProvider;
        public CookieCategory(KeyValuePair keyValuePair, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void ManageClicks()
        {
            if(_serviceProvider.GetType() == typeof (ClicksCounter))
            {
                var myClicksCounter = new ClicksCounter(_serviceProvider);
                myClicksCounter.IncrementClicks();
                Debug.WriteLine(myClicksCounter.GetClicks());
            }
            
        }
    }
}
