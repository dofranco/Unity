using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddles : MonoBehaviour
{
    public string axisName;

    public float power = 10000f;
    public float dampener = 150.0f;
    public float startingPos = 0.0f;
    public float endPos = 45.0f;

    HingeJoint hingeJ;

    // Start is called before the first frame update
    void Start()
    {
        hingeJ = GetComponent<HingeJoint>();
        hingeJ.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        //allocate a new jointspring
        JointSpring jSpring = new JointSpring();

        //set jointspring equal to power
        jSpring.spring = power;
        jSpring.damper = dampener;

        if(Input.GetAxis(axisName) == 1)
        {
            //button was pressed, spring should be equal to our ending position, this is an angle
            jSpring.targetPosition = endPos;
        }

        else
        {
            //button is not pressed, spring should return to start position.
            jSpring.targetPosition = startingPos;
        }

        hingeJ.spring = jSpring;
        hingeJ.useLimits = true;

    }
}
