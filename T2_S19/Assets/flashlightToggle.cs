using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class flashlightToggle : MonoBehaviour
{
    public VRTK.VRTK_ControllerEvents controllerEvents;
    public GameObject flashlight;
    public GameObject entityLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (controllerEvents.triggerClicked)
        {
         
            flashlight.GetComponent<Light>().enabled = true;
            entityLight.SetActive(true);

        }
        else
        {
            flashlight.GetComponent<Light>().enabled = false;
            entityLight.SetActive(false);
        }

    }
}
