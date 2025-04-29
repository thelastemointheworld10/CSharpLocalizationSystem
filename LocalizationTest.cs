using UnityEngine;
using Scripts.Localization;

public sealed class LocalizationTest : MonoBehaviour
{
    public void Initialize()
    {
        string test = LanguageManager.GetGlobalValue("somekey");
        Debug.Log($"Localization test: {test}");
    }
}
