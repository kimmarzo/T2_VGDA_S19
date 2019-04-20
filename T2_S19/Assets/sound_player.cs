using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_player : MonoBehaviour
{
    public AudioSource walking_source;
    Vector3 initialPos;
    Vector3 finalPos;
    Vector3 difference;
    // Start is called before the first frame update
    void Start()
    {
        
        initialPos = GetComponent<Transform>().position;
    
    }

    // Update is called once per frame
    void Update()
    {
        finalPos = GetComponent<Transform>().position;
        difference = finalPos - initialPos;

        if (difference.magnitude > 1.0f && walking_source.isPlaying == false)
        {
            walking_source.Play();
            initialPos = finalPos;
        }

    }
}
