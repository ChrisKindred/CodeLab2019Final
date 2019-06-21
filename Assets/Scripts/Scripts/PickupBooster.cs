using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBooster : MonoBehaviour
{   
    
    
    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("entered");
            Destroy(gameObject);
        }
    }
    
    
}
