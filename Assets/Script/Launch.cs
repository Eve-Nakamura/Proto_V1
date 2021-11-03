using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Launch : MonoBehaviour
{

    public string sceneName;
    public void LaunchScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
