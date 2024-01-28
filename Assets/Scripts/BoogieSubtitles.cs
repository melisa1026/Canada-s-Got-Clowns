using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoogieSubtitles : MonoBehaviour
{
    public GameObject mickeyText;

    public void PlaySubtitles()
    {
        StartCoroutine(subtitles());
    }

    public IEnumerator subtitles()
    {
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "How do you make a tissue dance?";
        yield return new WaitForSeconds(1.7f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "You put a little boogie in it";
        yield return new WaitForSeconds(2.3f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "";
    }
}
