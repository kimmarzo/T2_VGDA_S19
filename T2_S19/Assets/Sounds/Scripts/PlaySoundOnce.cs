using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnce : MonoBehaviour
{
    AudioSource sound;
    bool alreadyPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!alreadyPlayed)
        {
            sound.Play();
            alreadyPlayed = true;
            Debug.Log("Played ghost sound");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
