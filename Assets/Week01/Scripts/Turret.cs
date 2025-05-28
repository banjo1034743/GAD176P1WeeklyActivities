using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{


    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, -1, 0);
        }
    }
}
