using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject background1;
    public GameObject background2;
    public GameObject background3;
    public GameObject background4;
    public GameObject background5;
    public Text scoreCounter;
    public float speed = 0.03f;
    private int score = 0;
    private int data;
    private float frame;

    void Start()
    {
        data = PlayerPrefs.GetInt("savescore");
        Time.timeScale = 1;
        Debug.Log($"{Time.timeScale}");
        frame = 0;
    }
  
    // Update is called once per frame
    void Update()
    {
        scoreCounter.text = score.ToString();

        if (Time.timeScale > 0)
        {
            frame++;
        }

        if ((frame % 75) == 0)
        {
            score++;
        }
       
        if (score > data)
        {
            scoreCounter.color = Color.red;
            PlayerPrefs.SetInt("savescore", score);
            PlayerPrefs.Save();
            Debug.Log("Best score saved");
        }

        background1.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
        if (background1.transform.position.x < -50)
        {
            background1.transform.position = new Vector3(125, 0, 0);
        }

        background2.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
        if (background2.transform.position.x < -50)
        {
            background2.transform.position = new Vector3(125, 0, 0);
        }

        background3.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
        if (background3.transform.position.x < -50)
        {
            background3.transform.position = new Vector3(125, 0, 0);
        }

        background4.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
        if (background4.transform.position.x < -50)
        {
            background4.transform.position = new Vector3(125, 0, 0);
        }

        background5.transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
        if (background5.transform.position.x < -50)
        {
            background5.transform.position = new Vector3(125, 0, 0);
        }
    }
}
