using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //Simple script to spawn an enemy at the designated spawn point
    //Used InvokeRepeating instead of Coroutine
    
    public GameObject spawn;
    public List<GameObject> enemiesPrefabs;
    
    void Start()
    {
        InvokeRepeating("InstantiateEnemy", 2f, 10f); //Repeats the Instantiate 2 seconds after the game starts, and then spawns every 10 seconds (repeat rate)
    }

    void InstantiateEnemy()
    {
        foreach (var enemy in enemiesPrefabs) //Looks for prefabs and spawns them
        {
            Instantiate(enemy, spawn.transform.position, quaternion.identity, transform.parent);
        }
    }
}
