using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputToKill : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI palavra;
    [SerializeField] TextMeshProUGUI inputPalavra;

	bool allowEnter;
    string guess;

	void Start()
	{
		guess = inputPalavra.text;
	}
	void Update()
    {
		if (allowEnter && (inputPalavra.text.Length > 0) && (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter))) //NOT WORKINGGGGGG
		{
			OnSubmit();
			allowEnter = false;
		}
		else
		{
			allowEnter = inputPalavra.isActiveAndEnabled;
		}
    }

	void OnSubmit()
	{
		if (guess == palavra.text)
		{
			inputPalavra.text = "";
			inputPalavra.color = Color.green;
		}
		else
		{
			inputPalavra.text = "";
			inputPalavra.color = Color.red;
		}
	}
}
