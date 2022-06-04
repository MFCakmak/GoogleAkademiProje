using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyuHareket : MonoBehaviour
{
    [SerializeField] private float _buyuHiz = 10f;
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * _buyuHiz * Time.deltaTime);
        Destroy(gameObject, 2f);
    }
}
