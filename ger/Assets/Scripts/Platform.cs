using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Platform : MonoBehaviour
{
    public GameObject block;
    float speed = -0.01f,score = 0;
    int f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

  
    void Update()
    {
        transform.Translate(new Vector3(speed, 0f, 0f));

    }
}
