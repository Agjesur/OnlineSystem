using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
   
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#else
            Application.Quit(); // Oyun derlenmi� h�lde �al���yorsa uygulamay� kapat
#endif
    }
}