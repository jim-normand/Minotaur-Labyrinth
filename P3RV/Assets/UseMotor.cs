﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UseMotor : MonoBehaviour
{
    
    public Rigidbody Skull;
    // Start is called before the first frame update
    void Start()
    {
        Skull = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Skull.AddForce(transform.forward * 250, ForceMode.VelocityChange);
        }
    }
}
