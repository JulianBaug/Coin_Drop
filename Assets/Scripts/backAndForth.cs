using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backAndForth : MonoBehaviour
{

    public float speed = 5; //speed stores the amount of horizontal distance to move per split second

    public float outsideCamraX = 8.41f;
    float startY;


    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y == startY)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);

            if (transform.position.x > outsideCamraX || transform.position.x < -outsideCamraX)
            {
                speed *= -1;
            }
        }

    }
}
