using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

namespace Settings
{
    [CreateAssetMenu(menuName = "Settings/PersonViewSettings", fileName = "PersonViewSettings", order = 52)]
    public sealed class PersonViewSettings : ScriptableObject
    {
        [SerializeField] private List<PersonImage> _personImages;

        public bool TrySetImageForNpc(out string imageId)
        {
            imageId = string.Empty;

            // to do: пробежаться по фильтру нпс из апликейшна

            return !string.IsNullOrEmpty(imageId);
        }

        public bool TryGetNpcImage(string imageId, out Sprite npcImage)
        {
            npcImage = _personImages.FirstOrDefault(x => x.Id == imageId).Sprite;

            return npcImage != default;
        }

        [ContextMenu("Reset id")]
        private void SetNewId()
        {
            _personImages.ForEach(x =>
            {
                x.Id = Guid.NewGuid().ToString();
            });
        }

        [Serializable]
        public sealed class PersonImage
        {
            public Sprite Sprite;
            public string Id;
        }
    }
}
