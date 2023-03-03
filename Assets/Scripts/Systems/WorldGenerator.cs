using Components;
using Settings;
using Core;

namespace Generator
{
    public sealed class WorldGenerator
    {
        private SettingsProvider _settingsProvider;

        public WorldGenerator(SettingsProvider settingsProvider)
        {
            _settingsProvider = settingsProvider;
        }

        public Npc GenerateNpc(NpcGenerationComponent component)
        {
            var person = new Person
            (
                component.Gender, component.Age, component.Name, component.LastName
            );
            
            return new Npc(person);
        }
    }
}
