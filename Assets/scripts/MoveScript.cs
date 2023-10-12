using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    Vector3 currentPos;

    // Start is called before the first frame update
    void Start()
    {
        this.currentPos = this.transform.position ;
    }

    // Update is called once per frame
    float speed = 5;
    void Update()
    {
        Debug.Log("camera:" + Camera.main.transform.position);
        float vt = Input.GetAxis("Vertical");
        float ht = Input.GetAxis("Horizontal");
        if (vt != 0)
        {
            currentPos += Camera.main.transform.forward*Time.deltaTime * Mathf.Sign(vt)*speed;
            this.transform.position = currentPos;
        }
        if (ht != 0) {
            //currentPos ;
            this.transform.position = currentPos;

        }
    }
    void Update2()
    {
        float vt = Input.GetAxis("Vertical");
        float ht = Input.GetAxis("Horizontal");
        if (ht != 0)
        {
            currentPos.x += ht / 2;
            this.transform.position = currentPos;
        }
        if (vt != 0)
        {
            currentPos.z += vt / 2;
            this.transform.position = currentPos;

        }
    }

    void Updat2e()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            currentPos.x -= 0.5f;
            this.transform.position = currentPos;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            currentPos.x += 0.5f;
            this.transform.position = currentPos;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            currentPos.z -= 0.5f;
            this.transform.position = currentPos;

            //transform.Rotate(10.0f, 0.0f, 0.0f, Space.Self);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            //transform.Rotate(-10.0f, 0.0f, 0.0f, Space.Self);
            currentPos.z += 0.5f;
            this.transform.position = currentPos;

        }


    }
}
