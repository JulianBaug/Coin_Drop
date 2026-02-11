using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Spin : MonoBehaviour
{
    //a reference to a component we will access continually in FixedUpdate().

    Rigidbody2D rb;
    

    public float speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        //using GetComponent to takes time, so we do it in Start() instead of Update() or FixedUpdate()
        rb = GetComponent<Rigidbody2D>();
    }
    // FixedUpate() is like Update() but called multiple times per Update() to get smaller, consistent slices of time
    //   because it is used to update physics calculations, it tries to be framerate independent
    void FixedUpdate()
    {
          rb.angularVelocity = speed;
    }
}
