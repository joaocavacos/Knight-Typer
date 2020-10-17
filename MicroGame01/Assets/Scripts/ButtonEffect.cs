using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;

public class ButtonEffect : MonoBehaviour
{
    //Options Menu things
    //&& Buttons on the Main Menu
    
    
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject optionsMenu;

    public AudioMixer audioMixer;
    public TMP_Dropdown resolutionDropdown;
    Resolution[] resolutions;

    void Start() {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.width && resolutions[i].height == Screen.height){
                currentResIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResIndex;
        resolutionDropdown.RefreshShownValue();

    }

    public void ExitGame(){
        Application.Quit();
        Debug.Log("The game has quitted");
    }

    public void StartGame(){
        SceneManager.LoadScene("Gameplay Scene");
    }

    public void setSound(float soundVolume){ //Volume sound level

        audioMixer.SetFloat("Sound", soundVolume);
    }

    public void setMusic(float musicVolume){
        //still need to add music
    }

    public void setQuality(int qualityIndex){ //Quality settings
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void setResolution(int resIndex){ //Resolution settings

        Resolution resolution = resolutions[resIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void OpenOptions(){ //Open options menu

        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void SaveOptions(){ //Save button
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
}
