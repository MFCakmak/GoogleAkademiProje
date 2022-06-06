using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanCan : MonoBehaviour
{
    private int _dusmanCan = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Buyu"))
        {
            Debug.Log("Düsman Vuruldu");
            _dusmanCan = _dusmanCan - 20;
        }
    }
    private void Update()
    {
        if (_dusmanCan<=0)
        {
            Destroy(gameObject);
        }
    }

}
