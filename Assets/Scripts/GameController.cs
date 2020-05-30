using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject GameOverPanel;
    public Text EndScoreText;
    public PlayerCollider Player;
    private PointController _pointController;
    private bool _endGame = false; 

    // Start is called before the first frame update
    void Start()
    {
        GameOverPanel.gameObject.SetActive(false);
        _pointController = FindObjectOfType<PointController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        Destroy(this.Player.gameObject);
        _endGame = true;
        Time.timeScale = 0;
        EndScoreText.text = "Score: " + _pointController.GetPoints();
        GameOverPanel.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void PauseToggle()
    {
        if (Time.timeScale == 1f)
        {
            Time.timeScale = 0;
        }
        else if (!_endGame)
        {
            Time.timeScale = 1;
        }
    }
}
