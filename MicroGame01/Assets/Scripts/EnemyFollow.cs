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
        InvokeRepeating("Attack", 0f, 2f);
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, targetPlayer.position) >= distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, speed * Time.deltaTime);
            Attack();
        }
        Debug.Log(Vector2.Distance(transform.position, targetPlayer.position));
        Debug.Log(distance);
    }

    void Attack()
    {
        Player.player.hpSlider.value -= damage;
    }
}