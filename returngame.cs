using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returngame : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("gamescreen"); //sahne ad�na dikkat et
        Debug.Log("Oyuncu oyun ekran�na d�nd�");
    }
}
