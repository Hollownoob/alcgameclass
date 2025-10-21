using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerControler : MonoBehaviour
{
    [Header("Player settings")]
    public float moveSpeed;
    public float jumpForce;
    public bool isGrounded;
    public int bottomBound = -4;
    public int score;
    public Rigidbody2D rig;
    public TextMeshProUGUI scoreText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "score: " + score;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rig.linearVelocity = new Vector2(moveInput * moveSpeed, rig.linearVelocity.y);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            isGrounded = false;
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        if(transform.position.y < bottomBound)
        {
            GameOver();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.GetContact(0).normal == Vector2.up)
        {
            isGrounded = true;
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}