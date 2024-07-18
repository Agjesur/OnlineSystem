using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextController : MonoBehaviour
{
    public Text textObject; // Unity aray�z�nden metin nesnesini s�r�kleyip b�rakmak i�in kullanaca��m�z de�i�ken

    private void Start()
    {
        // E�er textObject atanmam��sa, varsay�lan olarak bu scriptin ba�l� oldu�u gameObject'in Text bile�enini kullanal�m
        if (textObject == null)
        {
            textObject = GetComponent<Text>();
        }

        // Ba�lang��ta metni g�sterelim
        ShowText();
    }

    private void Update()
    {
        // Klavyeden "2" tu�una bas�ld���nda
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            // Metnin mevcut durumuna g�re g�sterilmesini veya gizlenmesini sa�layal�m
            if (textObject.IsActive())
            {
                HideText();
            }
            else
            {
                ShowText();
            }
        }
    }

    // Metni gizlemek i�in
    private void HideText()
    {
        textObject.gameObject.SetActive(false);
    }

    // Metni g�stermek i�in
    private void ShowText()
    {
        textObject.gameObject.SetActive(true);
    }
}