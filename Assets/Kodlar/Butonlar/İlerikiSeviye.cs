using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class İlerikiSeviye : MonoBehaviour
{
    public void İlerikiseviye()
    {
        StartCoroutine(leveleGecmedenBeklet());
    }

    IEnumerator leveleGecmedenBeklet()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}