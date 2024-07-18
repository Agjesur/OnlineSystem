using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSoundC : MonoBehaviour
{
    public AudioClip soundClip; 
    private AudioSource audioSource;

    private void Start()
    {
        
        audioSource = GetComponent<AudioSource>();

        
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = soundClip;
        }
    }

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            
            PlaySound();
        }
    }

    private void PlaySound()
    {
        
        audioSource.Play();
    }
}