using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> list;

    // Start is called before the first frame update
    void Start()
    {
        desactiveScript();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void desactiveScript()
    {
        foreach (GameObject item in list)
        {
            if (item.GetComponent<Launch>())
            {
                item.GetComponent<Launch>().enabled = false;
            }
            else if( item.GetComponent<Button>())
            {
                item.GetComponent<Button>().enabled = false;
            }
            else if( item.GetComponent<Show_Codex>())
            {
                item.GetComponent<Show_Codex>().enabled = false;
            }
            else if (item.GetComponent<Show_Brax>())
            {
                item.GetComponent<Show_Brax>().enabled = false;
            }
        }
    }
    public void activeScript()
    {
        foreach (GameObject item in list)
        {
            if (item.GetComponent<Launch>())
            {
                item.GetComponent<Launch>().enabled = true;
            }
            else if( item.GetComponent<Button>())
            {
                item.GetComponent<Button>().enabled = true;
            }
            else if( item.GetComponent<Show_Codex>())
            {
                item.GetComponent<Show_Codex>().enabled = true;
            }
            else if (item.GetComponent<Show_Brax>())
            {
                item.GetComponent<Show_Brax>().enabled = true;
            }
        }

    }
}
