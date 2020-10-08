using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class InputToKill : MonoBehaviour
{
	[SerializeField] List<string> words = new List<string> {"Wizard", "Enemy", "Backdoor", "TypetoKill", "Attack", "Otorrinolaringologista"};
	
    [SerializeField] TextMeshProUGUI palavraEscolhida;
    [SerializeField] TextMeshProUGUI wordInput;

    private string input, palavra;

    [SerializeField] Slider ManaSlider;
	
	float manaUsage = 10f;

	void Start()
	{
		palavra = palavraEscolhida.text;
		input = wordInput.text;
		
		palavra = words[Random.Range(0, words.Count)];

	}

	private void Update()
	{
	}

	public void OnSubmit(){
		
		Debug.Log(($"Input : {input}"));
		Debug.Log(($"Palavra : {palavra}"));

		input.Trim();
		palavra.Trim();
		input.ToLower();
		palavra.ToLower();
		
		
		if(string.Equals(input,palavra)){
			Debug.Log("Correct word");
		}
		else
		{
			Debug.Log("Wrong word");
		}
		
		input = "";
		ManaSlider.value -= manaUsage;
	}

}
