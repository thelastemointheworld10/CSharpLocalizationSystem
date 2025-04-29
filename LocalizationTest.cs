using UnityEngine;
using Scripts.Localization;
// Just a test class, don't pay any attention.
public sealed class LocalizationTest : MonoBehaviour
{
    public void Initialize()
    {
        string test = LanguageManager.GetGlobalValue("somekey");
        Debug.Log($"Localization test: {test}");
    }
}
