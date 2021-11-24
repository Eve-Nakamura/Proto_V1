using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{

    public Vector3 initPosition;
    public Vector3 initScale;

    private void Start()
    {
        initPosition = gameObject.transform.position;
        initScale = gameObject.transform.localScale;
    }
    public void display()
    {
        gameObject.SetActive(true);
    }

    public void hide()
    {
        gameObject.SetActive(false);
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
        gameObject.transform.localPosition = new Vector3(740, -150, initPosition.z);
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x/3, gameObject.transform.localScale.y/3, gameObject.transform.localScale.z);
       
    } 
    public void rescalePerso()
    {
        gameObject.transform.localScale = new Vector3(initScale.x, initScale.y, gameObject.transform.localScale.z);
        gameObject.transform.position = new Vector3(initPosition.x, initPosition.y, gameObject.transform.position.z);
    }

}