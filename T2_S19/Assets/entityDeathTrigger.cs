using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class entityDeathTrigger : MonoBehaviour
{

    private bool isInsideDeath = false;
    public GameObject parentEntity;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
        if (other.gameObject.tag == "flashlightPoint")
        {
            Destroy(parentEntity);
        }

    }




}
