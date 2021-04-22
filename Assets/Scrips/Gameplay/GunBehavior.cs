using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;

    public void Fire(Vector3 force)
    {
        //Makes a new bullet
        GameObject firedBullet = Instantiate(_bullet, transform.position, transform.rotation);

        BulletBehavior bulletScript = firedBullet.GetComponent<BulletBehavior>();

        if (bulletScript)
            bulletScript.Rigidbody.AddForce(force, ForceMode.Impulse);
    }
    
}
