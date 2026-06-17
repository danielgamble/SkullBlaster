using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SFXManager : MonoBehaviour
{
    public static SFXManager Instance; // creating an audio manager for our sfx that can be accessed when we need it
    [SerializeField]
    private AudioMixer audioMixer;
    private void Awake()
    {
        if (Instance == null) // with this we are making sure that like the gamemanager, there is only one sfxmanager trying to change the volume of the sfxMixer
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // destroy the extra instance if there is more than one
            return;
        }
        LoadSFXVolume(); // call the function to load the volume as the player previously set in the options screen

    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    private void LoadSFXVolume()
    {
        float savedVolume = PlayerPrefs.GetFloat("SFXVolumeKey", 0.75f); // create a function to access the Player Prefs so the game will remember the audio preferences.
        SetSFXVolume(savedVolume);
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public void SetSFXVolume(float sliderValue) // create a function to change the value of the slider to reflect the volume of the audio clip
    {
        if (audioMixer == null)
        {
            Debug.LogError("SFXManager.audioMixer is not assigned on " + name); // checking to make sure that the sfxManager is assigned in the inspector
            return;
        }

        float dB = Mathf.Log10(sliderValue) * 20; // converting from a linear scale to logarithmic so we have a smooth increase and decrease in volume.

        if (sliderValue < 0.0001f) sliderValue = 0.0001f; // don't let the slider value drop below 0.0001
        audioMixer.SetFloat("SFXVolume", dB); // setting the volume in decibels
        PlayerPrefs.SetFloat("SFXVolumeKey", sliderValue); // make the slider value refect the float
        PlayerPrefs.Save(); // save the user's volume settings for next time.
    }
}