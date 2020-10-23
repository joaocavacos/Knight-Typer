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
	public Animator enemyAnimator;
	public Animator camAnimator;

	public AudioSource damage;
	public AudioSource correct;
	public AudioSource wrong;

	public InputField wordInput;
	public TextMeshProUGUI wpmText;
	
	string input;

	private float wpm;
	private float wordsWritten;
	private float minutes;
	private float currentTime;

	void Start()
	{
		input = wordInput.text.Trim((char)8203);
		currentTime = 0;
		wpm = 0;
	}

	public void OnSubmit(){
		
		input = wordInput.text.Trim((char)8203);
		
		foreach (var enemy in Enemy.enemies)
		{

			if(string.Equals(input,enemy.palavra)){
				Player.player.playerAnimator.SetBool("Attack1",true);
				damage.Play();
				Destroy(enemy.enemyObj);
				correct.Play();
				camAnimator.SetTrigger("Shake");
				wordsWritten += 1;
				wpm = Mathf.RoundToInt(wordsWritten/minutes);
			}
			else
			{
				wrong.Play();
			}

			wordInput.text = String.Empty;
			wordInput.ActivateInputField();
		}
	}

	void Update()
	{
		currentTime += Time.deltaTime;
		minutes = (currentTime / 60);
		wpmText.text = wpm.ToString() + "WPM";
		PlayerPrefs.SetString("WPM", wpmText.text);
	}
}
