using UnityEngine;
using UnityEngine.UI;

public class Recherche_1 : MonoBehaviour

{
    bool manteauTrouve;
    bool chapeauTrouve;
    [SerializeField] GameObject chapeau;
    [SerializeField] GameObject manteau;
    [SerializeField] Image UIchapeau;
    [SerializeField] Image UImanteau;
    [SerializeField] Timer myTimer;

    public void ClickManteau()
    {
        manteauTrouve = true;
        manteau.SetActive(false);
        UImanteau.color = new Color32(0xFF, 0xD7, 0x00, 0xFF);
        /*UImanteau.color = Color.yellow;*/
        Verif();
    }

    public void ClickChapeau()
    {
        chapeauTrouve = true;
        chapeau.SetActive(false);
        UIchapeau.color = new Color32(0xFF, 0xD7, 0x00, 0xFF);
       /* UIchapeau.color = Color.yellow;*/
        Verif();
    }

    public void Verif()
    {
        if (chapeauTrouve == true && manteauTrouve == true)
        {
            myTimer.Finish();
        }
    }
}


