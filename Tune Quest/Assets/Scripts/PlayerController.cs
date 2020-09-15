using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 3;
    public float slowDown = .8f;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
            if (horizontal != 0)
            {
            rb.AddForce(new Vector2(horizontal, 0) * moveSpeed * Time.deltaTime);
            }
        if (vertical != 0)
        {
            rb.AddForce(new Vector2(0, vertical) * moveSpeed * Time.deltaTime);
        }      
        if (horizontal == 0 && vertical == 0)
            {
            rb.velocity = rb.velocity * slowDown;
            }
        }

    }

