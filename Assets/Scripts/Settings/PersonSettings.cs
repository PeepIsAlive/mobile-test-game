using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

namespace Settings
{
    [CreateAssetMenu(menuName = "Settings/PersonSettings", fileName = "PersonSettings", order = 52)]
    public sealed class PersonSettings : ScriptableObject
    {
        [SerializeField] private List<PersonImage> _personImages;

        public bool TryCreateNpcImage(string id)
        {
            if (!_personImages.Any(x => string.IsNullOrEmpty(x.Id) || x.Id == id))
                return false;

            foreach (var personSprite in _personImages)
            {
                if (!string.IsNullOrEmpty(personSprite.Id))
                    continue;

                personSprite.Id = id;
                break;
            }

            return true;
        }

        public bool TryGetNpcImage(string id, out Sprite npcImage)
        {
            npcImage = _personImages.FirstOrDefault(x => x.Id == id).Sprite;

            return npcImage != default;
        }

        [Serializable]
        public sealed class PersonImage
        {
            public Sprite Sprite;
            public string Id;
        }
    }
}
