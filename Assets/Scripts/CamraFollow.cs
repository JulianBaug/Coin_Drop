using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    float Speed;
    public float offset;
    public Transform target;
    public Rigidbody2D rb;
    Vector2 startPosCoin;
    Transform cameraMain;
    Vector3 startPos;

    void Start()
    {
        cameraMain = GetComponent<Transform>();
        startPos = cameraMain.position;
        startPosCoin = target.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(target.position.y == startPosCoin.y)
        {
            cameraMain.position = startPos;
        }
        else
        {
            Speed = rb.velocity.y;
        }



        if (target.position.y >= (offset + target.position.y) && transform.position.y >= ((offset / 2) + target.position.y) && transform.position.y <= ((offset / 2) - target.position.y))
        {
            transform.Translate(0, -Speed * Time.deltaTime, 0);
        }
        else if (target.position.y <= (offset - target.position.y) && transform.position.y >= ((offset / 2) + target.position.y) && transform.position.y <= ((offset / 2) - target.position.y))
        {
            transform.Translate(0, Speed * Time.deltaTime, 0);
        }
    }
}
