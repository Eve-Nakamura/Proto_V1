using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Brax : MonoBehaviour
{
    public GameObject image1;
    void Start()
    {

    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        Ray ray;
        RaycastHit hit;

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.name == "Brax")
                {
                    image1.GetComponent<UI_Manager>().display();
                }

            }
        }
    }
}
