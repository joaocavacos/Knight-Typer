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
			Debug.Log(($"Input : {input}"));
			Debug.Log(($"Palavra : {enemy.palavra}"));
			
			if(string.Equals(input,enemy.palavra)){
				Destroy(enemy.enemyObj);
				Debug.Log("You killed him");
			}
			else
			{
				Debug.Log("Wrong word");
			}
		}

		wordInput.text = "";
		Player.player.mana -= Player.player.manaUsage;
		Player.player.manaSlider.value = Player.player.mana;
	}

}
