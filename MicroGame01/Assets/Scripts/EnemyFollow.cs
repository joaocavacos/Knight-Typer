using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyFollow : MonoBehaviour
{
    public static EnemyFollow efollow;

    [SerializeField] Animator enemyAnimator;
    [SerializeField] Animator playerAnimator;

    public Transform targetPlayer;
    
    private float speed;
    public float distance;
    public float damage;

    void Start()
    {
        targetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        speed = Random.Range(0.5f, 1.2f);
        StartCoroutine(Attack());
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, targetPlayer.position) >= distance) //If enemy is further from the distance of the player this will move towards the player until the distance set
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime);
            enemyAnimator.SetInteger("AnimState", 2);
        }
    }

    private IEnumerator Attack() //Corountine for attack, 2 seconds per attack & animations
    {
        if (Vector2.Distance(transform.position, targetPlayer.position) <= distance)
        {
            Player.player.hpSlider.value -= damage;
            enemyAnimator.Play("Attack");
            Debug.Log(Vector2.Distance(transform.position, targetPlayer.position));
        }
        
        yield return new WaitForSeconds(2);
        StartCoroutine(Attack());
    }
}