using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDoor : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSrc;
    bool hasEntered = false;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Door" && !hasEntered)
        {
            audioSrc.volume = 1;
            hasEntered = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
