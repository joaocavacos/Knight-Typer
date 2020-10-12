using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Mathematics;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{    
    
    public List<string> words = new List<string> {"Wizard", "Enemy", "Backdoor", "TypetoKill", "Attack"};
    public static List<Enemy> enemies = new List<Enemy>();

    [SerializeField] public TextMeshProUGUI palavraEscolhida;
    [SerializeField] private Animator enemyAnimator;

    [HideInInspector] public string palavra;
    
    public float speed;

    private Vector2 position;
    
    public GameObject enemyObj;

    void Start()
    {
        palavraEscolhida.text = words[Random.Range(0, words.Count)];
        palavra = palavraEscolhida.text.Trim();
        enemyObj = this.gameObject;

        enemies.Add(this);
        //InvokeRepeating("SpawnEnemies", 2f, 10f);
    }

    void Update()
    {
        position = transform.position;
        position.x = position.x - speed * Time.deltaTime;
        transform.position = position;

        if (position.x > 0)
        {
            enemyAnimator.SetInteger("AnimState", 2);
        }

    }

}
