using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _ileriSeviyeButonu;

    void OyunuBitir()
    {

    }

    public void İleriSeviye()
    {
        _ileriSeviyeButonu.SetActive(true);
    }
}
