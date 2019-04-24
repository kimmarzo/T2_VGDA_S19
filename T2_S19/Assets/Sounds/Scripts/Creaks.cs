using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creaks : MonoBehaviour
{
    AudioSource creak_sound;
    private float randomTime;
    private float timeCounter;
    private int steppedOn;

    // Start is called before the first frame update
    void Start()
    {
        SphereCollider sphereCollider = gameObject.GetComponent<SphereCollider>();
        sphereCollider.isTrigger = true;
        creak_sound = GetComponent<AudioSource>();
        randomTime = 2.0f;
        timeCounter = 0.0f;
        steppedOn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        if (steppedOn == 1)
        {
            ResetTimer();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (creak_sound.isPlaying == false && timeCounter > randomTime)
        {
            steppedOn = 1;
            creak_sound.Play();
        }
    }

    private void ResetTimer()
    {
        randomTime = Random.Range(15.0f, 20.0f);
        timeCounter = 0.0f;
        steppedOn = 0;
    }
}
