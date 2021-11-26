using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
  
    [SerializeField] [Range(1, 60)] float tempsEnCours;
    [SerializeField] bool tempsRech;
    [SerializeField] bool tempsPret;
    [SerializeField] Timer timerRech;
    bool pret;
    bool tempsFini;
    TextMeshProUGUI myTimer;
    [SerializeField] GameObject popUpFini;
    [SerializeField] GameObject fondfin;


    private void Awake()
    {
        if (popUpFini != null) {
            popUpFini.SetActive(false); //desactive popup
        }
    }

    private void Start()
    {
        if (tempsPret == true)
        {
            pret = true;
        }
        myTimer = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        

        if (pret == true && tempsFini == false)
        {
            if (tempsEnCours > 0)
            {
                tempsEnCours -= Time.deltaTime; //timer defile
                if (tempsRech == true) {
                    myTimer.text = "00:" + tempsEnCours.ToString("f0"); //affichage timer
                }

                else
                {
                    myTimer.text =tempsEnCours.ToString("f0"); //affichage timer
                }


            }

            else
            {
                if (tempsRech == true)
                {
                    myTimer.text = "00:0"; //à 0 ou en dessous on affiche 0
                }

                else
                {
                    myTimer.text = "0"; //à 0 ou en dessous on affiche 0
                }

                Finish();

            }

        }
    }

    public void Finish()
    {
        if (tempsPret == true)
        {
            timerRech.pret = true;
            transform.parent.gameObject.SetActive(false);
        }


        tempsFini = true; //c termine
        if (popUpFini != null)
        {
            popUpFini.SetActive(true); //popup s'affiche
            fondfin.SetActive(true); //popup s'affiche
        }
    }
}