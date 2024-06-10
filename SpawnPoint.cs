using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private EnemyTarget _target;

    public void Spawn()
    {
        Enemy enemy = Instantiate(_enemy, transform.position, Quaternion.identity);

        enemy.Initialize(_target);
    }
}
