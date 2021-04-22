using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    //The enemy health
    private float _health = 2.0f;

    [SerializeField]
    //The total amount of damage that the enemy deals
    private float _damage = 2.0f;

    [SerializeField]
    //The score that the player recieves when defeating the enemy
    public float _scoreDropped = 1.0f;

    private EnemyMovementBehavior _movement;

    private void Awake()
    {
        _movement = GetComponent<EnemyMovementBehavior>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject)
            return;

       
    }
}
