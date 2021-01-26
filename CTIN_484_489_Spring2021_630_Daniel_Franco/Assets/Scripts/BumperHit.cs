using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BumperHit : MonoBehaviour
{
    static int score;
    private int addScore = 1000;

    public Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = "Score: " + score;
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            score += addScore;
            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 50);

        }
    }
}
