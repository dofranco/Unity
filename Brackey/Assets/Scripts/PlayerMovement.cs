using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    //make a variable here so that it can be edited in the Inspector
    public float forwardForce = 2000f;
    public float xForce = 500f;

    // Update is called once per frame
    // Use FixedUpdate whenever using physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //for binary button pushes, such as jumping, perfom that on Update()
        //using booleans
        if(Input.GetKey("d"))
        {
            rb.AddForce(xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
