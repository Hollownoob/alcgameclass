using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerControler : MonoBehaviour
{
    public int speed = 10;
    public int jumpPower = 10;
    public int xInput;
    public int yInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * xInput * speed * Time.deltaTime);
        transform.Translate(Vector2.up * yInput * jumpPower * Time.deltaTime);
    }
}
