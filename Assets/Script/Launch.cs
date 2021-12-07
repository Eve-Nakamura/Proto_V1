using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Launch : MonoBehaviour
{
    /*public GameObject score;*/
    public string sceneName;
    Data data;

    public void LaunchScene()

    {
        /*DontDestroyOnLoad(score);*/
        SceneManager.LoadScene(sceneName);
    }


}
