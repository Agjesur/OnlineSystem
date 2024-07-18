using UnityEngine;
using UnityEngine.UI;

public class Camerasystem : MonoBehaviour
{
    public Dropdown dropdown;

    public GameObject açý1; 
    public GameObject açý2; 

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
                activeCamera = açý1;
                break;
            case 1:
                activeCamera = açý2;
                break;
            default:
                Debug.Log("Tanýmsýz dropdown deðeri: " + index);
                return;
        }

        
        if (activeCamera != null)
        {
            activeCamera.SetActive(true);
        }
        else
        {
            Debug.Log("Kamera nesnesi bulunamadý.");
        }
    }
}