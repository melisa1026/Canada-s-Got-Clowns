using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public GameObject buttonbtwn;

    // Start is called before the first frame update
    void Start()
    {
        buttonbtwn.SetActive(false);
    }

    IEnumerator waiter()
    {
        buttonbtwn.SetActive(true);

        yield return new WaitForSeconds(1);

        buttonbtwn.SetActive(false);
    }

    // Update is called once per frame
    void OnMouseOver()
    {
        StartCoroutine(waiter());
    }

    void OnMouseExit()
    {
        StartCoroutine(waiter());
    }
}
