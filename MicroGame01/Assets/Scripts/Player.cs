using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player player;

    private Rigidbody2D rb;
    public Slider manaSlider;
    public Slider hpSlider;

    [HideInInspector] public float mana, hp;
    public float manaUsage;

    void Start()
    {
        player = gameObject.GetComponent<Player>();
        mana = manaSlider.value;
        hp = hpSlider.value;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    }
}