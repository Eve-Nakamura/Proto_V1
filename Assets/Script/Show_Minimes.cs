using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Minimes : MonoBehaviour
{
    public GameObject image1;
    public GameObject journal;
    public GameObject options;
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
                if (hit.collider.name == "Minimes")
                {

                    image1.GetComponent<UI_Manager>().display();
                    journal.GetComponent<UI_Manager>().hide();
                    options.GetComponent<UI_Manager>().hide();

                }

            }
        }
    }
}
