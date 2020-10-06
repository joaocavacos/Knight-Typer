using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    float dirX, dirY;
    Rigidbody2D rb;    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(dirX, dirY);
    }
}
