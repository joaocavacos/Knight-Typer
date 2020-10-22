using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

	//Simple timer for records

	[SerializeField] TextMeshProUGUI timer;

    float currenTime;
    float minutes;
    float seconds;
    public static string timerCopy;


	void Start()
	{
        currenTime = 0;
	}

	void Update()
    {
        currenTime += Time.deltaTime;
        minutes = (Mathf.Floor(currenTime / 60));
        seconds = (Mathf.RoundToInt(currenTime % 60));

        timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
		PlayerPrefs.SetString("TimerScore", timer.text);
    }
}
