using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SFXVolumeSliderController : MonoBehaviour
{

    private Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponent<Slider>(); // get the slider component at start

        slider.value = PlayerPrefs.GetFloat("SFXVolumeKey", 0.75f); // changing the slider value

        slider.onValueChanged.AddListener(OnSliderChanged); // a listener ensures that the sound can actually be heard
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    private void OnSliderChanged(float value) // creating a value that will adjust the volume according the slider value
    {
        if (SFXManager.Instance != null)
        {
            SFXManager.Instance.SetSFXVolume(value); // set the sfx volume through the SFXManager script.
        }
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    private void OnDestroy()
    {
        slider.onValueChanged.RemoveListener(OnSliderChanged); // remove the listener if an extra SFXManager instance is created and destroyed.
    }
}
