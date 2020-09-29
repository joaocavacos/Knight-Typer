using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ButtonEffect : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject optionsMenu;

    public AudioMixer audioMixer;

    public void ExitGame(){
        Application.Quit();
        Debug.Log("The game has quitted");
    }

    public void StartGame(){
        SceneManager.LoadScene("Gameplay Scene");
    }

    public void setSound(float soundVolume){

        audioMixer.SetFloat("Sound", soundVolume);
    }

    public void setMusic(float musicVolume){

    }

    public void OpenOptions(){

        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void CloseOptions(){
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    public void SaveOptions(){

    }

}
