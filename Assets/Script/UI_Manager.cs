using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{

    public Vector3 initPosition;
    public Vector3 initScale;
    public bool dialFin;

    bool readyBouton = false;
    bool mini;

    private void Start() //pardon d'avance pour cet horrible code mais des cerveaux ont été perdus dans la bataille
    {
        initScale = gameObject.transform.localScale;
        initPosition = gameObject.transform.position;
        mini = false;
    }
    public void display()
    {
        GameObject[] dialList = GameObject.FindGameObjectsWithTag("Dial");
        int nbrList = dialList.Length;
        int nbrHide = 0;
        foreach (GameObject item in dialList)
        {
            if (item.activeSelf == false)
            {
                nbrHide++;
            }
        }


        if (nbrHide == nbrList)
        {
            readyBouton = true;
            gameObject.SetActive(true);
        }
    }

    public void hide()
    {
        if (gameObject.tag == "Dial")
        {
            GameObject click = gameObject.transform.GetChild(0).gameObject;

            if (click.GetComponent<TypeWriter>().currentText != click.GetComponent<TypeWriter>().fullText)
            {
                click.GetComponent<TypeWriter>().stopCoroutine();
                click.GetComponent<TypeWriter>().displayText();
            }

            else if (click.GetComponent<TypeWriter>().currentText == click.GetComponent<TypeWriter>().fullText)
            {

                gameObject.SetActive(false);
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    [System.Obsolete]
    public void interrupteur()
    {
        if (gameObject.active == true)
        {
            gameObject.SetActive(false);
        }

        else
        {
            gameObject.SetActive(true);
        }
    }
    public void minimizePerso()
    {
        /*print("minimize perso");*/
        if (!mini)
        {
            mini = true;
            gameObject.transform.localPosition = new Vector3(740, -150, initPosition.z);
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x / 3, gameObject.transform.localScale.y / 3, gameObject.transform.localScale.z);
        }
    } 
    public void rescalePerso()
    {
        mini = false;
        gameObject.transform.localScale = new Vector3(1, 1, 0f);
        gameObject.transform.position = new Vector3(initPosition.x, initPosition.y, gameObject.transform.position.z);

    }
}