using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{

    public int number;
    // 1 - hair, 2 - clothes, 3 - shoes, 4 - joke1, 5 - joke2, 6 - joke 3, 7 - stilts, 8 - juggling, 9 - balloon animals

    public void OnButtonPress()
    {
        if (number == 1)
        { Collected.hair = true; }
        else if (number == 2)
        { Collected.clothes = true; }
        else if (number == 3)
        { Collected.shoes = true; }
        else if (number == 4)
        { Collected.joke1 = true; }
        else if (number == 5)
        { Collected.joke2 = true; }
        else if (number == 6)
        { Collected.joke3 = true; }
        else if (number == 7)
        { Collected.stilts = true; }
        else if (number == 8)
        { Collected.juggling = true; }
        else if (number == 9)
        { Collected.balloonAnimals = true; }
    }

}
