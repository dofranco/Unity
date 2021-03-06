using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartingForce : MonoBehaviour
{

    float currPower = 1.0f;
    public Text beginText;
    public Rigidbody ballRB;
    bool ballReady;

    public AudioSource audioSource;
    bool playOnce = true;

    // Update is called once per frame
    void Update()
    {
        if(ballReady)
        {
            beginText.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                if(playOnce)
                {
                    audioSource.PlayOneShot(audioSource.clip);
                    playOnce = false;
                }
                ballRB.AddForce(currPower * Vector3.forward);
            }
        }

        else
        {
            beginText.gameObject.SetActive(false);
            playOnce = true;
        }

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
    }
    
}
