using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int scorePlayerLeft;
    int scorePlayerRight;
    public Text textScore;
    public AudioSource soundGoal;

    void Start()
    {
        
    }   

    public void IncreaseScorePlayerLeft()
    {
        scorePlayerLeft += 1;
        AtualzaTexScore();        
    }

    public void IncreaseScorePlayerRight()
    {
        scorePlayerRight += 1;
        AtualzaTexScore();        
    }

    public void AtualzaTexScore()
    {
        textScore.text = scorePlayerLeft + " X " + scorePlayerRight;
        soundGoal.Play();
    }

}
