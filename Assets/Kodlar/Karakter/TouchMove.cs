using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{
    public float _hareketHizi = 5.0f;
    public Touch dokunma;
    private Vector2 _hareket;
    public Joystick _joystick;
    private Rigidbody2D _karakterRigitbody;
    private Animator _karakterAnimasyon;
    private float hiz= 0.0f;
    float hareketLimitleyici = 0.7f;
    public AudioSource _yurumeSesi;
    private void Start()
    {
        _karakterRigitbody = GetComponent<Rigidbody2D>();
        _karakterAnimasyon = GetComponent<Animator>();
    }

    void Update()
    {
        
        _hareket.x = _joystick.Horizontal * _hareketHizi;
        _hareket.y = _joystick.Vertical * _hareketHizi;
        hiz = 2.0f;

        if (_hareket.x != 0 && _hareket.y != 0)
        {
            _hareket.x *= hareketLimitleyici;
            _hareket.y *= hareketLimitleyici;

        }
        if (Input.GetMouseButtonDown(0))
        {
            _yurumeSesi.Play();
        }
        if (Input.GetMouseButtonUp(0))
        {
            _yurumeSesi.Stop();
        }


        _karakterAnimasyon.SetFloat("speed", hiz);
        _karakterAnimasyon.SetFloat("horizontal", _hareket.x);
        _karakterAnimasyon.SetFloat("vertical", _hareket.y);
        _karakterRigitbody.velocity = new Vector2(_hareket.x * hiz, _hareket.y * hiz);
        
    }

    private void FixedUpdate()
    {
        _karakterRigitbody.MovePosition(_karakterRigitbody.position + _hareket * Time.fixedDeltaTime);
    }
}
