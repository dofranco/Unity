using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Rigidbody rb;
    private bool gameStart = true;
    public float xForce = 1000;
    public float grav = 10;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(grav, 0, 0);

        if (gameStart)
        {
            if (Input.GetKey("z"))
            {
                rb.AddForce(-xForce, 0, 0);
                gameStart = false;
            }
        }
    }
}
