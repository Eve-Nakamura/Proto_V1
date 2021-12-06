using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bad_Start : MonoBehaviour
{
    Data data;
    private void Awake()
    {
        data = FindObjectOfType<Data>();
        
    }
    void Start()
    {
        data.AddScore(-1);
    }

    
}
