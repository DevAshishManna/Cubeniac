using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public GameObject particles;
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
        scoreText.GetComponent<Text>().text = "Score " + newScore;
    }

    // Update is called once per frame
    void Update () {
        score += Time.deltaTime;
        newScore = (int)score;
        particles.transform.position = this.transform.position+new Vector3(movingLeft?1:-1,0,0);
        if (Input.GetMouseButtonDown(0))
        {
            movingLeft = !movingLeft;
        }



        if (movingLeft)
        {
            particles.transform.rotation = new Quaternion(0, 0, 0, 0);
            rb.AddForce(-movementSpeed,0,0,ForceMode.Acceleration);
            
        }
        else
        {
            particles.transform.rotation = new Quaternion(0, 0, 1, 0);
            rb.AddForce(movementSpeed,0,0,ForceMode.Acceleration);
  
        }
	}
}
