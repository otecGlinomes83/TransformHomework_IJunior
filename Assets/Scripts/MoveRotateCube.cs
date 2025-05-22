using UnityEngine;

public class MoveRotateCube : MonoBehaviour, IMove, IRotate, IGrow
{
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _growingSpeed;

    [SerializeField] private bool _rotateX;
    [SerializeField] private bool _rotateY;
    [SerializeField] private bool _rotateZ;

    private Vector3 _axisX = Vector3.right;
    private Vector3 _axisY = Vector3.up;
    private Vector3 _axisZ = Vector3.forward;

    private Vector3 _direction;

    private void Update()
    {
        Move();
        Rotate();
        Grow();
    }

    public void Move()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime, Space.Self);
    }

    public void Rotate()
    {
        _direction = Vector3.zero;

        if (_rotateX)
            _direction += _axisX;

        if (_rotateY)
            _direction += _axisY;

        if (_rotateZ)
            _direction += _axisZ;

        if (_direction == Vector3.zero)
            return;

        _direction.Normalize();

        transform.Rotate(_direction * _rotateSpeed * Time.deltaTime, Space.Self);
    }
    
    public void Grow()
    {
        transform.localScale += Vector3.one * (_growingSpeed * Time.deltaTime);
    }
}
