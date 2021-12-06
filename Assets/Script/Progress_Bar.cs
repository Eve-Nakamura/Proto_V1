using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress_Bar : MonoBehaviour
{
    public Slider slider; //on appelle le slider
    public float targetProgress; //la valeur du score mise � jour
    public float speedFill = 0.5f; //la vitesse de d�placement du curseur
    public Data data;


    //on teste

    private void Awake()
    {
        data = FindObjectOfType<Data>();
        slider = gameObject.GetComponent<Slider>();
    }
    void Start()
    {
        UpdateScore();
    }

    // on v�rif le score � chaque frame
    void Update()
    {

        
        /*if (slider.value < targetProgress)
        {
            
            slider.value++; //on rajoute 1
            slider.value += speedFill * Time.deltaTime;
        }

        else if (slider.value > targetProgress)
        {
            
            slider.value--; //on enl�ve 1
            slider.value -= speedFill * Time.deltaTime;
        }*/
    }

    public void UpdateScore()
    {
        if (data)
        {
            slider.value = data.GetScore();
        }
    }

    /* public void Progression(int newScore)
     {
         if (targetProgress < 16 && targetProgress > 0)
         {
             targetProgress = slider.value + newScore; //on update le score selon les pts de r�putation qu'on gagne ou qu'on perd
         }

     }*/

    /*    public void Regression(float newScore)
        {
            targetProgress = slider.value - newScore;
        }*/
}
