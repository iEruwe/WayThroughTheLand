using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Platform : MonoBehaviour
{
  
    float speed = 2f;

    private void Start()
    {
       
    }
    void Update()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0f, 0f));
   
    }
}
