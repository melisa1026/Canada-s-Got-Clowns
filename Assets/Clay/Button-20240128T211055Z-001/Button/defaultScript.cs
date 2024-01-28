using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaultScript : MonoBehaviour
{
    public GameObject hover;

    // Update is called once per frame
    public void ButtonDefaultHover()
    {
        hover.SetActive(false);
        Debug.Log("hide");
    }

    public void ButtoneDefaultNotHover()
    {
        hover.SetActive(true);
    }
}
