using Microsoft.AspNetCore.Http;

namespace CookiesApp.Services
{
    public class CookieService : ICookieService
    {
        private readonly HttpContext _context;
        
        public CookieService(IHttpContextAccessor contextAccesor)
        {
            _context = contextAccesor.HttpContext;
        }

        public void Add(string key, string value)
        {
            _context.Response.Cookies.Append(key, value);
        }

        public string Get(string key)
        {
            if (_context.Request.Cookies.ContainsKey(key))
            {
                return _context.Request.Cookies[key];
            }
            return null;
        }

        public void Remove(string key)
        {
            if (_context.Request.Cookies.ContainsKey(key))
            {
                _context.Request.Cookies.Keys.Remove(key);
            }
        }
    }
}
