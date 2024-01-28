using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVoice : MonoBehaviour
{
    public GameObject mickeyText;

    public void PlayClip(AudioClip audioClip)
    {
        GetComponent<AudioSource>().clip = audioClip;
        GetComponent<AudioSource>().Play();
    }

    public void PlayMickey()
    {
        StartCoroutine(MickeyIE());
    }

    public IEnumerator MickeyIE()
    {
        yield return new WaitForSeconds(2.5f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "Hmm.. I’ll need to prepare some clothes, talents and some funny jokes if I wanna win";
        yield return new WaitForSeconds(7);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text =  "Oh! The girl.. She looks so hot!";
        yield return new WaitForSeconds(4f);
        mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text =  "Can’t wait to meet her!";
    }
}
