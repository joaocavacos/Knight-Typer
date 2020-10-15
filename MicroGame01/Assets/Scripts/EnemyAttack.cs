using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] Animator enemyAnimator;
    [SerializeField] Animator playerAnimator;
    
    public float damage;

    public Transform targetPlayer;
    
    void Start()
    {
        InvokeRepeating("Attack", 1f, 2f);
    }
    
    void Update()
    {
        
    }

    void Attack()
    {
        if (EnemyFollow.efollow.distance == 2){}

        {
            Player.player.hp -= damage;
        }
    }
}
