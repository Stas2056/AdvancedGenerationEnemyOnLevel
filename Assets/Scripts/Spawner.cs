using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int _spawnerNumber;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _target;
    [SerializeField] private SpawnerScreamer _spawnerScreamer;

    private void OnEnable()
    {
        _spawnerScreamer.Spawn += SpawnEnemy;
    }

    private void OnDisable()
    {
        _spawnerScreamer.Spawn -= SpawnEnemy;
    }

    private void SpawnEnemy(int spawnerNumber)
    {
        if (spawnerNumber == _spawnerNumber)
        {
            Enemy enemy = Instantiate(_enemy, transform.position, transform.rotation);
            Observer follover = enemy.GetComponent<Observer>();
            follover._target = _target;
        }
    }
}