using System.Collections.Generic;
using UnityEngine;
using System;

namespace Settings
{
    [CreateAssetMenu(menuName = "Settings/PersonSettings", fileName = "PersonSettings", order = 52)]
    public sealed class PersonSettings : ScriptableObject
    {
        [field: SerializeField] public List<PersonSprite> PersonSprites;

        [Serializable]
        public class PersonSprite
        {
            public Sprite Sprite;
            public string Id;
        }
    }
}
