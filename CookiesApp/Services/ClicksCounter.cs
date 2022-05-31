using System;

namespace CookiesApp.Services
{
    public class ClicksCounter : IServiceProvider
    {
        public int NoOfClicks;

        public ClicksCounter()
        {
            NoOfClicks = 0;
            IncrementClicks();
        }

        public ClicksCounter(object serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        public object ServiceProvider { get; }

        public object GetService(Type serviceType)
        {
            return ServiceProvider;
        }

        public void IncrementClicks()
        {
            NoOfClicks++;
        }

        public int GetClicks()
        {
            return NoOfClicks;
        }
    }
}
