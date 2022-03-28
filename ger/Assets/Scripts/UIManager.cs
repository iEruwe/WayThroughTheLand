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
	public Slider MusicSlider;
	public Slider SoundSlider;

	private int score;

	void Start()
	{
		Time.timeScale = 1;
		try
		{
			score = PlayerPrefs.GetInt("savescore");
			scoreText.text = $"Your best score: {score}";
		}
		catch
        {

        }
		finally
        {
			scoreText.text = $"Your best score: 0";
		}
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

	public void MusicVol()
    {
		if (MusicSlider.interactable == true)
        {
			MusicSlider.interactable = false;
        }
		else
        {
			MusicSlider.interactable = true;
        }
    }

	public void SoundsVol()
	{
		if (SoundSlider.interactable == true)
		{
			SoundSlider.interactable = false;
		}
		else
		{
			SoundSlider.interactable = true;
		}
	}
}

