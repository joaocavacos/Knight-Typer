using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class InputToKill : MonoBehaviour
{
	[SerializeField] List<string> words = new List<string> {"Wizard", "Enemy", "Backdoor", "TypetoKill", "Attack"};
	
    [SerializeField] TextMeshProUGUI palavraEscolhida;
    [SerializeField] TextMeshProUGUI wordInput;

    string input, palavra;
	float mana;

    [SerializeField] Slider ManaSlider;
	
	float manaUsage = 10f;

	void Start()
	{
		palavraEscolhida.text = words[Random.Range(0, words.Count)];
		palavra = palavraEscolhida.text;
		input = wordInput.text.Trim((char)8203);
		mana = ManaSlider.value;
	}

	private void Update()
	{
	}

	public void OnSubmit(){
		
		palavra = palavraEscolhida.text.Trim().ToLower();
		input = wordInput.text.Trim((char)8203).ToLower();

		Debug.Log(($"Input : {input}"));
		Debug.Log(($"Palavra : {palavra}"));
		
		if(string.Equals(input,palavra)){
			Debug.Log("You killed him");
		}
		else
		{
			Debug.Log("Wrong word");
		}
		
		input = "";
		mana -= manaUsage;
	}

}
