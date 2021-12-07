using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{

    public GameObject sons;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "fred")
        {
            StartCoroutine(playAnimation1());
        }

        else if (gameObject.tag == "mat")
        {
            StartCoroutine(playAnimation2());
        }

        else if (gameObject.tag == "min")
        {
            StartCoroutine(playAnimation3());
        }

        
        
    }

    public IEnumerator playAnimation1()
    {
        yield return new WaitForSeconds(0.3f);
        GetComponent<Animation>().Play("fredfall");
        sons.GetComponent<AudioSource>().Play();

    }

    public IEnumerator playAnimation2()
    {
        yield return new WaitForSeconds(0.8f);
        GetComponent<Animation>().Play("matabiaufall");
        sons.GetComponent<AudioSource>().Play();
    }

    public IEnumerator playAnimation3()
    {
        yield return new WaitForSeconds(0.5f);
        GetComponent<Animation>().Play("minimesfall");
        sons.GetComponent<AudioSource>().Play();
    }

}
