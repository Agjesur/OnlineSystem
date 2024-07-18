using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private bool soundOn = true; // Sesin a��k veya kapal� oldu�unu takip eden de�i�ken

    // Butona ba�l� olarak �al��acak fonksiyon
    public void ToggleSound()
    {
        soundOn = !soundOn; // Ses durumunu tersine �evir

        if (soundOn)
        {
            AudioListener.volume = 1f; // Sesin ses d�zeyini 1'e (tam ses) ayarla
        }
        else
        {
            AudioListener.volume = 0f; // Sesin ses d�zeyini 0'a (ses kapal�) ayarla
        }
    }
}