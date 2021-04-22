using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    [SerializeField]
    //The health for the object
    private float _health;

    [SerializeField]
    private bool _removeOnDeath = true;


    public float Health
    {
        get
        {
            return _health;
        }
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;

        if (_health < 0)
            _health = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //If the player health is less than or equal to 0, then destroy the object
        if (_health <= 0 && _removeOnDeath)
            Destroy(gameObject);
        else if (_health <= 0)
            gameObject.SetActive(false);
    }
}
