using UnityEngine;

public class Follover : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private int _speed = 10;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,
                                                 _target.transform.position, _speed * Time.deltaTime);
    }

    public void Init(Transform target)
    {
        _target = target;
    }
}