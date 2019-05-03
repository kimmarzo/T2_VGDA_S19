using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class entityDeathTriggerForPlayer : MonoBehaviour
{

    private bool isInsideDeath = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }


    }




}
