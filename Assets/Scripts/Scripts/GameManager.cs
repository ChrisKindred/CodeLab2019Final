using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

//    public void EndGame()
//    {
//        Debug.Log("Game Over"); 
//        
//    }


    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            //create logic to create the instance
            if (_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }

            return _instance;
        }
        
    }
  
  

//    public int score;
//    public bool isDead;
    
    public int Score { get; set;}
    public bool IsDead { get; set;}
    
    void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
          
                SceneManager.LoadScene("SampleScene");
      
        }
        
    
    }
}

