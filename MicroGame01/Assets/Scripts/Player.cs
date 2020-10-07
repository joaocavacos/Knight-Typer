using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    float dirX, dirY;
    Rigidbody2D rb;    
    Bullet bullet;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");

        /*if(bullet.HPSlider.value <= 0){
            Destroy(gameObject);
        } */
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(dirX, dirY);
    }
}
