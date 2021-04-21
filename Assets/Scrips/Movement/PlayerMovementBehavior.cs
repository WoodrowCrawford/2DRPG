using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{

    [Tooltip("How fast the player will move")]
    [SerializeField]
    private float _moveSpeed = 5.0f;

    private Camera _camera;
    private Rigidbody _rigidbody;


    [SerializeField]
    //The distace the player will be from the mouse
    private float _distance = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = _distance;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

    }




}

