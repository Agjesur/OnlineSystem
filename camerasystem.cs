using UnityEngine;
using UnityEngine.UI;

public class Camerasystem : MonoBehaviour
{
    public Dropdown dropdown;

    public GameObject a��1; 
    public GameObject a��2; 

    private GameObject activeCamera; 
    void Start()
    {
        
        dropdown.onValueChanged.AddListener(delegate {
            SwitchCamera(dropdown.value);
        });

        
        SwitchCamera(0);
    }

    void SwitchCamera(int index)
    {
        
        if (activeCamera != null)
        {
            activeCamera.SetActive(false);
        }

        
        switch (index)
        {
            case 0:
                activeCamera = a��1;
                break;
            case 1:
                activeCamera = a��2;
                break;
            default:
                Debug.Log("Tan�ms�z dropdown de�eri: " + index);
                return;
        }

        
        if (activeCamera != null)
        {
            activeCamera.SetActive(true);
        }
        else
        {
            Debug.Log("Kamera nesnesi bulunamad�.");
        }
    }
}