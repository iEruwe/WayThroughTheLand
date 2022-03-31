using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    float speed = 2f;
    private void Start()
    {
        Time.timeScale = 1;
    }
    private void Update()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Coin.coin1++;
            Destroy(gameObject);
            PlayerPrefs.SetInt("savecoin",Coin.coin1);
        }
    }
}
