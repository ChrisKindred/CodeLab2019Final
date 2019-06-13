using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
      
    private void OnCollisionEnter (Collision collisionInfo) 
    {
        if (collisionInfo.collider.CompareTag("Prize"))
        {
            Debug.Log("We got a pickup!");
            //Destroy the Prize gameObject on collision, then add +1 to the player's score
            
            //Debug.Log("+1")
            
            
          //  FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.CompareTag("Hazard"))
        {
            Debug.Log("We hit a Hazard!");
            // FindObjectOfType<GameManager>().EndGame();
            // Detach camera from Hoverboard
            // Restart the game on collision

            //  FindObjectOfType<>;
        }
    }
}
