using UnityEngine;

public class GrowingCapsule : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localScale += Vector3.one * (_speed * Time.deltaTime);
    }
}