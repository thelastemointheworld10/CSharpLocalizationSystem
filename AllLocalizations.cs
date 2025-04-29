using UnityEngine;

namespace Scripts.Localization
{
    public sealed class AllLocalizations : MonoBehaviour
    {
        public static Localization Russian = new Localization();
        public static Localization English = new Localization();

        public void Initialize()
        {
            Russian.AddPhrase("somekey", "некое значение");
            English.AddPhrase("somekey", "some value");

            LanguageManager.SetGlobalLocalization(ref Russian);
        }
    }
}