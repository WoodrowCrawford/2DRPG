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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
