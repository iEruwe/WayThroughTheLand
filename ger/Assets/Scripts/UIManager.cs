using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public Text scoreText;

	private int score;

	void Start()
	{
		Time.timeScale = 1;
		score = PlayerPrefs.GetInt("savescore");
		scoreText.text = $"Your best score: {score}";
	}

	public void Reload()  
	{
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		SceneManager.LoadScene(0);
		
	}

	//loads inputted level
	public void LoadLevel(string level)
	{
		SceneManager.LoadSceneAsync(level);
	}

	public void Exit()
	{
		Debug.Log("Exit pressed");
		Application.Quit();
	}
}

