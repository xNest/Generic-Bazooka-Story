using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Rigidbody2D EnemyRigidbody2D;
    private float _movementSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int numEnemy = 3;
        // int maxEnemy = 0;

        for (int i = 0; i < numEnemy; i++)
        {
            int chase = Random.Range(0, 2);
            if (chase == 0 )
            {
                Rigidbody2D instance = Instantiate(EnemyRigidbody2D, transform);
                instance.velocity = Vector2.left * _movementSpeed;
                instance.transform.position = instance.transform.position + Vector3.down * i;
                // maxEnemy += 1;
            }
        }
    }
}
