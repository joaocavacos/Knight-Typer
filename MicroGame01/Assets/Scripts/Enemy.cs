using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{    
    
    public List<string> words = new List<string> {"Wizard", "Enemy", "Backdoor", "TypetoKill", "Attack"};
    //static List<GameObject> enemies = new List<GameObject>();

    [SerializeField] public TextMeshProUGUI palavraEscolhida;
    
    [HideInInspector] public string palavra;
    public float speed;
    
    private Vector2 position;
    private Vector3 spawnPoint;

    public GameObject spawn;
    public GameObject enemyObj;

    void Start()
    {
        palavraEscolhida.text = words[Random.Range(0, words.Count)];
        palavra = palavraEscolhida.text.Trim();
        enemyObj = GetComponent<GameObject>();
        spawnPoint = spawn.transform.position;
    }

    void Update()
    {
        //Instantiate(enemy, spawnPoint, Quaternion.identity);
        
        position = transform.position;
        position.x = position.x - speed * Time.deltaTime;
        transform.position = position;
    }
}
