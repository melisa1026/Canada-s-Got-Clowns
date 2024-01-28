using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpObject : MonoBehaviour
{

    public int number;
    // 1 - hair, 2 - clothes, 3 - shoes, 4 - joke1, 5 - joke2, 6 - joke 3, 7 - stilts, 8 - juggling, 9 - balloon animals
    
    private int used;
    private static int score = 0;
    public GameObject displayScore;

    void Start()
    {
        used = 0;
    }

    public void OnButtonPress()
    {
        if (number == 1 && used == 0)
        {
            Collected.hair = true;
            score++;
            used = 1;
        }
        else if (number == 2 && used == 0)
        { 
            Collected.clothes = true;
            score++;
            used = 1;
        }
        else if (number == 3 && used == 0)
        { 
            Collected.shoes = true;
            score++;
            used = 1;
        }
        else if (number == 4 && used == 0)
        { 
            Collected.joke1 = true;
            score++;
            used = 1;
        }
        else if (number == 5 && used == 0)
        { Collected.joke2 = true;
            score++;
            used = 1;

        }
        else if (number == 6 && used == 0)
        { 
            Collected.joke3 = true;
            score++;
            used = 1;
        }
        else if (number == 7 && used == 0)
        { 
            Collected.stilts = true;
            score++;
            used = 1;
        }
        else if (number == 8 && used == 0)
        { 
            Collected.juggling = true;
            score++;
            used = 1;
        }
        else if (number == 9 && used == 0)
        { 
            Collected.balloonAnimals = true;
            score++;
            used = 1;
        }
    }

    void Update()
    {
        if(displayScore != null)
            displayScore.GetComponent<TMPro.TextMeshProUGUI>().text = score.ToString() + "/9";
    }

}
