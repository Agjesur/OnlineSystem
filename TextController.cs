using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextController : MonoBehaviour
{
    public Text textObject; // Unity arayüzünden metin nesnesini sürükleyip býrakmak için kullanacaðýmýz deðiþken

    private void Start()
    {
        // Eðer textObject atanmamýþsa, varsayýlan olarak bu scriptin baðlý olduðu gameObject'in Text bileþenini kullanalým
        if (textObject == null)
        {
            textObject = GetComponent<Text>();
        }

        // Baþlangýçta metni gösterelim
        ShowText();
    }

    private void Update()
    {
        // Klavyeden "2" tuþuna basýldýðýnda
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            // Metnin mevcut durumuna göre gösterilmesini veya gizlenmesini saðlayalým
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

    // Metni gizlemek için
    private void HideText()
    {
        textObject.gameObject.SetActive(false);
    }

    // Metni göstermek için
    private void ShowText()
    {
        textObject.gameObject.SetActive(true);
    }
}