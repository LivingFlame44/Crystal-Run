using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixMove : MonoBehaviour
{
    [SerializeField] public float _speed = 2f;
  
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
        
    }
}
