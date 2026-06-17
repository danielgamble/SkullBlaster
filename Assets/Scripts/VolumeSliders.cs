using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;

public class VolumeSliders : MonoBehaviour
{

    [SerializeField] private AudioMixer BackgroundVolume;

    float dB;

    public void SetBackgroundVolume(float sliderValue)
    {
        if (sliderValue <= 0.0001f)
            dB = -80f;
        else
            dB = Mathf.Log10(sliderValue) * 20;

        BackgroundVolume.SetFloat("BackgroundVolume", dB);
    }
}
