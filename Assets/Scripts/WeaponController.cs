using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public Rigidbody2D bullet;
    private float bulletSpeed = 6f;

    void Start()
    {
        // InvokeRepeating("SpawnBullet",0.5f, 0.5f);
    }


    public void SpawnBullet()
    {
        if (Time.timeScale == 0f)
        {
            return;
        }

        Rigidbody2D instance = Instantiate(bullet, transform.position, transform.rotation);
        instance.velocity = Vector2.right * bulletSpeed;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
