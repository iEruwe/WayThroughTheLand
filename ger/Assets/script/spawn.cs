using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class spawn : MonoBehaviour
{
    public GameObject[] block;
    public float[] positions = { 10f, 12f, 14f, 16f };
    // Start is called before the first frame update
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
                new Vector3(positions[Random.Range( 0,4)],-4,-2),Quaternion.Euler(new Vector3(0,0,0)));
            yield return new WaitForSeconds(1f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
