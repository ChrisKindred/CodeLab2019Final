using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{

    // Values for faking a nice turn display
    public float turnRotationAngle;
    public float turnRotationSeekSpeed;
    
    // Values that control the vehicle
    public float acceleration;
    public float rotationRate;
    
    // Reference variables we don't directly use

    private float rotationVelocity;
    private float groundAngleVelocity;
   
    
    void FixedUpdate()
    {
        // Check if we are touching the ground
        if (Physics.Raycast(transform.position, transform.up * -1, 3f))
        {
            // We are on the ground; enable the accelerator and increase drag:
            GetComponent<Rigidbody>().drag = 1;

            // Calculate forward force:
            Vector3 forwardForce = transform.forward * acceleration * Input.GetAxis("Vertical");
            // Correct force for deltaTime and vehicle mass:
            forwardForce = forwardForce * Time.deltaTime * GetComponent<Rigidbody>().mass;

            GetComponent<Rigidbody>().AddForce(forwardForce);
        } else {
            // We aren't on the ground and don't want to just halt in mid-air; reduce drag:
            GetComponent<Rigidbody>().drag = 0;
        }
        // You can turn in the air on the ground:
        Vector3 turnTorque = Vector3.up * rotationRate * Input.GetAxis("Horizontal");
        //Correct force for deltaTime and vehicle mass:
        turnTorque = turnTorque * Time.deltaTime * GetComponent<Rigidbody>().mass;
        GetComponent<Rigidbody>().AddTorque(turnTorque);
        
        //"Fake" rotate the car when you are turning:
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z = Mathf.SmoothDampAngle(newRotation.z, Input.GetAxis("Horizontal") * -turnRotationAngle,
            ref rotationVelocity, turnRotationSeekSpeed);
        transform.eulerAngles = newRotation;
    }
}
