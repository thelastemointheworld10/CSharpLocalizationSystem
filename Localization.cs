using System.Collections.Generic;

namespace Scripts.Localization
{
    public class Localization
    {
        private Dictionary<string, string> _language = new Dictionary<string, string>();

        public void AddPhrase(string key, string value) => _language.Add(key, value);
        public void RemovePhrase(string key) => _language.Remove(key);

        public string GetPhrase(string key) => _language[key];
    }
}
