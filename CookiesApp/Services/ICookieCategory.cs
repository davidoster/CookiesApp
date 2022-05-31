using System;
using System.Collections.Generic;

namespace CookiesApp.Services
{
    public interface ICookieCategory : IServiceProvider
    {
        // properties

        // methods


        void ManageClicks(ClicksCounter clicksCounter);

        void ManageUserSettings(UserSettings userSettings);
    }
}
