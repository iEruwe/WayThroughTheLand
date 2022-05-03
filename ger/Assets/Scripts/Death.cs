using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Death : MonoBehaviour
{

    public GameObject RestartB;
    public GameObject MenuB;
    System.DateTime RewardedDT = System.DateTime.Now.AddSeconds(5);
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
            if (Energi.energi == 0)
            {
                RestartB.gameObject.SetActive(false);
            }
            else
            {
                RestartB.gameObject.SetActive(true);
            }
            MenuB.gameObject.SetActive(true);
          
        }
    }
    private void Update()
    {
        PlayerPrefs.SetInt("RewardedYear", RewardedDT.Year);
        PlayerPrefs.SetInt("RewardedMonth", RewardedDT.Month);
        PlayerPrefs.SetInt("RewardedDay", RewardedDT.Day);
        PlayerPrefs.SetInt("RewardedHour", RewardedDT.Hour);
        PlayerPrefs.SetInt("RewardedMinute", RewardedDT.Minute);
        PlayerPrefs.SetInt("RewardedSecond", RewardedDT.Second);

        if (Energi.maxenergi != Energi.energi)
        {
            if (RewardedDT <= System.DateTime.Now && (System.DateTime.Now - RewardedDT).Seconds == 0)
            {
                Energi.energi++;
                RewardedDT = System.DateTime.Now.AddMinutes(1);
            }
            else if (RewardedDT <= System.DateTime.Now && (System.DateTime.Now - RewardedDT).Seconds == 5)
            {
                Energi.energi=Energi.energi+2;
                RewardedDT = System.DateTime.Now.AddMinutes(1);
            }
            else if (RewardedDT <= System.DateTime.Now && (System.DateTime.Now - RewardedDT).Seconds == 10)
            {
                Energi.energi = Energi.energi + 3;
                RewardedDT = System.DateTime.Now.AddMinutes(1);
            }
            else if (RewardedDT <= System.DateTime.Now && (System.DateTime.Now - RewardedDT).Seconds == 15)
            {
                Energi.energi = Energi.energi + 4;
                RewardedDT = System.DateTime.Now.AddMinutes(1);
            }
            else if (RewardedDT <= System.DateTime.Now && (System.DateTime.Now - RewardedDT).Seconds == 20)
            {
                Energi.energi = Energi.energi + 5;
                RewardedDT = System.DateTime.Now.AddMinutes(1);
            }


        }
        PlayerPrefs.SetInt("energisave", Energi.energi);
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
