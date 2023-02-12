using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroymepunch : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 0.05f);
    }
}
