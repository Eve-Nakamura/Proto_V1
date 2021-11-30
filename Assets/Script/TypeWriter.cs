using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypeWriter : MonoBehaviour
{
    public string fullText;
    public string currentText;
    public float delay = 0.2f;
    public bool clickReady = false;
    public bool finishText = false;

    [SerializeField] UI_Manager MainExit;
    [SerializeField] UI_Manager Codex;
    [SerializeField] UI_Manager Carte;
    [SerializeField] UI_Manager Journal;
    [SerializeField] UI_Manager Option;
    [SerializeField] UI_Manager Perso;
    [SerializeField] UI_Manager Fond;
    [SerializeField] UI_Manager MissClick;

    void Start() 
    {
        StartCoroutine(ShowText());
    }

    public void stopCoroutine()
    {
        clickReady = true;
        StopCoroutine(ShowText());
    }
    IEnumerator ShowText()
    {
        for (int i = 0; i< fullText.Length; i++)
        {
            if (!Input.GetMouseButtonDown(0) && !clickReady)
            {
                currentText = fullText.Substring(0, i);
                GetComponent<TextMeshProUGUI>().text = currentText;
                yield return new WaitForSeconds(delay);
            }
        }
        if (fullText == currentText)
        {
            finishText = true;
            // Ajout toutes les fonctions
            if (transform.parent.GetComponent<UI_Manager>().dialFin)
            {
                print("ok");
                transform.parent.GetComponent<Button>().onClick.AddListener(MainExit.display);
                transform.parent.GetComponent<Button>().onClick.AddListener(Codex.display);
                transform.parent.GetComponent<Button>().onClick.AddListener(Carte.display);
                transform.parent.GetComponent<Button>().onClick.AddListener(Journal.display);
                transform.parent.GetComponent<Button>().onClick.AddListener(Option.display);
                transform.parent.GetComponent<Button>().onClick.AddListener(Perso.minimizePerso);
                transform.parent.GetComponent<Button>().onClick.AddListener(Fond.hide);
                transform.parent.GetComponent<Button>().onClick.AddListener(MissClick.hide);
            }
        }
    }

    public void displayText()
    {
        currentText = fullText;
        GetComponent<TextMeshProUGUI>().text = currentText;
        // Ajout toutes les fonctions
        if (transform.parent.GetComponent<UI_Manager>().dialFin)
        {
            print("ok2");
            transform.parent.GetComponent<Button>().onClick.AddListener(MainExit.display);
            transform.parent.GetComponent<Button>().onClick.AddListener(Codex.display);
            transform.parent.GetComponent<Button>().onClick.AddListener(Carte.display);
            transform.parent.GetComponent<Button>().onClick.AddListener(Journal.display);
            transform.parent.GetComponent<Button>().onClick.AddListener(Option.display);
            transform.parent.GetComponent<Button>().onClick.AddListener(Perso.minimizePerso);
            transform.parent.GetComponent<Button>().onClick.AddListener(Fond.hide);
            transform.parent.GetComponent<Button>().onClick.AddListener(MissClick.hide);
        }
    }

}
