using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundcontroller : MonoBehaviour
{
    private bool isSoundOn = true;  

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ToggleSound();
        }
    }

    
    public void ToggleSound()
    {
        isSoundOn = !isSoundOn;  

        
        if (isSoundOn)
        {
            
            AudioListener.volume = 1f; 
            Debug.Log("Ses açýk");
        }
        else
        {
            
            AudioListener.volume = 0f;  
            Debug.Log("Ses kapalý");
        }
    }

    
    public void OnButtonClick()
    {
        ToggleSound();
    }
}