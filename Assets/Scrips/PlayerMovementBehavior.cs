using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;


    [SerializeField]
    //The main player's health
    private float _health;

    [SerializeField]
    //How much damage the player deals
    private float _damage;

    [SerializeField]
    //How much mama the player has
    private float _mana;

    [SerializeField]
    //How fast the player can move  
    private float _speed;

   
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
