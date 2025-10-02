using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public float hInput;
    public float vInput;
    public float jumpForce;
    public GameObject firePoint;
    public Rigidbody playerRB;
    public void Start ()
    {

    }
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime);
    }
}