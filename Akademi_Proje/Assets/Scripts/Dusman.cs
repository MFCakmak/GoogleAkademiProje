using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    public Transform oyuncu;
    private Vector2 dusmanHareket;
    private float hareketHizi = 5f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direciton = oyuncu.position - transform.position;
        float hedefAcı = Mathf.Atan2(direciton.y, direciton.x) * Mathf.Rad2Deg;
        rb.rotation = hedefAcı;
        direciton.Normalize();
        dusmanHareket = direciton;
    }

    private void FixedUpdate()
    {
        dusmanHareketi(dusmanHareket);
    }

    void dusmanHareketi(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position +(direction * hareketHizi * Time.deltaTime));
    }
}
