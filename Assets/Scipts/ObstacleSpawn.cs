using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour {

    public GameObject player;
    public GameObject obstacle;

    public float amountOfObstacle;
    public float minX, maxX;

    public float spawnTime = 2f;            // How long between each spawn.
    public float fallSpeed = 40.0f;    //The speed of falling Apples
    private float timer = 0;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;   // Timer Counter
        if (timer > spawnTime)
        {
            SpawnRandom();       //Calling method SpawnRandom()
            timer = 0;        //Reseting timer to 0
        }

    }

    public void SpawnRandom()
    {
        for (int i = 0; i < amountOfObstacle; i++)
        {
            Vector3 pos = new Vector3(Random.Range(minX, maxX), Random.Range(player.transform.localPosition.y * 4, transform.localPosition.y * 8), 0);
            Instantiate(obstacle.transform, pos, Quaternion.identity);
        }
    }
}
