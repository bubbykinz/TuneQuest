using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    MusicDoor [] allDoors;
    AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] doors = GameObject.FindGameObjectsWithTag("Door");
        allDoors = new MusicDoor[doors.Length];

        for(int i = 0; i < allDoors.Length; i++)
        {
            allDoors[i] = doors[i].GetComponent<MusicDoor>();
            audioSrc = doors[i].GetComponent<AudioSource>();
            audioSrc.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
