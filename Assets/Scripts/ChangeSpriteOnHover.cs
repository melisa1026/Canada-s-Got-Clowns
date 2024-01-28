using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteOnHover : MonoBehaviour
{
    public void hoverObject(Sprite sprite)
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }
    
    public void unhoverObject(Sprite sprite)
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
