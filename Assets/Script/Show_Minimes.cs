using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Minimes : MonoBehaviour
{
    public GameObject image1;
    public GameObject journal;
    public GameObject options;
    public GameObject sons;
    public GameObject block;

    void Start()
    {

    }

    [System.Obsolete]
    void Update()
    {
        Ray ray; //on cree le raycast
        RaycastHit hit;

        ray = Camera.main.ScreenPointToRay(Input.mousePosition); //quand on touche l'ecran 
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.name != "BlockRaycast" && hit.collider.name == "min") //on touche pas ? tout non plus
                {
                    block.SetActive(true);
                    image1.GetComponent<UI_Manager>().display(); //permet l'affichage d'ui avec le raycast
                    journal.GetComponent<UI_Manager>().hide();
                    options.GetComponent<UI_Manager>().hide();
                    sons.GetComponent<AudioSource>().Play();

                }

            }
        }
    }
}
