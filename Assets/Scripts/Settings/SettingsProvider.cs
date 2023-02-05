using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Settings
{
    [CreateAssetMenu(menuName = "Settings/Providers/SettingsProvider", fileName = "SettingsProvider", order = 52)]
    public sealed class SettingsProvider : ScriptableObject
    {
        [field: SerializeField] public List<ScriptableObject> Settings { get; private set; }

        public T GetComponent<T>() where T : ScriptableObject
        {
            return (T)Settings.FirstOrDefault(x => x is T);
        }
    }
}
