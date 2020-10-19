using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class InputToKill : MonoBehaviour
{

	[SerializeField] Animator playerAnimator;
	[SerializeField] Animator enemyAnimator;
	private Animation playerAnimation;
	
	[SerializeField] TextMeshProUGUI wordInput;

	string input;

	void Start()
	{
		input = wordInput.text.Trim((char)8203);
	}

	public void OnSubmit(){
		
		input = wordInput.text.Trim((char)8203);
		
		foreach (var enemy in Enemy.enemies)
		{

			if(string.Equals(input,enemy.palavra)){
				playerAnimator.SetBool("Attack1",true);
				Destroy(enemy.enemyObj);
			}
		}

		wordInput.text = ""; // not working
		
		Player.player.mana -= Player.player.manaUsage;
		Player.player.manaSlider.value = Player.player.mana;
	}

}
