using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject block;

  



    void Start()
    {
        StartCoroutine(spaw());
        
    }
    IEnumerator spaw()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            float random = Random.Range(5f, 10f);
            GameObject newblock = Instantiate(block, new Vector3(random, -4, 0), Quaternion.identity);
            Destroy(newblock, 15);
              
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
