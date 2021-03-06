using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pointsPlayerLeft;
    public int pointsPlayerRight;
    public Text score;
    public AudioSource goal;
    void Start()
    {
        Cursor.visible = false;
        
        pointsPlayerLeft = 0;
        pointsPlayerRight = 0;
        score.text = pointsPlayerLeft + " X " + pointsPlayerRight;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            GameStart();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            ExitGame();
        }
    }

    public void IncreaseScorePlayerLeft()
    {
        pointsPlayerLeft += 1;
        UpdateTextScore();
    }

    public void IncreaseScorePlayerRight()
    {
        pointsPlayerRight += 1;
        UpdateTextScore();
    }

    public void UpdateTextScore()
    {
        score.text = pointsPlayerLeft + " X " + pointsPlayerRight;
        goal.Play();
    }

    private void GameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void ExitGame()
    {
        Application.Quit();
        Debug.Log("Sair do jogo");
    }
}
