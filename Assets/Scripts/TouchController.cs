using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class TouchController : MonoBehaviour
{
    public float speed = 10f;
    
    private float screenHeight;
    private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        screenHeight = Screen.height;
        velocity = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            // touchPos.z = 0;

            // Move Up
            if (touch.position.y > screenHeight / 2 && touch.phase == TouchPhase.Began)
            {
                if (velocity.y < 1)
                {
                    velocity += Vector3.up;
                }

            }

            // Move Down
            else if (touch.position.y < screenHeight / 2 && touch.phase == TouchPhase.Began)
            {
                if (velocity.y > -1)
                {
                    velocity += Vector3.down;
                }

            }

            transform.position = Vector3.Lerp(transform.position, velocity, speed);
        }
    }
}
