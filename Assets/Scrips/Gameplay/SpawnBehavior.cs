using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehavior : MonoBehaviour
{
    [SerializeField]
    //The object that will be  spawned
    private GameObject _spawnObject;

    [SerializeField]
    //How long it will take before another object is spawned
    private float _timeBetweenSpawns;

    [SerializeField]
    //Used to check if the object can spawn or not  
    private bool _canSpawn;



    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    public IEnumerator SpawnObjects()
    {
        while (_canSpawn)
        {
            GameObject spawnedEnemy = Instantiate(_spawnObject, transform.position, new Quaternion());

            spawnedEnemy.GetComponent<EnemyMovementBehavior>();
            yield return new WaitForSeconds(_timeBetweenSpawns);
        }
    }
}
