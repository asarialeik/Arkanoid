using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallBehavior : MonoBehaviour
{
    float ballInitialSpeed = 5f;
    int lives = 3;
    Rigidbody2D ballRigidBody;
    bool isLaunched = false;
    [SerializeField]
    GameObject startMenu;
    [SerializeField]
    GameObject gameOver;
    [SerializeField]
    GameObject player;
    [SerializeField]
    TMP_Text livesText;

    void Start()
    {
        startMenu.SetActive(true);
        gameOver.SetActive(false);
        ballRigidBody = GetComponent<Rigidbody2D>();
        ballRigidBody.velocity = Vector2.zero;
    }

    void Update()
    {
        if (isLaunched == false && Input.GetButtonDown("Jump"))
        {
            LaunchBall();
        }
    }

    private void LaunchBall()
    {
        transform.parent = null;
        float randomDirection = Random.Range(-1f, 1f);
        Vector2 launchDirection = new Vector2(randomDirection, 1);
        ballRigidBody.velocity = launchDirection * ballInitialSpeed;
        isLaunched = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bottom"))
        {
            LoseLife();
            ResetBall();
        }
    }

    private void LoseLife()
    {
        lives = lives -1;
        DisplayLives();

        if (lives > 0)
        {
            ResetBall();
        }
        else
        {
            GameOver();
        }
    }

    private void DisplayLives()
    {
       livesText.text = lives.ToString();
    }

    private void ResetBall()
    {
        gameObject.transform.parent = player.transform;
        ballRigidBody.velocity = Vector2.zero;
        transform.position = player.transform.position;
        isLaunched = false;
    }

    private void GameOver()
    {
        gameOver.SetActive(true);
    }
}
