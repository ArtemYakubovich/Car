using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    [SerializeField] private Car _car;
    
    private void Awake()
    {
        Instantiate(_car);
    }
}
