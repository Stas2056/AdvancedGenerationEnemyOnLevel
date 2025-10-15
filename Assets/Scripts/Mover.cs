using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed=10f;
    [SerializeField] int speedCoefficient=1000;

    private Vector3 _movementDirection;

    private void Start()
    {
        _movementDirection.x=speed/speedCoefficient;
    }

    private void Update()
    {
        transform.Translate(_movementDirection);
    }
}