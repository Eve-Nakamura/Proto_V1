using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_Verrou : MonoBehaviour
{
    public GameObject image1;
    public GameObject journal;
    public GameObject options;
    public GameObject Fond;
    public GameObject sons;
    void Start()
    {

    }

    // c'est pareil que les minimes mais pr le chateau de brax
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
                if (hit.collider.name == "Matabiau" || hit.collider.name == "mat")
                {

                    image1.GetComponent<UI_Manager>().display();
                    Fond.GetComponent<UI_Manager>().display();
                    journal.GetComponent<UI_Manager>().hide();
                    options.GetComponent<UI_Manager>().hide();
                    sons.GetComponent<AudioSource>().Play();

                }

            }
        }
    }
}

