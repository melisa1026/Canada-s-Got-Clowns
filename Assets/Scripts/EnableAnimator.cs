using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAnimator : MonoBehaviour
{
    public void enableAnimation()
    {
        GetComponent<Animator>().enabled = true;
    }
}
