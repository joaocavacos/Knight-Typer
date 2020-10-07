using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    
    float bulletSpeed = 5f;
    float bulletDamage = 20f;
    float HP;
    Rigidbody2D rb;
    Player target;
    Vector2 playerDirection;
    public Slider HPSlider;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Player>();
        playerDirection = (target.transform.position - transform.position).normalized * bulletSpeed;
        rb.velocity = new Vector2(playerDirection.x, playerDirection.y);
        HP = HPSlider.value;
        Destroy(gameObject, 10f);
    }

    void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.name.Equals("Player")){
            Destroy(gameObject);
            Debug.Log("Player Hit");
            HP -= bulletDamage; 
            
            /*if(HPSlider.value <= 0){
                Destroy(player);
            }*/
        } 

    }
}
    
