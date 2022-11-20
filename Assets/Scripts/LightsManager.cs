using UnityEngine;

public class LightsManager : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;
    [SerializeField] Light[] lights;
      
    bool isOn;
   
    void Start()
    {
        isOn = true;
        if(lights != null)
        {
            foreach (Light light in lights)
            {
                light.enabled = true;
            }
        }
        else
        {
            Debug.Log("Lights cannot be empty");
        }
    }


    void OnMouseDown()
    {
        if(isOn)
        {
            isOn = false;
            audioManager.PlayLightSwitchClick();
            foreach (Light light in lights)
            {
                light.enabled = false;
            }
        }
        else
        {
            isOn = true;
            audioManager.PlayLightSwitchClick();
            foreach (Light light in lights)
            {
                light.enabled = true;
            }

        }       

    }
}
