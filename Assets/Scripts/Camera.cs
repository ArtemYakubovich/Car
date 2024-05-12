using UnityEngine;

public class Camera : MonoBehaviour
{
    private Car _car;

    [SerializeField] private Vector3 _offset;
    
    void Start()
    {
        if (_car == null)
        {
            _car = FindObjectOfType<Car>();
        }
    }

    void LateUpdate()
    {
        transform.position = _car.transform.position + _offset;
    }
}
