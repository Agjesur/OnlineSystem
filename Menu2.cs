using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu2 : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScreen"); //sahne ad�na dikkat et
    }

    
    public void QuitGame()
    {
        Application.Quit(); 
    }
}