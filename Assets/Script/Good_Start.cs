using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Good_Start : MonoBehaviour
{
    Data data;
    private void Awake()
    {
        data = FindObjectOfType<Data>();
        
    }
    void Start()
    {
        data.AddScore();
    }

    
}
