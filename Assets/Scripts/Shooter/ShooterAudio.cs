using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ShooterAudio : MonoBehaviour
{
    public AudioClip oneShotClip; // sound happens at the press of a button
    private AudioSource audioSource; // creating an audiosource so a sound can be played
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // getting the audioSource at the start so it is there when we need it.
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // if the space key is pressed...
        {
            TriggerOneShot(); // 
        }
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public void TriggerOneShot() // creating a function to trigger the audio clip that we designate in the inspector
    {
        if (oneShotClip != null) // if the oneShotClip is there...
        {
            audioSource.PlayOneShot(oneShotClip, 0.3f); // play the sound at the floats volume unless the sfxslider has been changed in the options menu
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------   
}
