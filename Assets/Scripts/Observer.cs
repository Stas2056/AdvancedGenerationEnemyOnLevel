using UnityEngine;

public class Observer : MonoBehaviour
{
    [SerializeField] public Transform _target;

    private void Update()
    {
        var direction = (_target.position - transform.position).normalized;
        transform.right = direction;
    }
}