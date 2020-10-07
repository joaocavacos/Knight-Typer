using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InputToKill : MonoBehaviour
{
	private List<string> words = new List<string> {"Wizard", "Enemy", "Backdoor", "TypetoKill"};
    [SerializeField] TextMeshProUGUI palavra;
    [SerializeField] TextMeshProUGUI inputPalavra;
    string guess;
	//[SerializeField] GameObject enemy;
	[SerializeField] Slider ManaSlider;
	float manaUsage = 10f;

	
	void Start()
	{
		guess = inputPalavra.text;
		palavra.text = words[Random.Range(0, words.Count)];
	}
	void Update()
    {
		
    }

	public void OnSubmit(){

		if(guess == palavra.text){
			Debug.Log("Correct word");
		}
		else
		{
			Debug.Log("Wrong word");
		}

		ManaSlider.value -= manaUsage;
	}

}
