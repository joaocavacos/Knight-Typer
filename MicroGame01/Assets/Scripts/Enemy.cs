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
        fireRate = 1f;
        nextShot = Time.deltaTime; //every second shoots
    }

    
    void Update()
    {
        CheckFire();
    }

    void CheckFire(){

        if(Time.deltaTime > nextShot){
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextShot = Time.deltaTime + fireRate;
        }
    }
}
