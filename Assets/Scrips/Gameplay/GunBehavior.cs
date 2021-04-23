using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehavior : MonoBehaviour
{
    [SerializeField]
    //Gets the bullet script so it can use it as a reference
    private GameObject _bullet;

    public void Fire(Vector3 force)
    {
        //Makes a new bullet
        GameObject firedBullet = Instantiate(_bullet, transform.position, transform.rotation);

        BulletBehavior bulletScript = firedBullet.GetComponent<BulletBehavior>();

        //If the bullet is not false, it adds a force to it
        if (bulletScript)
            bulletScript.Rigidbody.AddForce(force, ForceMode.Impulse);
    }
    
}
