using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_player : MonoBehaviour
{
    public AudioSource walking_source;
    Vector3 initialPos;
    Vector3 finalPos;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
        initialPos = player.GetComponent<Transform>().position;
    
    }

    // Update is called once per frame
    void Update()
    {
        finalPos = player.GetComponent<Transform>().position;
        gameObject.GetComponent<Transform>().position = finalPos;

        if (initialPos.x != finalPos.x && walking_source.isPlaying == false)
        {
            walking_source.Play();
            initialPos = finalPos;
        }

        if (initialPos.y != finalPos.y && walking_source.isPlaying == false)
        {
            walking_source.Play();
            initialPos = finalPos;

        }

        if (initialPos.z != finalPos.z && walking_source.isPlaying == false)
        {
            walking_source.Play();
            initialPos = finalPos;
        }
    }

 
}
