using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackBehavior : MonoBehaviour
{
 
    [SerializeField]
    //The total amount of damage that the enemy deals
    private float _damage = 2.0f;

    //Gets a reference to the enemy movement behavior
    private EnemyMovementBehavior _movement;

    

    private void Awake()
    {
        _movement = GetComponent<EnemyMovementBehavior>();
    }

    //What happens when the object touches the player
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject != _movement.gameObject)
            return;

        HealthBehavior health = other.gameObject.GetComponent<HealthBehavior>();

        if (health)
            health.TakeDamage(_damage);
       
    }
}
