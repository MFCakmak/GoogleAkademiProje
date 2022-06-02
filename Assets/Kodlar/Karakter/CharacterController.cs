using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float speed = 0.0f;
    public float horizontal = 0.0f;
    public float vertical = 0.0f;
    float moveLimiter = 0.7f;
    private Rigidbody2D r2d;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical"); 
        speed = 2.0f;
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        } 
        _animator.SetFloat("speed",speed);
        _animator.SetFloat("horizontal",horizontal);
        _animator.SetFloat("vertical",vertical);
        r2d.velocity = new Vector2(x:horizontal*speed, y:vertical*speed);
    }
    void FixedUpdate()
    {
        

    }
}
