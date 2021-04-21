using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    //The enemy health
    private float _health = 2.0f;

    [SerializeField]
    //The score that the player recieves when defeating the enemy
    public float _scoreDropped = 1.0f;

    [SerializeField]
    //The total amount of damage that the enemy deals
    private float _damage = 2;


    [SerializeField]

    private EnemyMovementBehavior _movement;

    private void OnCollisionEnter(Collision collision)
    {
        //If the target isn't the target return
        if (collision.gameObject != _movement.Target)
            return;

        //Get a reference to the attached health script
        HealthBehaviour health = collision.gameObject.GetComponent<HealthBehaviour>();

        //If the health isn't null, deal damage
        if (health)
            health.TakeDamage(_damage);
    }
}
