using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subtitles : MonoBehaviour
{

    public GameObject subtitles;

    public void OnButtonPress(string text)
    {
        subtitles.GetComponent<TMPro.TextMeshProUGUI>().text = text;
    }

    public void OnButtonPress()
    {
        StartCoroutine(subtitlesOff());
    }

    IEnumerator subtitlesOff()
    {
        yield return new WaitForSeconds(5f);
        subtitles.GetComponent<TMPro.TextMeshProUGUI>().text = "";
    }
}
