using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman_ates : MonoBehaviour
{
    public float Menzil;
    
    public Transform Hedef;
    public bool tespitEdildi = false;

    private Vector2 Yon;

    public GameObject Silah;

    public GameObject Buyu;
    public float AtesHizi;
    private float AtesArasiSaniye = 0;

    public Transform AtesNoktası;
    public float AtısGucu;
    private void Update()
    {
        Vector2 hedefPozisyonu = Hedef.position;

        Yon = hedefPozisyonu - (Vector2)transform.position;
        
        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Yon,Menzil);

        if (rayInfo)
        {
            if (rayInfo.collider.tag == "Player")
            {
                if (tespitEdildi == false)
                {
                    tespitEdildi = true;
                }
            }
            else
            {
                if (tespitEdildi == true)
                {
                    tespitEdildi = false;
                }
            }
            if (tespitEdildi == true)
            {
                Silah.transform.up = Yon;
                if (Time.time > AtesArasiSaniye)
                {
                    AtesArasiSaniye = Time.time + 1/AtesHizi;
                    Ates();
                }
            }
        }

        
    }

    void Ates()
    {
        GameObject BuyuInst =Instantiate(Buyu, AtesNoktası.position, Quaternion.identity);
        BuyuInst.GetComponent<Rigidbody2D>().AddForce(Yon * AtısGucu);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position,Menzil);
    }
}
