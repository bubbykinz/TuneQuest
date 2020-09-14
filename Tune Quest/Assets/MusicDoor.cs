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
        for(int i=0; i < 4; i++)
        {
            yield return new WaitForSeconds(.5f);
            audioSrc.volume -= (float) .1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" && !hasEntered)
        {
            Debug.Log("Hit Door");
            hasEntered = true;
            audioSrc.volume = .6f;
            StartCoroutine(ExampleCoroutine());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
