using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{

    [Tooltip("How fast the player will move")]
    [SerializeField]
    private float _moveSpeed = 5.0f;


    private Rigidbody _rigidbody;

    Vector3 mousePosition;
    Vector2 position = new Vector2(0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

}

