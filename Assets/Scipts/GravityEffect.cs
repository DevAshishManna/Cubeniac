using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityEffect : MonoBehaviour {

   

    void Start()
    {
        
    }

    // Disables gravity on all rigidbodies entering this collider.
    void OnCollisionEnter(Collision other)
    {
        print("HI");

        if (other.gameObject.tag != "Friendly")
        {
            print("HI");
            other.collider.attachedRigidbody.useGravity = false;
            //other.attachedRigidbody.isKinematic = true;
        }
                    
    }
}
