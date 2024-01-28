using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLocations : MonoBehaviour
{
    // define all the locations that
    Vector3 outside = new Vector3(0, 0, -10), petShop = new Vector3(25, 0, -10), stiltsStore = new Vector3(50, 0, -10),
        amusementPark = new Vector3(0, -15, -10), stage = new Vector3(25, -15, -10), judges = new Vector3(75, -15, -10),
        poster = new Vector3(0, -30, -10), matildaIntro = new Vector3(25,  -30, -10);

    public void Switch(string loc)
    {
        Transform cam = Camera.main.transform;

        switch (loc)
        {
            case "outside":
                cam.position = outside;
                break;
            case "pet shop":
                cam.position = petShop;
                break;
            case "stilts store":
                cam.position = stiltsStore;
                break;
            case "amusement park":
                cam.position = amusementPark;
                break;
            case "matilda intro":
                cam.position = matildaIntro;
                break;
            case "poster":
                cam.position = poster;
                break;
        }
    }

    public void ChangeToMainOnTime(float time)
    {
        StartCoroutine(ChangeToMainOnTimeIE(time));
    }

    public IEnumerator ChangeToMainOnTimeIE(float time)
    {
        yield return new WaitForSeconds(time);
        Switch("outside");
    }
}
