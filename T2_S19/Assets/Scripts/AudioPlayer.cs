using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{

    public AudioClip walk_1_clip;
    public AudioClip walk_2_clip;
    public AudioClip walk_3_clip;
    public AudioClip soft_wind_clip;
    public AudioClip ui_clip;

    public AudioSource walk_1_source;
    public AudioSource walk_2_source;
    public AudioSource walk_3_source;
    public AudioSource soft_wind_source;
    public AudioSource ui_source;


    // Start is called before the first frame update
    void Start()
    {
        walk_1_source.clip = walk_1_clip;
        walk_2_source.clip = walk_2_clip;
        walk_3_source.clip = walk_3_clip;
        soft_wind_source.clip = soft_wind_clip;
        ui_source.clip = ui_clip;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
