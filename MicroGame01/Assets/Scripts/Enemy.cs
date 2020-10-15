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
    
    public List<string> words = new List<string> {"Wizard", "Enemy", "Backdoor", "TypetoKill", "Attack", "Word", "Damage", "Death", "Asdfg", "RightNow", "DifficultWord"};
    public static List<Enemy> enemies = new List<Enemy>();

    [SerializeField] public TextMeshProUGUI palavraEscolhida;

    [HideInInspector] public string palavra;

    private Vector2 position;
    
    public GameObject enemyObj;

    void Start()
    {
        palavraEscolhida.text = words[Random.Range(0, words.Count)];
        palavra = palavraEscolhida.text.Trim();
        enemyObj = this.gameObject;
        enemies.Add(this);
    }

    void Update()
    {

    }

}
