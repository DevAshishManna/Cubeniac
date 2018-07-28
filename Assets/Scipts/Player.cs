using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float score;
    public float movementSpeed;

    private bool movingLeft;
    public Rigidbody rb;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        score = 0;
        movingLeft = true;

	}
	
	// Update is called once per frame
	void Update () {
        score = Time.deltaTime;

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
