using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger : MonoBehaviour
{

    public bool entered;
    public Transform spawnPoint;
    public GameObject Prefab;
    public int levelToLoad = 0;

    private bool levelIsLoaded = false;
    
    public void OnTriggerEnter()
    {
        if (levelIsLoaded)
        {
            return;//don't want to instantiate this twice!
        }
        Instantiate(Prefab, spawnPoint.position, spawnPoint.rotation);
        LevelLoader.me.LoadFromText(levelToLoad, transform.position.z); //load level 1 (the second level)
        levelIsLoaded = true;
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
