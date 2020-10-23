using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;
using System.Linq;

public class Settings : MonoBehaviour
{
    //Settings Menu things
    //&& Buttons on the Main Menu

    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject creditsMenu;


    public AudioMixer soundMixer;
    public AudioMixer musicMixer;
    
    public TMP_Dropdown resolutionDropdown;
    private Resolution[] resolutions;

    private void Start()
    {
        resolutions = Screen.resolutions.Select(resolution => new Resolution {width = resolution.width, height = resolution.height}).Distinct().ToArray();
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
    
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("The game has quit");
    }
    
    public void SetSound(float soundVolume){ //Volume sound level

        soundMixer.SetFloat("Sound", soundVolume);
    }

    public void SetMusic(float musicVolume)
    {
        musicMixer.SetFloat("Music", musicVolume);
    }

    public void SetQuality(int qualityIndex){ //Quality settings
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetResolution(int resIndex){ //Resolution settings

        Resolution resolution = resolutions[resIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void OpenOptions(){ //Open options menu

        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
        creditsMenu.SetActive(false);
    }

    public void SaveOptions(){ //Save button ----> Doesn't save after game closes (rip)
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        creditsMenu.SetActive(false);

    }

    public void OpenCredits() //Open Credits Menu
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        creditsMenu.SetActive(true);
    }
}
