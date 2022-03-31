using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Energi : MonoBehaviour
{
    static int maxenergi =5;
   public static int energi = 5;
    public Text energiCounter;

    void Start()
    {
        energi = PlayerPrefs.GetInt("energisave", energi);
    }

    // Update is called once per frame
    void Update()
    {
        energiCounter.text = energi+ "/" + maxenergi;
        if (energi == 0)
        {
            energi = 5;
        }
    }
}
