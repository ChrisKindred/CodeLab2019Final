using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger : MonoBehaviour
{

    public bool entered;
    public Transform spawnPoint;
    public GameObject Prefab;
    
    public void OnTriggerEnter()
    {
        
        Instantiate(Prefab, spawnPoint.position * 30, spawnPoint.rotation);

//        Debug.Log("Trigger entered!");
//        if (entered == true)
    }

    private void FixedUpdate()
    {
        if (entered == true)
        {
            GetComponent<LevelLoader>();
        }
    }
}
