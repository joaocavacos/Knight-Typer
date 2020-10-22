using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player player;

    private Rigidbody2D rb;
    
    public Slider hpSlider;

    [HideInInspector] public float hp;
    public float hpRecovery;
    
    public Animator playerAnimator;

    void Start()
    {
        playerAnimator = gameObject.GetComponent<Animator>();
        player = gameObject.GetComponent<Player>();
        hp = hpSlider.value;
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(RecoverHP());
    }

    void Update()
    {
        if (hpSlider.value <= 0)
        {
            GameOver();
        }
    }

    private IEnumerator RecoverHP()
    {
        if (hpSlider.value < 100)
        {
            hpSlider.value += hpRecovery;
        }
        else
        {
            hpSlider.value = 100;
        }
        
        yield return new WaitForSeconds(5);
        StartCoroutine(RecoverHP());
    }
    
    void GameOver(){
        SceneManager.LoadScene("GameOver Screen");
    }
}