using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickRollerCoaster : MonoBehaviour
{
    public GameObject wig;
    public GameObject button;
    public Sprite defaultSprite;
    
    public void ClickCoaster()
    {
        GetComponent<Animator>().enabled = true;
        GetComponent<Animator>().Play("rollerCoasterPass");
        button.SetActive(false);
    }

    public void addWig()
    {
        wig.SetActive(true);
        GetComponent<Animator>().enabled = false;
        GetComponent<SpriteRenderer>().sprite = defaultSprite;
    }
}
