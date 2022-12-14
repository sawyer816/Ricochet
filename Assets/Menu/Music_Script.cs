using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Music_Script : MonoBehaviour
{
    
    AudioSource music;
    Slider VolumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        music.PlayDelayed(30);
        VolumeSlider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        music.volume = VolumeSlider.value;
    }
}
