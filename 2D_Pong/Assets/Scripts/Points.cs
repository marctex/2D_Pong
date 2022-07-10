using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public bool pointsPlayerLeft;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (pointsPlayerLeft)
        {
            FindObjectOfType<GameManager>().IncreaseScorePlayerRight();
            other.gameObject.transform.position = Vector2.zero;
        }
        else
        {
            FindObjectOfType<GameManager>().IncreaseScorePlayerLeft();
            other.gameObject.transform.position = Vector2.zero;
        }
    }
}
