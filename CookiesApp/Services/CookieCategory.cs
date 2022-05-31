using System;

namespace CookiesApp.Services
{
    // this uses different Service implementations such as
    // ClicksCounter
    // UserSettings
    // IdentityUser
    // and stores to the browser inside a cookie the key,value pair that is supplied by the cookie
    public class CookieCategory<KeyValuePair, IServiceProvider> : ICookieCategory
    {
        public void ManageClicks()
        {
            IServiceProvider.IncrementClicks();
        }
    }
}
