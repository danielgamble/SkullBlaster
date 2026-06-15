using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ShooterAudio : MonoBehaviour
{
    public AudioClip oneShotClip;
    private AudioSource audioSource;
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TriggerOneShot();
        }
    }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public void TriggerOneShot()
    {
        if (oneShotClip != null)
        {
            audioSource.PlayOneShot(oneShotClip, 0.3f);
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------   
}
