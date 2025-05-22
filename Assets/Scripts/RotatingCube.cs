using UnityEngine;

public class RotatingCube : MonoBehaviour, IRotate
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _rotateX;
    [SerializeField] private bool _rotateY;
    [SerializeField] private bool _rotateZ;

    private Vector3 _axisX = Vector3.right;
    private Vector3 _axisY = Vector3.up;
    private Vector3 _axisZ = Vector3.forward;

    private Vector3 _direction;

    private void Update()
    {
        Rotate();
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

        transform.Rotate(_direction * _speed * Time.deltaTime, Space.Self);
    }
}
