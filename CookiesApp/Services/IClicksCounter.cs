namespace CookiesApp.Services
{
    public interface IClicksCounter
    {
        void IncrementClicks();

        int GetClicks();
    }
}
