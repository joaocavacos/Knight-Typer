using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    public GameObject spawn;
    public List<GameObject> enemiesPrefabs;
    
    void Start()
    {
        InvokeRepeating("InstantiateEnemy", 2f, 10f);
    }

    void InstantiateEnemy()
    {
        foreach (var enemy in enemiesPrefabs)
        {
            Instantiate(enemy, spawn.transform.position, quaternion.identity, transform.parent);
        }
    }
}
