using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//Usage: To make a maze game
//Intent: Spawn hazards and boost prizes

public class LevelLoader : MonoBehaviour
{
//    public GameObject obstacle1;
    public GameObject Hazard;
    public GameObject Prize;




    // Start is called before the first frame update
    void Start()
    {
        LoadFromText();
        LoadFromText();
        LoadFromText();
        LoadFromText();
        LoadFromText();
        LoadFromText();
        LoadFromText();
        LoadFromText();
        LoadFromText();       
        LoadFromText();      
        LoadFromText();      
        LoadFromText();
        LoadFromText();
        LoadFromText();       
        LoadFromText();
        LoadFromText();        
        LoadFromText();
        LoadFromText();
        LoadFromText();       
        LoadFromText();       
        LoadFromText();
        LoadFromText();      
        LoadFromText();        
        LoadFromText();       
        LoadFromText();
        LoadFromText();
        LoadFromText();      
        LoadFromText();
        LoadFromText();      
        LoadFromText();
        LoadFromText();
        LoadFromText();        
        LoadFromText();


        

    }

    public void LoadFromText()
    {

        string filePath = Application.dataPath + "/level0.txt"; // Declaring and initializing a string path.
        if (!File.Exists(filePath)) //is there a file with this name on your computer
        {
            File.WriteAllText(filePath, "X");
            File.WriteAllText(filePath, "B");
            
            // Creates a new file, writes the specified string to the file,
            // and then closes the file. If the target file already exists,
            // it is overwritten.
        }

        //The following string inputLine holds all text from the .txt file

        string inputLine = File.ReadAllText(filePath);
        //  Debug.Log(inputLine);

        //This for loop is going through each character in the line of the .txt file

        for (int i = 0; i < inputLine.Length; i++)
        {
//            Debug.Log("it works!");
//            Debug.Log("index " + i);
//            Debug.Log("stuff " + inputLine[i]);
            GameObject obstacleObject = null;
            

            //This if statement instantiates a new GameObject and changes its position
            //The position vector changes based on index i

            if (inputLine[i] == 'X')
            { 
                obstacleObject = Instantiate<GameObject>(GameObject.FindGameObjectWithTag("Hazard"));
                obstacleObject.transform.position = new Vector3(Random.Range(-15f, 18f), 1, (Random.Range(50f, 2000f))); //i * int
            }

            if (inputLine[i] == 'B')
            {
                obstacleObject = Instantiate<GameObject>(Prize);
                obstacleObject.transform.position = new Vector3(Random.Range(-15f, 18f), 1, (Random.Range(50f, 2000f)));
            }
        }


       
    }
}

