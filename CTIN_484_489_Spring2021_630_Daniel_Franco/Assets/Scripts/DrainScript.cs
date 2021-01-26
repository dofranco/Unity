using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrainScript : MonoBehaviour
{
    //total balls
    public int ballCount;

    //text to represent balls
    public Text ballText;

    public Text gameOver;

    //starting position of ball
    Vector3 ballStartPos;

    public GameObject player;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        ballStartPos = player.GetComponent<Transform>().position;
        ballCount = 3;
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ballText.text = "Remaining balls: " + ballCount;

        if (Input.GetKey("r"))
        {
            player.transform.position = ballStartPos;

            ballCount = 3;

            if(Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }

            gameOver.gameObject.SetActive(false);
        }

    }


    
    private void OnTriggerEnter(Collider other)
    {
        ballCount -= 1;
        audioSource.PlayOneShot(audioSource.clip);

        if (ballCount <= 0)
        {
            Time.timeScale = 0;
            gameOver.gameObject.SetActive(true);

        }
        else
        {
            player.transform.position = ballStartPos;
        }
    }

    
}
