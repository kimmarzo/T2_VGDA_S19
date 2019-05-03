using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entityDetect : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Entity")
        {
            
        }

    }
}
