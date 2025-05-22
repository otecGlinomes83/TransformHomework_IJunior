using UnityEngine;

public class GrowingCapsule : MonoBehaviour, IGrow
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Grow();
    }

    public void Grow()
    {
        transform.localScale += Vector3.one * (_speed * Time.deltaTime);
    }
}