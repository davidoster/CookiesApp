using System.Collections.Generic;

namespace CookiesApp.Models
{
    public interface ICookie
    {
        public KeyValuePair<string, string> KeyValue { get; set; }
    }
}
