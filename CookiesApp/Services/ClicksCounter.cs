namespace CookiesApp.Services
{
    public class ClicksCounter
    {
        public int NoOfClicks;

        public ClicksCounter()
        {
            NoOfClicks = 0;
            IncrementClicks();
        }

        public void IncrementClicks()
        {
            NoOfClicks++;
        }
        


    }
}
