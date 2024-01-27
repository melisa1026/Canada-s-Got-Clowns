using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCursor : MonoBehaviour
{
    public GameObject myCursor;
    public Vector3 originalScale;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        originalScale = myCursor.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        myCursor.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x + 0.3f, Camera.main.ScreenToWorldPoint(Input.mousePosition).y - 0.5f, 0);
    }

    public void bigCursor()
    {
        myCursor.transform.localScale = new Vector3(myCursor.transform.localScale.x * 1.5f, myCursor.transform.localScale.y * 1.5f, myCursor.transform.localScale.z);
    }

    public void normalCursor()
    {
        myCursor.transform.localScale = originalScale;
    }

}
