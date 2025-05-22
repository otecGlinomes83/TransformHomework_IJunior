using UnityEngine;

public class ForwardSphere : MonoBehaviour, IMove
{
    [SerializeField] private float _speed;
    private Vector3 _movementDirection = Vector3.forward;

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(_movementDirection * _speed * Time.deltaTime);
    }
}