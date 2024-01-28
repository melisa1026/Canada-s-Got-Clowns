using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearOnClick : MonoBehaviour
{
    public void OnButtonPress()
    {
        gameObject.SetActive(false);
    }
}
