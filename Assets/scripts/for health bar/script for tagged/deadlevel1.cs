using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class deadlevel1 : MonoBehaviour


{


    public float pcurrentHealth;

    [SerializeField] private string StartStage;
    // Use this for initialization

    void OnTriggerEnter2D(Collider2D other)
    {
        if (pcurrentHealth <= 0)
        {
            {
                SceneManager.LoadScene(StartStage);
            }
        }
    }

}
