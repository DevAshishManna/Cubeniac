using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public GameObject particles;
    public GameObject obstecles;
    public float score;
    public int newScore;
    public float movementSpeed;

    private bool movingLeft;
    public Rigidbody rb;

    public Text scoreText;
    private int previousSecond;
   

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        score = 0;
        movingLeft = true;

        obstecles.GetComponent<Rigidbody>().drag = 2f;
        previousSecond = 0;

       
    }

    void FixedUpdate()
    {
        scoreText.GetComponent<Text>().text = "Score " + newScore;
    }

    // Update is called once per frame
    void Update () {
        score += Time.deltaTime;
        newScore = (int)score;

        
        int seconds = (int)(newScore % 60);
        
        float newDrag = (obstecles.GetComponent<Rigidbody>().drag);

        if(newDrag > 0 && seconds % 10 == 0 &&  seconds!=previousSecond)
        {
            newDrag = newDrag - 0.1f;
            obstecles.GetComponent<Rigidbody>().drag = newDrag;
        }

        if (newDrag < 0)
        {
            obstecles.GetComponent<Rigidbody>().drag = 0;
        }
        previousSecond = seconds;
        

        particles.transform.position = this.transform.position+new Vector3(movingLeft?1:-1,0,0);
        if (Input.GetMouseButtonDown(0))
        {
            movingLeft = !movingLeft;
        }



        if (movingLeft)
        {
            particles.transform.rotation = new Quaternion(0, 0, 0, 0);
            rb.AddForce(-movementSpeed * Time.deltaTime,0,0,ForceMode.Acceleration);
            
        }
        else
        {
            particles.transform.rotation = new Quaternion(0, 0, 1, 0);
            rb.AddForce(movementSpeed * Time.deltaTime,0,0,ForceMode.Acceleration);
  
        }
	}
}
