using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recherche_1 : MonoBehaviour
{
    float temps = 20f;
    float tempsEnCours;
    bool pret;
    bool tempsFini;
    bool chapeauTrouve;
    bool manteauTrouve;
    
    void Start()
    {
        tempsEnCours = temps;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            pret = true;
        }

        if (pret == true)
        {
            tempsEnCours -= Time.deltaTime;
        }
    }
}
