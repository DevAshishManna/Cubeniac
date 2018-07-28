using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private float score;
    private int newScore;
    public float movementSpeed;

    private bool movingLeft;
    public Rigidbody rb;

    public Text scoreText;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        score = 0;
        movingLeft = true;

	}

    void FixedUpdate()
    {
        scoreText.GetComponent<Text>().text = "Score = " + newScore;
    }

    // Update is called once per frame
    void Update () {
        score += Time.deltaTime;
        newScore = (int)score;

        if (Input.GetMouseButtonDown(0))
        {
            movingLeft = !movingLeft;
        }

        if (movingLeft)
        {
            rb.AddForce(-movementSpeed,0,0,ForceMode.Acceleration);
            
        }
        else
        {
            rb.AddForce(movementSpeed,0,0,ForceMode.Acceleration);
  
        }
	}
}
