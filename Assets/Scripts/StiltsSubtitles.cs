
        using System.Collections;
        using System.Collections.Generic;
        using UnityEngine;

public class StiltsSubtitles : MonoBehaviour
    {
        public GameObject mickeyText;
        public GameObject StiltsBGD;

        public Sprite all;
        public Sprite none;
        public Sprite clothes;
        public Sprite stilts;

        void Update()
        {
            if (Collected.clothes == true && Collected.stilts == true)
            {
            StiltsBGD.GetComponent<SpriteRenderer>().sprite = none;
            }
            else if (Collected.clothes == true && Collected.stilts == false)
            {
            StiltsBGD.GetComponent<SpriteRenderer>().sprite = stilts;
            }
            else if (Collected.clothes == false && Collected.stilts == true)
            {
            StiltsBGD.GetComponent<SpriteRenderer>().sprite = clothes;
            }
    }

        public void PlaySubtitles()
        {
            StartCoroutine(subtitles());
        }

        public IEnumerator subtitles()
        {
            mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "Hey kid,wanna buy some stilts?";
            yield return new WaitForSeconds(3.7f);
            mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "Wait! Those are my clothes!";
            yield return new WaitForSeconds(2.3f);
            mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "Come back, scoundrel!";
            yield return new WaitForSeconds(2f);
            mickeyText.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        }
    }
