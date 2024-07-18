using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnmenu : MonoBehaviour
{
    
    public void ReturnTheMenu()
    {
        SceneManager.LoadScene("login");
        Debug.Log("Oyuncu bilgilendirme ekranýndan çýktý.");
    }
}