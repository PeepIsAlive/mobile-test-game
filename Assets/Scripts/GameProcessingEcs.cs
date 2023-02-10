using Leopotam.Ecs;
using UnityEngine;
using Settings;
using Systems;

public sealed class GameProcessingEcs : MonoBehaviour
{
    private EcsWorld _world;
    private EcsSystems _systems;

    [SerializeField] private SettingsProvider _settingsProvider;

    private void Awake()
    {
        _world = new EcsWorld();
        _systems = new EcsSystems(_world);
    }

    private void Start()
    {
        _systems
            .Inject(_settingsProvider)
            .Inject(new WorldGenerator(_settingsProvider))
            .Init();
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
