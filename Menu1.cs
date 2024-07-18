using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu1 : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene("onlinesystem"); //sahne adýna dikkat et
    }

    
    public void QuitGame()
    {
        Application.Quit(); 
    }
}