using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShieldCollision : MonoBehaviour
{
    public MyGameController MGC;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            MGC.Points += 1;
        }
    }
}