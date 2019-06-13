using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //USAGE: Code Lab 1 Midterm
    //INTENT: To revisit a game I made with no programming skill to test what I've learned since I approached it last.
   
    
public Rigidbody rb;               // permission + type + name = function
public float forwardForce = 2000f; //Makes forwardForce public in the inspector
public float sidewaysForce = 500f; //The function sidewaysForce keeps us from having to hard code the force into the variable
public float boostForce = 1000f;
public float brakeForce = -2000f;
    
    // Update is called once per frame
    void FixedUpdate() //FixedUpdate can sync forces with Unity's physics engine
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Time.deltaTime is the amount of seconds since the last frame update. Force is added using the z parameter
                                                          //forwardForce is a variable referenced by "public float forwardForce"
    if(Input.GetKey("d")) //Conditions to trigger the if statement
        {
            rb.AddForce(sidewaysForce, 0, 0);
        }
        
    if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce, 0, 0); //moves Player along the x axis in the negative direction from the first
        }

    if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, boostForce);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, brakeForce);
        }


//        if (rb.position.y < 300)
//        {
//            FindObjectOfType<GameManager>().EndGame();
//        }
//        
      
        
    }
}
