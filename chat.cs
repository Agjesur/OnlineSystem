using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chat : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("chat"); //sahne ad�na dikkat et
        Debug.Log("Oyuncu chat'e girdi");
    }





}
