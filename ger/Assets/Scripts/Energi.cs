using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Energi : MonoBehaviour
{
    public static int maxenergi =5;
    public static int energi = 5;
    public Text energiCounter;
    System.DateTime RewardedDT = System.DateTime.Now.AddSeconds(5);

    void Start()
    {
        energi = PlayerPrefs.GetInt("energisave");
       
        PlayerPrefs.SetInt("RewardedYear", RewardedDT.Year);
        PlayerPrefs.SetInt("RewardedMonth", RewardedDT.Month);
        PlayerPrefs.SetInt("RewardedDay", RewardedDT.Day);
        PlayerPrefs.SetInt("RewardedHour", RewardedDT.Hour);
        PlayerPrefs.SetInt("RewardedMinute", RewardedDT.Minute);
        PlayerPrefs.SetInt("RewardedSecond", RewardedDT.Second);
    }
    // Update is called once per frame
    void Update()
    {
        

        energiCounter.text = energi+ "/" + maxenergi;
        if (maxenergi != energi)
        {
            if (RewardedDT <= System.DateTime.Now && (System.DateTime.Now - RewardedDT).Minutes == 0)
            {
                energi++;
                RewardedDT = System.DateTime.Now.AddMinutes(1);
            }
            else if (RewardedDT <= System.DateTime.Now && (System.DateTime.Now - RewardedDT).Minutes ==5)
            {
                energi = energi + 2;
                RewardedDT = System.DateTime.Now.AddMinutes(1);
            }
            else if (RewardedDT <= System.DateTime.Now && (System.DateTime.Now - RewardedDT).Minutes == 10)
            {
                energi = energi + 3;
                RewardedDT = System.DateTime.Now.AddMinutes(1);
            }
            else if (RewardedDT <= System.DateTime.Now && (System.DateTime.Now - RewardedDT).Minutes == 15)
            {
                energi = energi + 4;
                RewardedDT = System.DateTime.Now.AddMinutes(1);
            }
            else if (RewardedDT <= System.DateTime.Now && (System.DateTime.Now - RewardedDT).Minutes == 20)
            {
                energi = energi + 5;
                RewardedDT = System.DateTime.Now.AddMinutes(1);
            }

        }
        PlayerPrefs.SetInt("energisave", Energi.energi);
    }
   
}
