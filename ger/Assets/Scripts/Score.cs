using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading;

public class Score : MonoBehaviour
{
    //public GameObject background;
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    public GameObject background4;
    public GameObject background5;
    private float speed = 0.3f;
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
        background1.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
        if (background1.transform.position.x < -50)
        {
            background1.transform.position = new Vector3(60, 0, 0);
        }
        background2.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
        if (background2.transform.position.x < -50)
        {
            background2.transform.position = new Vector3(60, 0, 0);
        }
        background3.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
        if (background3.transform.position.x < -50)
        {
            background3.transform.position = new Vector3(60, 0, 0);
        }
        background4.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
        if (background4.transform.position.x < -50)
        {
            background4.transform.position = new Vector3(60, 0, 0);
        }
        background5.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
        if (background5.transform.position.x < -50)
        {
            background5.transform.position = new Vector3(60, 0, 0);
        }
    }
    
    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, Screen.width*1, Screen.height * 1f), "Distance(m): " + score);
    }
}
