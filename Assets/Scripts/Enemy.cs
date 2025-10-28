using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Follover _follover;

    public void Init(Transform target)
    {
        _follover.Init(target);
    }
}