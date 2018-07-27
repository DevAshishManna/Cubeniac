using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float score;
    public float movementSpeed;
    Vector3 m_EulerAngleVelocity;

    private bool movingLeft;
    public Rigidbody rb;


    // Use this for initialization
    void Start () {
        m_EulerAngleVelocity = new Vector3(0, 0, 100);
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
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

        }
        else
        {
            rb.AddForce(movementSpeed,0,0,ForceMode.Acceleration);
            Quaternion deltaRotation = Quaternion.Euler(-m_EulerAngleVelocity * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
	}
}
