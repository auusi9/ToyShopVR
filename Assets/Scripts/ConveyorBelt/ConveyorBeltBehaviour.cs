using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBeltBehaviour : MonoBehaviour
{
    [SerializeField] private Transform _endpoint;
    [SerializeField] private float _speed;

    private Vector3 _direction;

    private void Start()
    {
        _direction = _endpoint.position - transform.position;
    }

    private void OnTriggerStay(Collider other)
    {
        Vector3 position = other.transform.position;
        position = Vector3.MoveTowards(
                position, 
                position + _direction, 
                _speed * Time.deltaTime);
        other.transform.position = position;
    }
}
