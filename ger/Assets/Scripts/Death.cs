using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Death : MonoBehaviour
{

    public GameObject RestartB;
    public GameObject MenuB;

    private void Start()
    {
        Time.timeScale = 1;
     
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Energi.energi--;
            Debug.Log("Player dead");
            Time.timeScale = 0;
            RestartB.gameObject.SetActive(true);
            MenuB.gameObject.SetActive(true);
            PlayerPrefs.SetInt("energisave", Energi.energi);
        }
    }
  

    public void LoadLevel(string level)
    {
        SceneManager.LoadSceneAsync(level);
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
