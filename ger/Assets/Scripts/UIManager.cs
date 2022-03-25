using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
	public void Reload()  
	{
		// SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
