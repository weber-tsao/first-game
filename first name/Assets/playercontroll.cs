﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroll : MonoBehaviour
{   //public RigidBody2D player;

    // Start is called before the first frame update
    void Start()
    {
        //player = getComponent<RigidBody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(0.1f, 0, 0);
        }
    }
}