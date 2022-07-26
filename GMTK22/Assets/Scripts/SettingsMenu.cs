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
    public Slider musicSlider;
    public Slider sfxSlider;

    Resolution[] resolutions;

    void OnEnable()
    {
        musicMixer.SetFloat("Music", PlayerPrefs.GetFloat("MusicVol"));
        sfxMixer.SetFloat("sfx", PlayerPrefs.GetFloat("SFXVol"));
        musicSlider.value = PlayerPrefs.GetFloat("MusicVol");
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVol");
    }

    void Start()
    {

        resolutions = Screen.resolutions;

        ResolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)

            {
                currentResolutionIndex = i;
            }

        }

        ResolutionDropdown.AddOptions(options);
        ResolutionDropdown.value = currentResolutionIndex;
        ResolutionDropdown.RefreshShownValue();


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







}
