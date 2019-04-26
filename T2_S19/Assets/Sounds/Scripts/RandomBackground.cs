using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBackground : MonoBehaviour
{
    AudioSource[] audioArray;
    private int currentMusic;
    private float randomTime;
    private float timeCounter; 
    // Start is called before the first frame update
    void Start()
    {
        audioArray = GetComponents<AudioSource>();
        currentMusic = 0;
        randomTime = 120.0f;
        timeCounter = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeCounter > randomTime)
        {
            randomTime = Random.Range(60.0f, 180.0f);
            timeCounter = 0.0f;
            ChooseBackground();
        }

        timeCounter += Time.deltaTime;
    }

    void ChooseBackground()
    {
        currentMusic = Random.Range(0, 3);

        if (currentMusic == 1)
        {
            audioArray[1].Play();
            Debug.Log("Played 1");
        }
        else if (currentMusic == 2)
        {
            audioArray[2].Play();
            Debug.Log("played 2");
        }
        else if (currentMusic == 3)
        {
            audioArray[3].Play();
            Debug.Log("Played 3");
        }
    }
}
