using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().Pause();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
