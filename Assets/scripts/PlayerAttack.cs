using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	public Transform FirePosition;
    public GameObject projectile;



    public Transform PunchPosition;
    public GameObject tilepunch;
   


    // Update is called once per frame
    void Update () {
        if (Input.GetKeyUp(KeyCode.Q)) { 
            Instantiate (projectile,FirePosition.position,FirePosition.rotation);
             
		}

        if (Input.GetKeyUp(KeyCode.E))
        {
            Instantiate(tilepunch, PunchPosition.position, PunchPosition.rotation);
        }

    }
}
