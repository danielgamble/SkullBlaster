using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ChompAudio : MonoBehaviour
{
    public AudioClip oneShotClip;
    private AudioSource audioSource;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public void TriggerChompAudio()
    {
        if (oneShotClip != null)
        {
            audioSource.PlayOneShot(oneShotClip, 5f);
            Debug.Log("Chomp Audio Triggered");
        }
        else
        {
            Debug.Log("Chomp Audio Not Found");
        }
    }
}