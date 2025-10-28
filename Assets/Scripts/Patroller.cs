using UnityEngine;

public class Patroller : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float speed = 10;

    private int _currentWaypoint = 0;

    private void Update()
    {
        if (transform.position == _waypoints[_currentWaypoint].position)
        {
            _currentWaypoint = ++_currentWaypoint % _waypoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position,
                                                 _waypoints[_currentWaypoint].position, speed * Time.deltaTime);
    }
}