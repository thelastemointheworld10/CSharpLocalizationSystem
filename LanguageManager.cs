using System.Collections.Generic;

namespace Scripts.Localization
{
    public sealed class LanguageManager
    {
        private static Localization _globalLocalization;

        public static void SetGlobalLocalization(ref Localization localization) => _globalLocalization = localization;

        public static string GetGlobalValue(string key) => _globalLocalization.GetPhrase(key);
    }
}