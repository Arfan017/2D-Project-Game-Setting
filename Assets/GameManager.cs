using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject panelSetting;
    [SerializeField] TMP_Dropdown dropdownValue;
    [SerializeField] AudioSource audioSource;
    public AudioMixer mixer;

    private void Start()
    {
        audioSource.loop = true;
        audioSource.playOnAwake = true;
    }

    public void Play()
    {
        Debug.Log("Game Belum Diset :)");
    }

    public void PanelSetting(bool value)
    {
        panelSetting.SetActive(value);
    }

    public void getResolution(int value)
    {
        var Res = dropdownValue.options[value].text;
        Debug.Log("resolusi: " + Res);
    }

    public void SetMute(bool value)
    {
        audioSource.mute = value;
        Debug.Log("Mute: " + value);
    }

    public void SetVol(float sliderValue)
    {
        var vol = Mathf.Log10(sliderValue) * 20;
        mixer.SetFloat("MusicVol", vol);
        Debug.Log(vol);
    }
}