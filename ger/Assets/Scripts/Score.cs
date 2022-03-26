using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading;

public class Score : MonoBehaviour
{
    //public GameObject background;
    private int score = 0;
    private int data;
    private int frame;
    public GUIStyle mystyle; //объявляется для того чтобы изменять начертание GUI компонентов(шрифт, размер и.т.п.)

    void Start()
    {
        StreamReader scoredata = new StreamReader(Application.persistentDataPath + "/score.gd");
        data = int.Parse(scoredata.ReadLine());
        scoredata.Close();
        Time.timeScale = 1;
        Debug.Log($"{Time.timeScale}");
    }
  
    // Update is called once per frame
    void Update()
    {
        frame++;

        if (frame % 100 == 0)
        {
            score++;
            Time.timeScale += 0.002f;
            Debug.Log($"Speed up: {Time.timeScale}");
        }
       
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
