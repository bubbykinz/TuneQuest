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

    IEnumerator ExampleCoroutine()
    {
        for(int i=0; i < 5; i++)
        {
            yield return new WaitForSeconds(.5f);
            audioSrc.volume -= (float) .1;
        }
    }

    IEnumerator FinalDoorCoroutine()
    {
        for(int i=0; i < 1; i++)
        {
            yield return new WaitForSeconds(.5f);
            audioSrc.volume -= (float) .05;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" && !hasEntered)
        {
            hasEntered = true;
            if(this.name == "Door 6" || this.name == "Door 7")
            {
                audioSrc.volume = .1f;
                StartCoroutine(FinalDoorCoroutine());
            }
            else
            {
                audioSrc.volume = .6f;
                StartCoroutine(ExampleCoroutine());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
