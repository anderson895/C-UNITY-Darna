using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            

            ScoreScript.curscore += 100;
            Destroy(gameObject, 0.3f);
        }
    }

}
