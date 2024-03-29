using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic2 : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isPaused = false; // Flag to track pause state


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
            if (isPaused)
            {
                //If currently paused, resume playing
                audioSource.UnPause();
                isPaused = false;   
            }

            else
            {
                //If currently playing, pause
                audioSource.Pause();
                isPaused = true;   
            }
        }
    }
}
