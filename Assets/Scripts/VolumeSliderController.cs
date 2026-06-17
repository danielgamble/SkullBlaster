using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class VolumeSliderController : MonoBehaviour
{

    private Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponent<Slider>(); // get the slider component so we can change the value

        slider.value = PlayerPrefs.GetFloat("BackgroundVolumeKey", 0.75f); // change the slider value to match the background volume

        slider.onValueChanged.AddListener(OnSliderChanged); // add a listener so the sound can be played
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    private void OnSliderChanged(float value) // create a function for when the slider is changed
        {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.SetMixerVolume(value); // call the audio manager to set the background mixer volume
        }
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    private void OnDestroy()
    {
        slider.onValueChanged.RemoveListener(OnSliderChanged); // remove the listener when the audio manager is destroyed so we don't end up with extras
    }
}
