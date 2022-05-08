using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Touch touch;
    private Vector2 movement;
    public Joystick _joystick;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = _joystick.Horizontal * moveSpeed;
        movement.y = _joystick.Vertical * moveSpeed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
    }
}
