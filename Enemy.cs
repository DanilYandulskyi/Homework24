using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour
{
    private Mover _movement;
    private EnemyTarget _target;

    private void Awake()
    {
        _movement = GetComponent<Mover>(); 
    }

    private void Update()
    {
        _movement.MoveToTarget(_target.transform.position);     
    }

    public void Initialize(EnemyTarget target)
    {
        _target = target;
    }
}
