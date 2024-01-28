using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public GameObject buttonbtwn;

    // Start is called before the first frame update
    void Start()
    {
        buttonbtwn.GetComponent<Renderer>().enabled = false;
        Debug.Log("Button Middle: hide");
    }

    public IEnumerator waiter()
    {
        buttonbtwn.GetComponent<Renderer>().enabled = true;
        Debug.Log("Button Middle: appears");

        yield return new WaitForSeconds(1);

        buttonbtwn.GetComponent<Renderer>().enabled = false;
        Debug.Log("Button Middle: disappears");
    }

    // Update is called once per frame
    public void MiddleHover()
    {
        Debug.Log("Button Middle: hovers");
        StartCoroutine(waiter());
    }

    public void NotMiddleHover()
    {
        Debug.Log("Button Middle: not hovers");
        StartCoroutine(waiter());
    }
}
