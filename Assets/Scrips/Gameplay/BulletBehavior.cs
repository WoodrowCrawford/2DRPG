using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class BulletBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private EnemyMovementBehavior enemy;

    [SerializeField]
    //How much damage the bullet will do
    private float _damage;

    [SerializeField]
    //How long it takes for the bullet to disappear 
    private float _despawnTime;

    //Returns values for the Rigidbody
    public Rigidbody Rigidbody
    {
        get
        {
            return _rigidbody;
        }
    }

    //Gets and sets the Damage value from _damage
    public float Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        //Destroys the bullet after enough time has passed
        Destroy(gameObject, _despawnTime);
    }

    private void OnTriggerEnter(Collider enemy)
    {
        //Get the health behavior attached to the object
        HealthBehavior health = enemy.GetComponent<HealthBehavior>();

        //If the health value is not null, deal damage
        if (health)
            health.TakeDamage(Damage);
    }
}
