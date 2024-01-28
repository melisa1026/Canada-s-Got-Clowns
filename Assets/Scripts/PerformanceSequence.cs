using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class PerformanceSequence : MonoBehaviour
{
    public GameObject text;
    public GameObject textbox;
    public GameObject clown;
    public GameObject jokeBox, talentBox;
    public GameObject jokeText, jokeTextBg;
    public int jokePoints = 0, talentPoints = 0;
    public GameObject confetti;
    public GameObject placard1, placard2, placard3, score1, score2, score3;
    public AudioSource audio;
    public AudioClip joke1, joke2, joke3, chosenJoke;

    void Start()
    {
        StartCoroutine(Perform());
    }

    IEnumerator Perform()
    {
        // performance starts
        yield return new WaitForSeconds(2.5f);

        // outfit
        text.GetComponent<TMPro.TextMeshProUGUI>().text = "First, show off your outfit...";
        yield return new WaitForSeconds(3);
        textbox.SetActive(false);
        Vector3 newClownPos = new Vector3(clown.transform.position.x, clown.transform.position.y - 0.5f, clown.transform.position.z);
        Vector3 newClownScale = new Vector3(clown.transform.localScale.x*1.25f, clown.transform.localScale.y*1.25f, 1);
        clown.transform.DOScale(newClownScale, 1);
        yield return new WaitForSeconds(2);

        // joke
        textbox.SetActive(true);
        text.GetComponent<TMPro.TextMeshProUGUI>().text = "Next, tell a joke";
        yield return new WaitForSeconds(2);
        textbox.SetActive(false);

        jokeBox.SetActive(true);
    }

    public void TellJoke(int jokeNumber)
    {
        StartCoroutine(TellJokeIE(jokeNumber));
    }

    public IEnumerator TellJokeIE(int jokeNumber)
    {
        jokeBox.SetActive(false);
        string joke, punchline;

        // choose joke
        if(jokeNumber == 1)
        {
            joke = "What does a baby computer call his father?";
            punchline = "DATA";
            jokePoints = 8;
            chosenJoke = joke1;
        }
        else if(jokeNumber == 2)
        {
            joke = "How do you make a tissue dance?";
            punchline = "You put a little boogie in it.";
            jokePoints = 5;
            chosenJoke = joke2;
        }
        else
        {
            joke = "What's a clown's favourite city?";
            punchline = "Honk Konk";
            jokePoints = 10;
            chosenJoke = joke3;
        }

        // tell the joke
        jokeText.SetActive(true);
        jokeTextBg.SetActive(true);
        audio.clip = chosenJoke;
        audio.Play();
        jokeText.GetComponent<TMPro.TextMeshProUGUI>().text = joke;
        yield return new WaitForSeconds(3f);
        jokeText.GetComponent<TMPro.TextMeshProUGUI>().text = punchline;
        yield return new WaitForSeconds(3f);
        jokeText.SetActive(false);
        jokeTextBg.SetActive(false);


        // time for talent
        textbox.SetActive(true);
        text.GetComponent<TMPro.TextMeshProUGUI>().text = "Now, choose a talent";
        yield return new WaitForSeconds(2);
        textbox.SetActive(false);
        jokeBox.SetActive(false);
        talentBox.SetActive(true);
    }

    public void ChooseTalent(int talent)
    {
        StartCoroutine(ChooseTalentIE(talent));
    }

    public IEnumerator ChooseTalentIE(int talent)
    {
        talentBox.SetActive(false);
        
        // choose talent
        // juggling
        if(talent == 1)
        {
            clown.GetComponent<Animator>().Play("juggle");
            talentPoints = 10;
        }
        // stilts
        else if(talent == 2)
        {
            clown.GetComponent<Animator>().Play("stilts");
            talentPoints = 2;
        }
        // balloon
        else
        {
            clown.GetComponent<Animator>().Play("balloon");
            talentPoints = 7;
        }

        clown.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(2);
        confetti.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(2);

        // go to judges
        Camera.main.transform.position = new Vector3(25, 0, Camera.main.transform.position.z);
        yield return new WaitForSeconds(0.5f);
        placard1.SetActive(true);
        score1.SetActive(true);
        score1.GetComponent<TMPro.TextMeshProUGUI>().text = jokePoints.ToString();
        yield return new WaitForSeconds(1);
        placard2.SetActive(true);
        score2.SetActive(true);
        score2.GetComponent<TMPro.TextMeshProUGUI>().text = "10";
        yield return new WaitForSeconds(1);
        placard3.SetActive(true);
        score3.SetActive(true);
        score3.GetComponent<TMPro.TextMeshProUGUI>().text = talentPoints.ToString();

        yield return new WaitForSeconds(2);
        if(talentPoints != 10 || jokePoints != 10)
        {
            SceneManager.LoadScene("Lose");
        }
        else
        {
            SceneManager.LoadScene("Reveal");
        }

    }
}
