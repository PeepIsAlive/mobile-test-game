using System.Collections.Generic;
using Leopotam.Ecs;

namespace Core
{
    public sealed class Model : IEcsSystem
    {
        public List<EcsEntity> GetEntities<T>(EcsFilter<T> filter) where T : struct
        {
            var result = new List<EcsEntity>();

            if (filter == null)
                return result;
            
            foreach (var i in filter)
            {
                result.Add(filter.GetEntity(i));
            }

            return result;
        }
    }
}
