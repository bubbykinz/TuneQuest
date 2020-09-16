using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicDoor : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioSrc;
    bool hasEntered = false;
    Image musicImage;

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

    private string correctDoor(string door)
    {
        if(door == "Door 2")
        {
            return "Door 0";
        }
        if(door == "Door 7")
        {
            return "Door 1";
        }
        if(door == "Door 6")
        {
            return "Door 2";
        }
        if(door == "Door 5")
        {
            return "Door 3";
        }
        if(door == "Door 0")
        {
            return "Door 4";
        }
        if(door == "Door 4")
        {
            return "Door 5";
        }
        if(door == "Door 1")
        {
            return "Door 6";
        }
        else
            return "Door 7";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" && !hasEntered)
        {
            hasEntered = true;
            
            string door = correctDoor(this.name);

            Image obj = GameObject.FindGameObjectWithTag(door).GetComponent<Image>();
            obj.enabled = true;

            if(door == "Door 6" || door == "Door 7")
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
