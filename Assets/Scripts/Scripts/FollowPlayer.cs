using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform Player;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
      //  Debug.Log("player.position");
        transform.position = Player.position + offset;
        
    }
}
