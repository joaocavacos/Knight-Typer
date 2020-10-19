using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //Simple script to spawn an enemy at the designated spawn point
    //Used InvokeRepeating instead of Coroutine
    public float repeatRate;
    
    public GameObject spawn;
    public List<GameObject> enemiesPrefabs;
    
    void Start()
    {
        StartCoroutine(InstantiateEnemy());
    }
    
    private IEnumerator InstantiateEnemy()
    {
        foreach (var enemy in enemiesPrefabs) //Looks for prefabs and spawns them
        {
            Instantiate(enemy, spawn.transform.position, quaternion.identity, transform.parent);
        }

        repeatRate -= 0.1f;
        yield return new WaitForSecondsRealtime(repeatRate); //////////////////////////////// not working
        StartCoroutine(InstantiateEnemy());
    }

    
    void Update()
    {
        if (repeatRate <= 0.1f)
        {
            repeatRate = 0.1f;
        }
    }
}
