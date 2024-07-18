using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returngame : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("gamescreen"); //sahne adýna dikkat et
        Debug.Log("Oyuncu oyun ekranýna döndü");
    }
}
