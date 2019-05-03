using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entityAppear : MonoBehaviour
{
    public GameObject flashlightChecker;
    public GameObject entity1;
    public GameObject entity2;
    public GameObject entity3;
    public bool entityisOn = true;

    private void Update()
    {
        if ((flashlightChecker.GetComponent<flashlightToggle>().flashlightisOn == true))
        {
            entity1.SetActive(false);
            entity2.SetActive(false);
            entity3.SetActive(false);
        }
        else
        {
            entity1.SetActive(true);
            entity2.SetActive(true);
            entity3.SetActive(true);
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{

    //    if ((other.gameObject.tag == "Entity") == false)
    //    {
            
    //    }
 

    //}
}
