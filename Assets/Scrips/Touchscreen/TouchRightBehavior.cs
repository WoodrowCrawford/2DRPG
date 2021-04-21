using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRightBehavior : MonoBehaviour
{
    

    [SerializeField]
    private float _speed = 5f;

    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //The direction the player is moving in is set to the input values for the horizontal and vertical axis
        Vector3 moveDir = new Vector3(Input.mousePosition.x, 0, 0);
        //The move direction is scaled by the movement speed to get velocity
        Vector3 velocity = moveDir * _speed * Time.deltaTime;

        //Call to make the rigidbody smoothly move to the desired position
        _rigidbody.MovePosition(transform.position + velocity);

        //_rigidbody.AddForce(new Vector3(3, 0, 0) * _speed * Time.deltaTime);
    }
}
