using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic2 : MonoBehaviour
{
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //Press the 'p' key to paly or pause the audio
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!audioSource.isPlaying)
            {
                //Pause the audio if it's currently playing
                audioSource.Pause();
            }

            else
            {
                //Start playing the audio if it's paused or hasn't started yet
                audioSource.Play();
            }
        }
    }
}
