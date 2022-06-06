using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunSonu : MonoBehaviour
{
    public GameObject _oyunSonu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("OyunSonu"))
        {
            _oyunSonu.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
