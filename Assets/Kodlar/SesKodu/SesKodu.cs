using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKodu : MonoBehaviour
{
    private AudioSource _sesler;
    public AudioClip _buyuSesi;
    public AudioClip _kapiSesi;

    void Start()
    {
        _sesler = GameObject.FindWithTag("Player").GetComponent<AudioSource>();
    }

    public void buyuAtis()
    {
        _sesler.PlayOneShot(_buyuSesi, 1f);
    }

    public void kapiSesi()
    {
        _sesler.PlayOneShot(_kapiSesi, 1f);
    }


  
}
