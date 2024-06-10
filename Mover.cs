using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private float _speed;

    public void MoveToTarget(Vector3 position)
    {
        Vector2 direction = (position - transform.position).normalized * (_speed * Time.deltaTime);

        transform.Translate(direction);
    }

    public void MoveInDirection(Vector3 direction)
    {
        Vector3 offset = direction.normalized * (_speed * Time.deltaTime);

        transform.Translate(offset);
    }
}