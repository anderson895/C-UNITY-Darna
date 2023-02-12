using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float weaponDamage;
    public float projectileSpeed;
    public GameObject impactEffect;

    private Rigidbody2D rigidbody;

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = transform.right * projectileSpeed;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Instantiate(impactEffect, transform.position, Quaternion.identity);
     
      
        Destroy(gameObject);
       
            enemyHealth hurtEnemy = col.gameObject.GetComponent<enemyHealth>();
            hurtEnemy.addDamage(weaponDamage);

            if (col.tag == "tikbalang1")
            {
               
                tikbalang1.health -= weaponDamage;

                //ScoreScript.curscore += 1;
            }
            if (col.tag == "tikbalang2")
            {

                tikbalang2.health -= weaponDamage;

                //ScoreScript.curscore += 1;
            }
        if (col.tag == "takbalang3")
        {

            takbalang3.health -= weaponDamage;

            //ScoreScript.curscore += 1;
        }

        if (col.tag == "tikbalang5")
        {

            tikbalang5.health -= weaponDamage;

            //ScoreScript.curscore += 1;
        }


        if (col.tag == "manananggal1")
        {

            manananggal1.health -= weaponDamage;

            //ScoreScript.curscore += 1;
        }

        if (col.tag == "manananggal2")
        {

            manananggal2.health -= weaponDamage;

            //ScoreScript.curscore += 1;
        }

        if (col.tag == "manananggal3")
        {

            manananggal3.health -= weaponDamage;

            //ScoreScript.curscore += 1;
        }

        if (col.tag == "manananggal4")
        {

            mananggal4.health -= weaponDamage;

            //ScoreScript.curscore += 1;
        }
        if (col.tag == "Kapre1")
        {

            Kapre1.health -= weaponDamage;

            //ScoreScript.curscore += 1;
        }

        if (col.tag == "kapre2")
        {

            Kapre2.health -= weaponDamage;

            //ScoreScript.curscore += 1;
        }



        if (col.tag == "valentina1")
        {

            valentina1.health -= weaponDamage;

            //ScoreScript.curscore += 1;
        }

        if (col.tag == "valentina2")
        {

            valentina2.health -= weaponDamage;

            //ScoreScript.curscore += 1;
        }

        if (col.tag == "valentina boss")
        {

            valentinaBoss.health -= weaponDamage;

            //ScoreScript.curscore += 1;
        }

        if (col.tag == "BlackDarna")
        {

            BlackDarna.health -= weaponDamage;

            //ScoreScript.curscore += 1;

        }


        if (col.tag == "manananggal6")
        {

            manananggal6.health -= weaponDamage;

            //ScoreScript.curscore += 1;






        }


        if (col.tag == "manananggal7")
        {

            manananggal7.health -= weaponDamage;

            //ScoreScript.curscore += 1;






        }
        if (col.tag == "wall")
        {
            Destroy(gameObject, 0.02f);
            //ScoreScript.curscore += 1;
        }




        if (col.tag == "object")
        {
            ScoreScript.curscore += 1;
            Destroy(col.gameObject, 0.3f);


        }

            
       

    }
}
