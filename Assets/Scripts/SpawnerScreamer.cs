using System;
using UnityEngine;

public class SpawnerScreamer : MonoBehaviour
{
    [SerializeField] private float _delay = 2;
    [SerializeField] private int _spawnersCount = 3;

    public event Action<int> Spawn;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnScream), 0f, _delay);
    }

    private void SpawnScream()
    {
        int spawnerNumber = UnityEngine.Random.Range(1, _spawnersCount + 1);
        Spawn(spawnerNumber);
    }
}