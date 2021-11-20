using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{
    public string fullText;
    private string currentText;
    public float delay = 0.2f;
    


    void Start() //avant même que la scène ne démarre pour pas qu'on voit
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i< fullText.Length; i++)
        {
            if (!Input.GetMouseButtonDown(0))
            {
                currentText = fullText.Substring(0, i);
                this.GetComponent<TMPro.TextMeshProUGUI>().text = currentText;
                yield return new WaitForSeconds(delay);
            }
               
        }
    }

}
