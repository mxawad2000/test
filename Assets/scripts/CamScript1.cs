using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript1 : MonoBehaviour
{
    Vector3 currentPos;
    Vector3 p;
    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.Find("MyStructure").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //rotate the camera around the mystructure with different axis
        if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            //transform.Rotate(5.0f, 0.0f, 0.0f, Space.Self);
            transform.RotateAround(p, transform.forward, 10f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            //transform.Rotate(5.0f, 0.0f, 0.0f, Space.Self);
            transform.RotateAround(p, transform.forward, -10f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            //transform.Rotate(5.0f, 0.0f, 0.0f, Space.Self);
            transform.RotateAround(p,transform.up, 10f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            //transform.Rotate(5.0f, 0.0f, 0.0f, Space.Self);
            transform.RotateAround(p, transform.up, -10f);
        }

    }
}
