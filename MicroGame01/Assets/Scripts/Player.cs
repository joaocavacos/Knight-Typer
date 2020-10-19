using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player player;

    private Rigidbody2D rb;
    public Slider manaSlider;
    public Slider hpSlider;

    [HideInInspector] public float mana, hp;
    public float manaUsage;
    public float manaRecovery;
    public float hpRecovery;

    void Start()
    {
        player = gameObject.GetComponent<Player>();
        mana = manaSlider.value;
        hp = hpSlider.value;
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(RecoverMana());
        StartCoroutine(RecoverHP());
    }

    private IEnumerator RecoverMana()
    {
        if (manaSlider.value < 100)
        {
            manaSlider.value += manaRecovery;
        }
        else
        {
            manaSlider.value = 100;
        }
        
        yield return new WaitForSeconds(3);
        StartCoroutine(RecoverMana());
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
}