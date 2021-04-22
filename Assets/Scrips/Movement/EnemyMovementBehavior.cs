using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyMovementBehavior : MonoBehaviour
{
    //Gets the ridgidbody for the enemy
    private Rigidbody _rigidbody;

    [SerializeField]
    private GameObject _target;

    public GameObject Target
    {
        get
        {
            return _target;
        }
        set
        {
            _target = value;
        }
    }
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        if (!_target)
            return;
    }
}
