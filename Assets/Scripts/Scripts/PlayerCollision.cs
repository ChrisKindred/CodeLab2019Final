using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    
    public PlayerMovement movement;
    public float delay;
    
    private void OnCollisionEnter (Collision collisionInfo) 
    {
       
        if (collisionInfo.collider.CompareTag("Hazard"))
        {
            Debug.Log("We hit a Hazard!");
            Destroy(gameObject.GetComponent("TrackObject"));
            //Invoke("LoadScene", delay);
            GameManager.Instance.GameOver();
            SceneManager.LoadScene("SampleScene");

            // FindObjectOfType<GameManager>().EndGame();
            // Detach camera from Hoverboard
            // Restart the game on collision

            //  FindObjectOfType<>;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Prize"))
        {
            Debug.Log("We got a pickup!");
            
            
            //Destroy the Prize gameObject on collision, then add +1 to the player's score
            //Debug.Log("+1")
            GameManager.Instance.Score += 1;
            Destroy(other.gameObject);
                
                
            
        }

    }

   
    
        
   
}
