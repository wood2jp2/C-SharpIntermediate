using System;
using System.Collections.Generic;
namespace Indexers
{
    public class HttpCookie
    {
        readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>(); // defaults to private value

        // unnecessary
        // public HttpCookie() => _dictionary = new Dictionary<string, string>();

        public DateTime ExpiryTime
        {
            get;
            set;
        }
 
        // Use this
        public string this[string key] {
            get => _dictionary[key];
            
            set => _dictionary[key] = value; // value is a keyword representing what is on the right side of the operator
            
        }

        // AS OPPOSED TO setting the get / set stuff like this

        public string GetKey(string key) {
            return _dictionary[key];
        }

        public void SetKey(string key, string value) {
            _dictionary[key] = value;
        }

    }
}
