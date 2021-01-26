using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddles : MonoBehaviour
{
    //this gives you then name of which axis you're using
    // in this case it will be one of the paddles hinge joints
    public string axisName;

    public float power = 10000f;

    //the damper changes the smoothness of the paddles
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
