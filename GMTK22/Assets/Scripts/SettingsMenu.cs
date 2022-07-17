using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer musicMixer;
    public AudioMixer sfxMixer;

    public Dropdown ResolutionDropdown;

    Resolution[] resolutions;

    void Start()
    {
        resolutions = Screen.resolutions;
<<<<<<< HEAD
        
=======

>>>>>>> origin/Malthe
        ResolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

<<<<<<< HEAD
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            
            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
=======
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
>>>>>>> origin/Malthe
            {
                currentResolutionIndex = i;
            }

        }

        ResolutionDropdown.AddOptions(options);
        ResolutionDropdown.value = currentResolutionIndex;
        ResolutionDropdown.RefreshShownValue();

<<<<<<< HEAD
    }

    public void setVolume (float volume)
    {
        musicMixer.SetFloat("Music", volume);
        sfxMixer.SetFloat("sfx", volume);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
=======
        musicMixer.SetFloat("Music", PlayerPrefs.GetFloat("MusicVol"));
        sfxMixer.SetFloat("sfx", PlayerPrefs.GetFloat("SFXVol"));

    }

    void Update()
    {

    }

    public void setMusicVolume(float volume)
    {
        PlayerPrefs.SetFloat("MusicVol", volume);
        musicMixer.SetFloat("Music", volume);
    }


    public void setSFXVolume(float volume)
    {
        PlayerPrefs.SetFloat("SFXVol", volume);
        sfxMixer.SetFloat("sfx", volume);
    }


    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    void OnEnable()
    {
        musicMixer.SetFloat("Music", PlayerPrefs.GetFloat("MusicVol"));
        sfxMixer.SetFloat("sfx", PlayerPrefs.GetFloat("SFXVol"));
    }


>>>>>>> origin/Malthe
}
