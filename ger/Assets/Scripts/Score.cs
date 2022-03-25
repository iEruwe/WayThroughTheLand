using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading;

public class Score : MonoBehaviour
{
    public GameObject background;
    double score = 0, data;

    void Start()
    {
       

        StreamReader scoredata = new StreamReader(Application.persistentDataPath + "/score.gd");
        data = float.Parse(scoredata.ReadLine());
        scoredata.Close();
    }
  
    // Update is called once per frame
    void Update()
    {

        score = score + 1;
       

        if (score > data)
        {
            StreamWriter scoredata = new StreamWriter(Application.persistentDataPath + "/score.gd");
            scoredata.WriteLine(score);
            scoredata.Close();
        }
        //if (score > 1000)
        //{
        //    background.transform.Translate(new Vector3(-0.1f, 0f, 0f));
        //}
    }
    
void OnGUI()
{
    GUI.Box(new Rect(0, 0, Screen.width*1, Screen.height * 1f), "Distance(m): " + score);
}
}
