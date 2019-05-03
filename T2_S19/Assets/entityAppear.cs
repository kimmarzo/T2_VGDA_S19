using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entityAppear : MonoBehaviour
{
    public GameObject flashlightChecker;
    public GameObject entity;
    public bool entityisOn = true;

    private void Update()
    {
        if ((flashlightChecker.GetComponent<flashlightToggle>().flashlightisOn == true))
        {
            entity.SetActive(false);
        }
        else
        {
            entity.SetActive(true);
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{

    //    if ((other.gameObject.tag == "Entity") == false)
    //    {
            
    //    }
 

    //}
}
