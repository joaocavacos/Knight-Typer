using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class InputToKill : MonoBehaviour
{
	Enemy enemyInstance = new Enemy();
	
	[SerializeField] TextMeshProUGUI wordInput;

	string input;

	void Start()
	{
		input = wordInput.text.Trim((char)8203);
	}

	public void OnSubmit(){
		
		input = wordInput.text.Trim((char)8203);
		
		Debug.Log(($"Input : {input}"));
		
		Debug.Log(($"Palavra : {enemyInstance.palavra}"));
		
		if(string.Equals(input,enemyInstance.palavra)){
			Destroy(enemyInstance.enemyObj);
			Debug.Log("You killed him");
		}
		else
		{
			Debug.Log("Wrong word");
		}

		input = "";
		Player.player.mana -= Player.player.manaUsage;
	}

}
