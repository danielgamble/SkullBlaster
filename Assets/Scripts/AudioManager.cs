using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance; // let this variable be available to our other scripts
    [SerializeField]
    private AudioMixer audioMixer;
    private void Awake()
    {
        if (Instance == null) // making sure there is only one audio manager so there arent seperate things fighting for control of volumes
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); // destroy the extra manager if it is there
            return;
        }
        LoadVolume(); // load the volume previously adjusted by the player in the options menu
        
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    private void LoadVolume() // create the function to load the volume preferences
    {
        float savedVolume = PlayerPrefs.GetFloat("BackgroundVolumeKey", 0.75f); // go into player prefs and retrieve the volume settings dedicated by the player
        SetMixerVolume(savedVolume); // set the mixer to the last saved volume
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public void SetMixerVolume(float sliderValue) // create a function to set the mixer volume
    {
        if (audioMixer == null)
        {
            Debug.LogError("AudioManager.audioMixer is not assigned on " + name); // let the designer know if the audiomanager doesn't have a mixer designated
            return;
        }
        
        float dB = Mathf.Log10(sliderValue) * 20; // create a float to convert the slider to a logarithmic scale and set it to decibels

        if (sliderValue < 0.0001f) sliderValue = 0.0001f; // make sure the slider can't go below 0.0001
        audioMixer.SetFloat("BackgroundVolume", dB); // set the mixer volume in decibels
        PlayerPrefs.SetFloat("BackgroundVolumeKey", sliderValue); // Save the volume to player prefs
        PlayerPrefs.Save();
    }

    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

  

}
