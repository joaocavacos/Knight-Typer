using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] GameObject bullet;

    float fireRate;
    float nextShot;

    void Start()
    {
        fireRate = 3f;
        nextShot = Time.time; //every second shoots
    }

    
    void Update()
    {
        CheckFire();
    }

    void CheckFire(){

        if(Time.time > nextShot){
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextShot = Time.time + fireRate;
        }
    }
}
