using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KarakterCan : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _karakterCanBariText;
    private static float _karakterCan = 100f;
    private bool _karakterYasiyor;
    
        
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("mermi"))
        {
            _karakterCan = _karakterCan - 20f;
        }
    }
    
    void karakterCanTextDegis()
    {
        _karakterCanBariText.text = "Can :" + _karakterCan.ToString();
    }
    void Update()
    {
        karakterCanTextDegis();

        if (_karakterCan <= 0 )
        {
            _karakterYasiyor = false;
        }
    }
}
