using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class PlatformSpawn : MonoBehaviour
{
    public int score = 0;
    private float frame;
    private GameObject block;
    public GameObject mountBlock;
    public GameObject forestBlock;
    private int blockNum = 1;

    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(Spawner());
    }
    private void Update()
    {
        if (Time.timeScale > 0)
        {
            frame++;
        }

        if ((frame % 75) == 0)
        {
            score++;
        }

        if (score == 300)
        {
            score = 0;
            blockNum++;
        }
    }
    IEnumerator Spawner()
    {
        while (true)
        {
            if (blockNum > 5)
            {
                blockNum = 1;
            }

            switch (blockNum)
            {
                case 1:
                    block = mountBlock;
                    break;
                case 2:
                    block = forestBlock;
                    break;
                case 3:
                    block = mountBlock;
                    break;
                case 4:
                    block = forestBlock;
                    break;
                case 5:
                    block = mountBlock;
                    break;
            }

            float random1 = Random.Range(6f, 8f);
            GameObject newblock1 = Instantiate(block, new Vector3(5 + random1, -4.1f, 0), Quaternion.identity);
            Destroy(newblock1, 15);
          
            yield return new WaitForSeconds(2f);
        }
    }
}
