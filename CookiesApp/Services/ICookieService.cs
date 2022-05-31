namespace CookiesApp.Services
{
    public interface ICookieService
    {
        // Add, Get, Remove
        void Add(string key, string value);
        void Remove(string key);
        string Get(string key);
    }
}
