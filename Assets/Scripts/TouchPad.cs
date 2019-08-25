using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPad : MonoBehaviour
{

    public int site = 0;

    void Start()
    {
        
    }


    void Update()
    {
        Touches();
    }

    public void Touches()
    {
        if (Input.touchCount > 0)
        {
            if (gameObject.tag == "Left")
            {
                site = 1;
            }
            else if (gameObject.tag == "Right")
            {
                site = 2;
            }
        }
    }
}
