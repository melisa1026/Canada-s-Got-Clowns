using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerformanceTime : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Collected.hair == true && Collected.clothes == true && Collected.shoes == true && Collected.joke1 == true
            && Collected.joke2 == true && Collected.joke3 == true && Collected.stilts == true
            && Collected.juggling == true && Collected.balloonAnimals == true)
            SceneManager.LoadScene("Performance");
    }
}
