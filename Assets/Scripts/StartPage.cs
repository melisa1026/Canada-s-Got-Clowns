using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPage : MonoBehaviour
{

    public GameObject words;
    public GameObject startScreen;
    public GameObject story;

    public void OnButtonPress(string text)
    {
        words.GetComponent<TMPro.TextMeshProUGUI>().text = text;
    }

    public void OnButtonPress()
    {
        StartCoroutine(startPage());
    }

    IEnumerator startPage()
    {
        startScreen.SetActive(false);
        story.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MainScene");
    }
}
