using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingobj : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            Invoke("Fall", 0.8f);
            Destroy(gameObject, 2f);
        }
    }
    void Fall()
    {
        rb.isKinematic = false;
    }
}
