using Leopotam.Ecs;
using UnityEngine;

public sealed class GameProcessingEcs : MonoBehaviour
{
    private EcsWorld _world;
    private EcsSystems _systems;

    private void Awake()
    {
        _world = new EcsWorld();
        _systems = new EcsSystems(_world);
    }

    private void Start()
    {
        _systems.Init();
    }

    private void Update()
    {
        _systems?.Run();
    }

    private void OnDestroy()
    {
        _systems?.Destroy();
        _systems = null;

        _world?.Destroy();
        _world = null;
    }
}
