using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject character;
    public GameObject CM1, CM2;
    
    public void showPerson()
    {
        character.SetActive(true);

    }
    public void walkToEnd()
    {
        CM1.SetActive(false);
        CM2.SetActive(true);
    }
    public void endToWait()
    {
        CM2.SetActive(false);
        CM1.SetActive(true);
    }
}
