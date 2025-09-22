using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float speed;
    public float upperBound = 15.0f;
    public ScoreManager scoreManager;
    public Ballon ballon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        ballon = GetComponent<Ballon>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if(transform.position.y >= upperBound)
        {
            scoreManager.DecreaseScoreText(ballon.scoreToGive);
            Destroy(gameObject);
        }
    }

}
