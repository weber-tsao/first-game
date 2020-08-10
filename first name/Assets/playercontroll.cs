﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;


public class playercontroll : MonoBehaviour

{  
    // field
    public Rigidbody2D player;  
    public float speed = 0.0001f;
    public float mousePositionX;
    public float mousePositionY;
    public float mousePositionZ;
    public float speedx, speedy;
    public int attackPower = 1;
    //public healthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    { 
        speedx = player.velocity.x*0.01f;
        speedy = player.velocity.y*0.01f;
        player.velocity = player.velocity * (1-speed);// to slow down
    }

    // mouse onclick
    void OnMouseDown() 
    {
        mousePositionX = Input.mousePosition.x;
        mousePositionY = Input.mousePosition.y;
        mousePositionZ = Input.mousePosition.z;
    }

    // mouse unclick
    void OnMouseUp()
    {
        player.velocity = new Vector2((mousePositionX - Input.mousePosition.x) / 10 , (mousePositionY - Input.mousePosition.y) / 10);
    }

    // collide event
    /*public void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        GameObject collideObject = collision.gameObject;
        bossHealth healthOfBoss = collideObject.GetComponent<bossHealth>();// create bossHealth object
        //print(bossHealth.currentHealth);

        if (collision.gameObject.name == "boss") 
        { 
            healthOfBoss.TakeDamage(attackPower, collideObject);// call the function of damaging
            //healthbar.setHealth(bossHealth.currentHealth);
        }
    }*/

    // set player attack power
    void SetAttackPower(int attack)
    {
        attackPower = attack;
    }

    int GetAttackPower()
    {
        return attackPower;
    }
}
