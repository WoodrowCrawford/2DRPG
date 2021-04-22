using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootBehavior : MonoBehaviour
{
    [SerializeField]
    private GunBehavior _gun;

    [SerializeField]
    private float _shotSpeed;
  
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && _gun)
            _gun.Fire(transform.up * _shotSpeed);
    }
}
