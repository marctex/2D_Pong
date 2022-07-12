using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int pointsPlayerLeft;
    public int pointsPlayerRight;
    public Text score;
    public AudioSource goal;
    void Start()
    {
        Debug.Log("Start");
        pointsPlayerLeft = 0;
        pointsPlayerRight = 0;
        score.text = pointsPlayerLeft + " X " + pointsPlayerRight;
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
