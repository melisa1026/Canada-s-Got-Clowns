using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCursor : MonoBehaviour
{
    public GameObject myCursor;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        myCursor.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x + 0.3f, Camera.main.ScreenToWorldPoint(Input.mousePosition).y - 0.5f, 0);
    }
}
