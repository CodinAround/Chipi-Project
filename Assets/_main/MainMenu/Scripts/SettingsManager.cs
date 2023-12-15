using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using TMPro;
using HeroicArcade.CC.Core;

public class SettingsManager : MonoBehaviour
{
    public AudioClip[] soundtrack;
    public Slider volumeSlider;
    public GameObject activeObject;

    [SerializeField] public AudioSource audioSource;

    public TMPro.TMP_Dropdown quality;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        quality.onValueChanged.AddListener(delegate
        {
            qualityValueChanged(quality);
        });
    }

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();


        if (!audioSource.playOnAwake)
        {
            audioSource.clip = soundtrack[Random.Range(0, soundtrack.Length)];
            audioSource.Play();
        }

        if (activeObject)
        {
            DestroyImmediate(activeObject);
        }

        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = soundtrack[Random.Range(0, soundtrack.Length)];
            audioSource.Play();
        }

    }

    void OnEnable()
    {
        //Register Slider Events
        volumeSlider.onValueChanged.AddListener(delegate { changeVolume(volumeSlider.value); });
    }

    //Called when Slider is moved
    void changeVolume(float sliderValue)
    {
        audioSource.volume = sliderValue;
    }

    void OnDisable()
    {
        //Un-Register Slider Events
        volumeSlider.onValueChanged.RemoveAllListeners();
    }

    public void qualityValueChanged(TMPro.TMP_Dropdown sender)
    {
        int index = sender.value;

        QualitySettings.SetQualityLevel(index);

        Debug.Log("you have selected this:" + sender.value);
    }

}
 
 


