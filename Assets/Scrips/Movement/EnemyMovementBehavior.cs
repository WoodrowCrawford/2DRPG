using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyMovementBehavior : MonoBehaviour
{
    //Gets the ridgidbody for the enemy
    private Rigidbody _rigidbody;

    [SerializeField]
    //Sets a target for the enemy
    private GameObject _target;

    [SerializeField]
    //The amount of time it takes for the enemy to disappear
    private float _despawnTime;

    //Returns a value for the target
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
        Destroy(gameObject, _despawnTime);
    }


    private void FixedUpdate()
    {
        if (!_target)
            return;
    }
}
