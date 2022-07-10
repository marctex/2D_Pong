using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayerLeft;
    public int scorePlayerRight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScorePlayerLeft()
    {
        scorePlayerLeft += 1;
    }

    public void IncreaseScorePlayerRight()
    {
        scorePlayerRight += 1;
    }

}
