using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//Usage: To make a maze game
//Intent: Spawn hazards and prizes along set parameters

public class LevelLoader : MonoBehaviour
{
//    public GameObject obstacle1;
    public GameObject LeftHazard;
    public GameObject CenterHazard;
    public GameObject RightHazard;
    public GameObject Prize;


    public int xDistanceInterval;
    public int zDistanceInterval;


    // Start is called before the first frame update
    void Start()
    {
        LoadFromText();


    }

    public void LoadFromText()
    {

        string filePath = Application.dataPath + "/level0.txt"; // Declaring and initializing a string path.


        /*
        if (!File.Exists(filePath)) //is there a file with this name on your computer
        {
            //we didn't find a level file, so let's make a temp level
            File.WriteAllText(filePath, "LLLLLLLLL");
            // Creates a new file, writes the specified string to the file,
            // and then closes the file. If the target file already exists,
            // it is overwritten.
        }
        else
        {
            Debug.Log("File was found");
        }
   */

        //The following string inputLine holds all text from the .txt file

        string inputLine = File.ReadAllText(filePath);
        Debug.Log("InputLine: " + inputLine);

        //This for loop is going through each character in the line of the .txt file

        for (int i = 0; i < inputLine.Length; i++)
        {
//            Debug.Log("it works!");
//            Debug.Log("index " + i);
//            Debug.Log("stuff " + inputLine[i]);
            GameObject obstacleObject = null;


            //This if statement instantiates a new GameObject and changes its position
            //The position vector changes based on index i

            if (inputLine[i] == 'L')
            {
                Debug.Log("found L in file");
                obstacleObject = Instantiate<GameObject>(GameObject.FindGameObjectWithTag("Hazard"));
                obstacleObject.transform.position =
                    new Vector3(Random.Range(-14f, -4f), 1, i * zDistanceInterval); //i * int
            }

            if (inputLine[i] == 'C')
            {
                Debug.Log("found C in file");
                obstacleObject = Instantiate<GameObject>(GameObject.FindGameObjectWithTag("Hazard"));
                obstacleObject.transform.position =
                    new Vector3(Random.Range(-15f, 18f), 1, i * zDistanceInterval); //i * int
            }

            if (inputLine[i] == 'R')
            {
                Debug.Log("found R in file");
                obstacleObject = Instantiate<GameObject>(GameObject.FindGameObjectWithTag("Hazard"));
                obstacleObject.transform.position =
                    new Vector3(Random.Range(-15f, 18f), 1, i * zDistanceInterval); //i * int
            }

            if (inputLine[i] == 'P')
            {
                Debug.Log("found P in file");
                obstacleObject = Instantiate<GameObject>(Prize);
                obstacleObject.transform.position = new Vector3(Random.Range(-15f, 18f), 1, i * zDistanceInterval);
            }
        }



    }
}





