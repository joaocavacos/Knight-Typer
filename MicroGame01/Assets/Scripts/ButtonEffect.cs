using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEffect : MonoBehaviour
{
    public void ExitGame(){
        Application.Quit();
        Debug.Log("The game has quitted");
    }

}
