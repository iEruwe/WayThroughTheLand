using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject block;

    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(Spawner());
        
    }
    IEnumerator Spawner()
    {
        while (true)
        {
            float random = Random.Range(6f, 8f);
            GameObject newblock = Instantiate(block, new Vector3(5 + random, -4.1f, 0), Quaternion.identity);
            Destroy(newblock, 15);
            yield return new WaitForSeconds(2f);
        }
    }
}
