using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Settings
{
    [CreateAssetMenu(menuName = "Settings/Providers/SettingsProvider", fileName = "SettingsProvider", order = 52)]
    public sealed class SettingsProvider : ScriptableObject
    {
        [SerializeField] private List<ScriptableObject> _settings;

        public T GetComponent<T>() where T : ScriptableObject
        {
            return (T)_settings.FirstOrDefault(x => x is T);
        }
    }
}
