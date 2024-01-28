using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptSquished : MonoBehaviour
{
    public GameObject button;

    // Start is called before the first frame update
    public void Start()
    {
        button.SetActive(false); 
    }

    // Update is called once per frame
    public void ButtonSquishedHover()
    {
        StartCoroutine(waiter());
    }

    public IEnumerator waiter()
    {
        yield return new WaitForSeconds(1);

        button.SetActive(true);
    }

    public void ButtoneSquishedNotHover()
    {
        button.SetActive(false);
    }
}
