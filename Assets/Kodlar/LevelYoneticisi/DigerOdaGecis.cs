using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigerOdaGecis : MonoBehaviour
{
    private GameManager _gameManager;
    private void Awake()
    {
        _gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DigerOda"))
        {
            Debug.Log("Temas Var");
           // _gameManager.�leriSeviye();
        }
    }
  
}
