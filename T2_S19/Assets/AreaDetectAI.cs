using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDetectAI : MonoBehaviour
{

    public GameObject AI;
    public float playerHealth = 100;
    public bool isInside = false;

    private void OnTriggerEnter(Collider other)
    {
        AI.GetComponent<EntityAI>().enabled = true;
        isInside = true;
        
    }

    private void OnTriggerExit(Collider other)
    {
        AI.GetComponent<EntityAI>().enabled = false;
        isInside = false;
        playerHealth = 100;
    }

    void Update()
    {
        if (isInside == true)
        {
            
            Debug.LogFormat("playerHealth = {0}", playerHealth);
            playerHealth -= 1;
        }

        if (playerHealth < 0)
        {
            Debug.Log("U DEAD DOE");
            
        }
    }
}
