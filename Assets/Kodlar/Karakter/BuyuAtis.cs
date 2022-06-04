using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyuAtis : MonoBehaviour
{
    [SerializeField] private GameObject _buyuSpawnNoktasi;
    [SerializeField] private GameObject[] _buyuSimsek;
    
    public void buyuAtis()
    {
        Instantiate(_buyuSimsek[Random.Range(0,4)],_buyuSpawnNoktasi.transform.position , Quaternion.identity);
    }
    
}
