using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterCan : MonoBehaviour
{
    private static float _karakterCan = 100f;
    private bool _karakterYasiyor;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("mermi"))
        {
            _karakterCan = _karakterCan - 20f;
        }
    }
    void Update()
    {
        if (_karakterCan <= 0 )
        {
            _karakterYasiyor = false;
        }
    }
}
