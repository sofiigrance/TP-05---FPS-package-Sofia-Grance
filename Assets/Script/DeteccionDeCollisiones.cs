﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeCollisiones : MonoBehaviour
{
    // Start is called before the first frame update
     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
        
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
