using System.Collections;
using UnityEngine;
using TMPro;

public class TypeWriter : MonoBehaviour
{
    public string fullText;
    private string currentText;
    public float delay = 0.2f;
    


    void Start() //avant m�me que la sc�ne ne d�marre pour pas qu'on voit
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
                GetComponent<TextMeshProUGUI>().text = currentText;
                yield return new WaitForSeconds(delay);
            }
               
        }
    }

}
