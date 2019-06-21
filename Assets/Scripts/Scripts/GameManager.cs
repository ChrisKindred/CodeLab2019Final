using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public int highScore;
    private Text highScoreText;
    
    void Awake()
    {
        if(_instance == null) // does _instance exist? if not, set this as the _instance.
            _instance = this;
        else if(_instance  != this) //if _instance exists, destroy the new _instance and keep the old one.
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        
        Init();  
    }

    private void Init()
    {
        Score = 0;
        IsDead = false;
    }
    
    
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
          
                SceneManager.LoadScene("SampleScene");
      
        }
        
        SetHighScore();
    }

    
    public void SetHighScore() //Checks if our current score is higher than the high score, and changes the high score and high score text to the current high score.
    {
        if(highScoreText == null) // if the HST is null, then we get and set the high score text object.
            highScoreText = GameObject.Find("High Score").GetComponent<Text>();
        if(Score > highScore)
            highScore = Score;
        highScoreText.text = "High Score: " + highScore; //updating the text.
    }


    public void GameOver() //called when the game is over! resets those variables real good.
    {
        Score = 0;
        IsDead = false;    
    }
    
}

