using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 moveOffset;
    private Vector3 startPos;
    private Vector3 targetPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        targetPos = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        if(transform.position == targetPos)
        {
            targetPos = startPos + moveOffset;
        }
        else
        {
            targetPos = startPos;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player"))
        {
            collision.GetComponent<PlayerControler>().GameOver();
        }
    }
    private void OnDrawGizmos()
    {
        Vector3 from;
        Vector3 to;
        if(Application.isPlaying)
        {
            from = startPos;
        }
        else
        {
            from = transform.position;
        }
        
        to = from + moveOffset;
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(from, to);
        Gizmos.DrawWireSphere(to, 0.2f);
        Gizmos.DrawWireSphere(from, 0.2f);
    }
}
