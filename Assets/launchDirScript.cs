using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchDirScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            transform.Rotate(0, 0, 7f, Space.Self);
            //transform.Rotate(xAngle, yAngle, zAngle, Space.World);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            transform.Rotate(0, 0, -7f, Space.Self);
            //transform.Rotate(xAngle, yAngle, zAngle, Space.World);
        }
        else if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            gameObject.SetActive(false);
        }
    }
}
