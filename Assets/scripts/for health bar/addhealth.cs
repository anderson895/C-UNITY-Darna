using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addhealth : MonoBehaviour
{
    public float dagdagHealth;// attack1Damage

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            healthbarscript.health += dagdagHealth;
            Destroy(gameObject, 0.1f);
            //ScoreScript.curscore += 1;
        }

        //ScoreScript.curscore += 1;
    }


}
