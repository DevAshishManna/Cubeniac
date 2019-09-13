using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GravityEffect : MonoBehaviour {

   

    void Start()
    {
        
    }

    // Disables gravity on all rigidbodies entering this collider.
    void OnCollisionEnter(Collision other)
    {
     
        if (other.gameObject.tag == "Thanos")
        {
            Destroy(gameObject);
        }
        else if(other.gameObject.tag == "Friendly")
        {
            /*
            if (SceneManager.GetActiveScene().buildIndex == 0) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }else if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            */
            DataHelper.score = other.gameObject.GetComponent<Player>().newScore;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
                    
    }
}
