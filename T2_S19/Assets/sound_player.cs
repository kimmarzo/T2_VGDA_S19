using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_player : MonoBehaviour
{
    AudioSource walking_source;
    AudioClip walking_clip;
    Vector3 initialPos;
    Vector3 finalPos;
    // Start is called before the first frame update
    void Start()
    {
        walking_source = gameObject.GetComponent<AudioSource>();
        initialPos = gameObject.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        finalPos = gameObject.transform.localPosition;
  

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
