using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaultScript : MonoBehaviour
{
    public GameObject hover;

    // Update is called once per frame
    public void DefaultHover()
    {
        hover.GetComponent<Renderer>().enabled = false;
        Debug.Log("hide");
    }

    public void DefaultNotHover()
    {
        hover.GetComponent<Renderer>().enabled = true;
        Debug.Log("Reappears");
    }
}
