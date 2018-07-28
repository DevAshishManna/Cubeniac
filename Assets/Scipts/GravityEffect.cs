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
     
        if (other.gameObject.tag != "Friendly")
        {
            Destroy(gameObject);
        }
        else if(other.gameObject.tag == "Friendly")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
                    
    }
}
