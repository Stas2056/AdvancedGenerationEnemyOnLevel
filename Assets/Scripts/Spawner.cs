using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _delay = 2f;
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    private Coroutine _coroutine;

    private void Start()
    {
        _coroutine = StartCoroutine(nameof(SpawnEnemy), _delay);
    }

    private IEnumerator SpawnEnemy(float delay)
    {
        var wait = new WaitForSeconds(delay);
        bool isWork = true;

        while (isWork)
        {
            int pointNumber = Random.Range(0, _spawnPoints.Count);
            _spawnPoints[pointNumber].Spawn();

            yield return wait;
        }

        yield return null;
    }
}