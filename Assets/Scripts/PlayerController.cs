using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float jumpForce = 5f;

    private Rigidbody2D rb;
    private Vector2 movment;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                if (transform.position.y >= 3f)
                {
                    transform.position = new Vector3(transform.position.x, -3, 0);
                }
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + 3, 0);
                }
                
            }

            Debug.Log(transform.position);
        }
    }

}
