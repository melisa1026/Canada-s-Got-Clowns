using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChange : MonoBehaviour
{

    public GameObject clown;

    public Sprite nothing;
    public Sprite hair;
    public Sprite clothes;
    public Sprite hairAndClothes;


    // Update is called once per frame
    void Update()
    {
        if (Collected.hair == true && Collected.clothes == false)
        {
            clown.GetComponent<SpriteRenderer>().sprite = hair; 
        }
        else if (Collected.hair == true && Collected.clothes == true)
        {
            clown.GetComponent<SpriteRenderer>().sprite = hairAndClothes;
        }
        else if (Collected.hair == false && Collected.clothes == true)
        {
            clown.GetComponent<SpriteRenderer>().sprite = clothes;
        }
        else if (Collected.hair == false && Collected.clothes == false)
        {
            clown.GetComponent<SpriteRenderer>().sprite = nothing;
        }
    }
}
