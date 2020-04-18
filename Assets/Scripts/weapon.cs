using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

  
    public Rigidbody2D bullet;
    private float speed = 6f;



    void Start()
    {
        InvokeRepeating("SpawnBullet",0.5f, 0.5f);
    }


    void SpawnBullet()
    {



        Rigidbody2D instance = Instantiate(bullet, transform);
        instance.velocity = Vector2.right * speed;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
