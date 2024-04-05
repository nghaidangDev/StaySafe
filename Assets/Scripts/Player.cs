using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float dirY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, dirY);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * speed);
    }
}
