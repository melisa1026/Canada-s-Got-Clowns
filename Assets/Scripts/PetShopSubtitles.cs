using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetShopSubtitles : MonoBehaviour
{
    public GameObject mickeyText;

    public void PlaySubtitles()
    {
        StartCoroutine(subtitles());
    }

    public IEnumerator subtitles()
    {
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "Oh God! The animals";
        yield return new WaitForSeconds(1.75f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "I can't control them";
        yield return new WaitForSeconds(1.25f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "Oh, the judges?";
        yield return new WaitForSeconds(2f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "Uhhhh I heard one of them likes juggling";
        yield return new WaitForSeconds(2f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "Please help me";
        yield return new WaitForSeconds(3f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "";
    }
}
