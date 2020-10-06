using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    float bulletSpeed = 2f;

    Rigidbody2D rb;

    Player target;
    Vector2 playerDirection;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Player>();
        playerDirection = (target.transform.position - transform.position).normalized * bulletSpeed;
        rb.velocity = new Vector2(playerDirection.x, playerDirection.y);
        Destroy(gameObject, 10f);
    }

    void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.name.Equals("Player")){
            Debug.Log("Player Hit");
            //---> make hp decrease and bullet damage
        }
    }
    
}
