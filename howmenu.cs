using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howmenu : MonoBehaviour
{

    public void LoadToMenu()
    {
        SceneManager.LoadScene("how");
        Debug.Log("Oyuncu bilgilendirme ekranýnda.");
    }
}