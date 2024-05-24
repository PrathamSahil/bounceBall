using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectScript : MonoBehaviour
{
    public Rigidbody2D objectBody;
    private bool checkX = true;
    private bool gameStarted = false;
    private float hVel = 0;
    // Start is called before the first frame update
    void Start()
    {
        //objectBody.velocity = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
        //objectBody.velocity = new Vector2(5, 5);
        //gameObject.SetActive(false);
        transform.position = new Vector3(-10f, -10f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted)
        {
            if (checkX)
            {
                if (transform.position.x < -7.3)
                {
                    objectBody.velocity = new Vector2(5, objectBody.velocity.y);
                }
                if (transform.position.x > 7.3)
                {
                    objectBody.velocity = new Vector2(-5, objectBody.velocity.y);
                }
                checkX = false;
            }
            else
            {
                if (transform.position.y < -4.5)
                {
                    objectBody.velocity = new Vector2(objectBody.velocity.x, 5);
                }
                if (transform.position.y > 4.5)
                {
                    objectBody.velocity = new Vector2(objectBody.velocity.x, -5);
                }
                checkX = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
            {
                hVel -= 0.5f;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) == true)
            {
                hVel += 0.5f;
            }
            else if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                //gameObject.SetActive(true);
                transform.position = new Vector3(0, -4.8f, 0);
                gameStarted = true;
                objectBody.velocity = new Vector2(hVel, 5);
            }
        }
        
    }
    
}
