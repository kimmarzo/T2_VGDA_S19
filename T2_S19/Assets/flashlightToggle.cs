using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;

public class flashlightToggle : MonoBehaviour
{
    public VRTK.VRTK_ControllerEvents controllerEvents;
    public GameObject flashlight;
    public GameObject entityLight;
    public float triggerTimes = 0;
    public bool flashlightisOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (controllerEvents.triggerPressed)
        {
         
            flashlight.GetComponent<Light>().enabled = true;
            entityLight.SetActive(true);
            flashlightisOn = true;
            triggerTimes += 1;
        }
        else
        {
            flashlight.GetComponent<Light>().enabled = false;
            entityLight.SetActive(false);
            flashlightisOn = false;
        }

        if (120 <= triggerTimes)
        {
            SceneManager.LoadScene(0);
        }
    }


}
