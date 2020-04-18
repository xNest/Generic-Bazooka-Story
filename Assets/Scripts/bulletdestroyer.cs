using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdestroyer : MonoBehaviour
{

    public Transform gameobject;
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameobject.name == Bullet1)
        {
            Destroy(gameobject);
        }
    }


}
