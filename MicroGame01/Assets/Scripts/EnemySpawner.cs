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
        InvokeRepeating(nameof(InstantiateEnemy), 2f, repeatRate);
    }
    
    void InstantiateEnemy()
    {
        foreach (var enemy in enemiesPrefabs) //Looks for prefabs and spawns them
        {
            Instantiate(enemy, spawn.transform.position, quaternion.identity, transform.parent);
        }

        repeatRate -= 0.2f;
    }

    
    void Update()
    {
        if (repeatRate <= 1f)
        {
            repeatRate = 1f;
        }
    }
}
