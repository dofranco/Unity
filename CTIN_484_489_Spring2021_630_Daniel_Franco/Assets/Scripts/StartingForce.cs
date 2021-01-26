using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartingForce : MonoBehaviour
{

    float currPower = .95f;
    //float minPower = 0.0f;
    //float endPower = 100.0f;
    public Text beginText;
    public Rigidbody ballRB;
    bool ballReady;

    // Start is called before the first frame update
    void Start()
    {
      //  powerSlider.minValue = 0.0f;
       // powerSlider.maxValue = endPower;
        //ballList = new List<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ballReady)
        {
            beginText.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                ballRB.AddForce(currPower * Vector3.forward);
            }
        }

        else
        {
            beginText.gameObject.SetActive(false);
        }

        /*
        if(ballReady)
        {
            powerSlider.gameObject.SetActive(true);
        }

        else
        {
            powerSlider.gameObject.SetActive(false);
        }

        powerSlider.value = currPower;
        if(ballList.Count > 0)
        {
            ballReady = true;
            if(Input.GetKey(KeyCode.Space))
            {
                r.AddForce(currPower * Vector3.forward);
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
               foreach(Rigidbody r in ballList)
                {
                    r.AddForce(currPower * Vector3.forward);
                }
            }
        }

        else
        {
            ballReady = false;
            //currPower = 0.0f;
        }
        */

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            ballReady = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        ballReady = false;

        /*
        if (other.gameObject.CompareTag("Ball"))
        {
            ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            currPower = minPower;
        }
        */
    }
    
}
