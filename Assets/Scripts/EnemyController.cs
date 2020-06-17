using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private PointController _pointController;
    private GameController _gameController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (this.gameObject.CompareTag(("EnemyCollider")))
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _gameController.EndGame();
            }

            else if (other.gameObject.CompareTag("bullet"))
            {
                Destroy(other.gameObject);
            }

            return;
        }

        if (other.gameObject.CompareTag("Player"))
        {
            _gameController.EndGame();
        }
        else if (other.gameObject.CompareTag("bullet"))
        {
            _pointController.Add();
            Destroy(this.gameObject);
        }
        else if (other.gameObject.CompareTag("Finish"))
        {
            _gameController.EndGame();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        _pointController = FindObjectOfType<PointController>();
        _gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}