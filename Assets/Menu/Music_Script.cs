using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Script : MonoBehaviour
{
    AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        music.PlayDelayed(30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
