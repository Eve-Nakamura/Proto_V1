using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
  
    [SerializeField] float tempsEnCours;
    bool pret;
    bool tempsFini;
    TextMeshProUGUI myTimer;
    [SerializeField] GameObject popUpFini;


    private void Awake()
    {
        if (popUpFini != null) {
            popUpFini.SetActive(false); //desactive popup
        }
    }

    private void Start()
    {
        myTimer = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            pret = true; //3, 2, 1...
        }

        if (pret == true && tempsFini == false)
        {
            if (tempsEnCours > 0)
            {
                tempsEnCours -= Time.deltaTime; //timer defile
                myTimer.text = "00:" + tempsEnCours.ToString("f0"); //affichage timer
            }

            else
            {
                myTimer.text = "00:0"; //à 0 ou en dessous on affiche 0
                tempsFini = true; //c termine

            }

            if (tempsFini == true)
            {
                if (popUpFini != null) { 
                popUpFini.SetActive(true); //popup s'affiche
                }
            }
        }
    }

    public void Finish()
    {

    }
}