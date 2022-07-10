using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed;
    public Rigidbody2D oRigidgody2D;
    public AudioSource soundBall;
    public float randomDirectionX;
    public float randomDirectionY;
    void Start()
    {
        MoveBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoveBall()
    {
        oRigidgody2D.velocity = new Vector2(ballSpeed, ballSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        soundBall.Play();
        oRigidgody2D.velocity += new Vector2(randomDirectionX, randomDirectionY);
    }
}
