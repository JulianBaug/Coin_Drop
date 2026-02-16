using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    Vector2 startPos;

    Quaternion startRotation;

    Rigidbody2D rb;

    public float resetHeight = -6;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        startPos = transform.position;

        startRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.y <= resetHeight || Input.GetButtonDown("Fire1"))
        {
            transform.position = startPos;
            transform.rotation = startRotation;
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0;
            rb.gravityScale = 0;
        }

    }
}
