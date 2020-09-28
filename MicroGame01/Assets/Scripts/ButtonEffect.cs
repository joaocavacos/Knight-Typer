using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonEffect : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject optionsMenu;

    void ExitGame(){
        Application.Quit();
        Debug.Log("The game has quitted");
    }

    void StartGame(){
        SceneManager.LoadScene("Gameplay Scene");
    }

    void OpenOptions(){

        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    void CloseOptions(){
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    void SaveOptions(){

    }

}
