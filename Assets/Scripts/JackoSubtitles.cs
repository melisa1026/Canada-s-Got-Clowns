using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackoSubtitles : MonoBehaviour
{
    public GameObject mickeyText;

    public void PlaySubtitles()
    {
        StartCoroutine(subtitles());
    }

    public IEnumerator subtitles()
    {
        GetComponent<Animator>().Play("Jackimayion");
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "What do you call a clown that has lost";
        yield return new WaitForSeconds(2.3f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "the competition 3 years in a row?";
        yield return new WaitForSeconds(3.5f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "Jacko, that's who";
        yield return new WaitForSeconds(2.7f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "ME";
        yield return new WaitForSeconds(1f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "*crying*";
        yield return new WaitForSeconds(2.5f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "This is so unfair";
        yield return new WaitForSeconds(2f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "The judges only like jokes about themselves";
        yield return new WaitForSeconds(2f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "and where they come from";
        yield return new WaitForSeconds(1.5f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "I guess joke about Hong Kong or whatever";
        yield return new WaitForSeconds(2f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "";

    }
}

