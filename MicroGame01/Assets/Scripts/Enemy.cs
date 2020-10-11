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
    
    [HideInInspector] public string palavra;
    public float speed;
    private float respawnTime;
    
    
    private Vector2 position;
    private Vector3 spawnPoint;

    public GameObject spawn;
    public GameObject enemyObj;

    void Start()
    {
        palavraEscolhida.text = words[Random.Range(0, words.Count)];
        palavra = palavraEscolhida.text.Trim();
        enemyObj = this.gameObject;
        spawnPoint = spawn.transform.position;
        //StartCoroutine(SpawnEnemies(3));
        enemies.Add(this);
        InvokeRepeating("SpawnEnemies", 2f, 5f);
    }

    void Update()
    {
        position = transform.position;
        position.x = position.x - speed * Time.deltaTime;
        transform.position = position;
        
    }

    void SpawnEnemies()
    {
        Instantiate(enemyObj, spawnPoint, quaternion.identity);
    }
    /*private IEnumerator SpawnEnemies(float resTime)
    {
        Instantiate(enemyObj, spawnPoint, quaternion.identity);
        yield return new WaitForSecondsRealtime(resTime);
    }
    */
    
}
