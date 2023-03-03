using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float deadZone = -45f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        //transform.Translate(-transform.right * moveSpeed * Time.deltaTime);

        if (transform.position.x <= deadZone)
        {
            Destroy(gameObject);
        }
    }
}
