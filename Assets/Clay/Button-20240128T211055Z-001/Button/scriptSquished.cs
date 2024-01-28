using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptSquished : MonoBehaviour
{
    public GameObject button;

    // Start is called before the first frame update
    public void Start()
    {
        button.GetComponent<Renderer>().enabled = false;
        Debug.Log("Button Squished: hide");
    }

    // Update is called once per frame
    public void SquishedHover()
    {
        Debug.Log("Button Squished: hover start");
        StartCoroutine(waiter());
    }

    public IEnumerator waiter()
    {
        yield return new WaitForSeconds(1);

        button.GetComponent<Renderer>().enabled = true;
        Debug.Log("Button Squished: appears");
    }

    public void SquishedNotHover()
    {
        button.GetComponent<Renderer>().enabled = false;
        Debug.Log("Button Squished: disappears");
    }
}
