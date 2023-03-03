using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float upForce = 10f;
    public bool isDead = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isDead)
        {
            //rb.velocity = Vector2.zero;
            //rb.AddForce(new Vector2(0, upForce));

            rb.velocity = Vector2.up * upForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameOver();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameOver();
    }

    private void GameOver()
    {
        GameManager.Instance.GameOver();
        isDead = true;
    }
}
