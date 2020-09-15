using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRoomScript : MonoBehaviour
{
    [SerializeField] GameObject[] wallsToSpawn;
    [SerializeField] Vector3 cameraMovement;
    [SerializeField] Vector3 playerTeleportDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Camera.main.gameObject.transform.position += cameraMovement;
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position += playerTeleportDistance;

            foreach (GameObject wall in wallsToSpawn)
            {
                wall.SetActive(true);
            }
                
        }
    }
}
