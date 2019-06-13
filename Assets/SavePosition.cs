using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Windows;


/*
public class SavePosition : MonoBehaviour
{
    private string filePath;
    private int[] highScores;
    
    
    string filePath = Application.dataPath + "/pos.json";

    // Start is called before the first frame update
    void Start()
    {
        highScores = new int[10];

        string spString = JsonUtility.ToJson(this), prettyPrint: true;
        
       
        
        if ((File.Exists(filePath))
        {
            string contents = File.ReadAllText(filePath);

            transform.position = JsonUtility.FromJson<Vector3>(contents);
        }
    }

    // Update is called once per frame
    void Update() {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = transform.position;
          
            string positionStr = JsonUtility.ToJson(position, prettyPrint: true);
            
            print(positionStr);

            File.WriteAllText(filePath, positionStr);
        }
    }
}
*/
