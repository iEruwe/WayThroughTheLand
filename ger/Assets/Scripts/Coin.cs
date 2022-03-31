using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public GameObject coin;
    public static int coin1=0;
   
    public Text coinCounter;
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
        coin1 = PlayerPrefs.GetInt("savecoin", coin1);
        Time.timeScale = 1;
        StartCoroutine(Spawner());
       
    }
    private void Update()
    {
        coinCounter.text =""+coin1;
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            float random1 = Random.Range(6f, 8f);
            GameObject newcoin = Instantiate(coin, new Vector3(5 + random1, -1.96f, 0), Quaternion.identity);
            Destroy(newcoin, 15);
            yield return new WaitForSeconds(4f);

        }
    }

}
