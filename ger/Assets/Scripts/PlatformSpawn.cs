using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject[] block;

    public float[] positions1 = { 10f, 12f };



    void Start()
    {
        StartCoroutine(spaw());
        
    }
    IEnumerator spaw()
    {
        while (true)
        {
            Instantiate(
                block[Random.Range(0, block.Length)],
                new Vector3(positions1[Random.Range( 0,2)],-4,-2),Quaternion.Euler(new Vector3(0,0,0)));
                yield return new WaitForSeconds(1f);//тут тоже
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
