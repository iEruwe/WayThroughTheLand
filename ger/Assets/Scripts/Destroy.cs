using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject platform;

    public void Start()
    {
        Destroy(platform,14);
    }
}
