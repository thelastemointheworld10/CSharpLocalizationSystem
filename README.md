# CSharpLocalizationSystem

# How To Start?
create a localization game object on the scene, attach the AllLocalizations script to it
(all localizations are listed in it, you can add your own language and add some phrase there).
Then you need to initialize the script using the Initialize() method. Like this:
```
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
```
# How To Use?
Follow this example:
```
using UnityEngine;
using Scripts.Localization;

public class LocalizationTest : MonoBehaviour
{
    public void Initialize()
    {
        string test = LanguageManager.GetGlobalValue("somekey");
        Debug.Log($"Localization test: {test}");
    }
}
```
# Result:
![result](https://github.com/user-attachments/assets/ffd33daf-063c-4463-b3f3-bbb8d69c0e05)
