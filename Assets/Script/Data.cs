using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    [SerializeField] int score = 0; //on stocke la valeur du score
    [SerializeField] int maxScore = 16;
    [SerializeField] int minScore = 0;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int _v = 2)
    {
        score += _v;
        if (score > maxScore) //set les limites
        {
            score = maxScore;
        }

        else if (score < minScore)
        {
            score = minScore;
        }
    }

    public int GetScore()
    {
        return score;
    }
}
