using Leopotam.Ecs;
using Components;
using Core;

namespace Systems
{
    public sealed class WorldGenerationSystem : IEcsInitSystem, IEcsRunSystem
    {
        private EcsWorld _world;
        private EcsFilter<NpcGenerationComponent> _npcGenerationFilter;

        public void Init()
        {

        }

        public void Run()
        {
            foreach (var i in _npcGenerationFilter)
            {

            }
        }

        private Npc GenerateNpc(NpcGenerationComponent component)
        {
            var person = new Person
            (
                component.Gender, component.Age, component.Name, component.LastName
            );
            
            return new Npc(person);
        }
    }
}
