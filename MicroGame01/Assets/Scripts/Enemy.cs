using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float walkX;
    public float speed;
    
    private Vector2 position;
    private Vector3 spawnPoint;

    public GameObject spawn;
    private GameObject enemy;

    void Start()
    {
        enemy = GetComponent<GameObject>();
        //spawnPoint = spawn.transform.position;
    }

    void Update()
    {
        //Instantiate((enemy, spawnPoint, Quaternion.identity));
        
        position = transform.position;
        position.x = position.x - speed * Time.deltaTime;
        transform.position = position;
        
        
    }
}
