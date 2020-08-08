using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;


public class playercontroll : MonoBehaviour

{  
    public Rigidbody2D player;  
    public float speed = 0.0001f;
    public float mousePositionX;
    public float mousePositionY;
    public float mousePositionZ;
    float speedx, speedy;
    int attackPower = 20000;

    void SetAttackPower(int x)
    {
        attackPower = x;
    }

    int GetAttackPower()
    {
        return attackPower;
    }

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
        player.velocity = player.velocity * (1-speed);
    }

    void OnMouseDown() //點下
    {
        //print("click");
        //print(Input.mousePosition.x);
        //print(Input.mousePosition.y);
        //print(Input.mousePosition.z);
        mousePositionX = Input.mousePosition.x;
        mousePositionY = Input.mousePosition.y;
        mousePositionZ = Input.mousePosition.z;
    }

    void OnMouseUp()

    {
        //print("drag");
        //print(Input.mousePosition.x);
        //print(Input.mousePosition.y);
        //print(Input.mousePosition.z);
        //print("value from click: " + mousePositionX);
        player.velocity = new Vector2((mousePositionX - Input.mousePosition.x) / 10 , (mousePositionY - Input.mousePosition.y) / 10);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        GameObject boss = collision.gameObject;
        bossHealth healthOfBoss = boss.GetComponent<bossHealth>();
        if (collision.gameObject.name == "boss") 
        { 
            healthOfBoss.TakeDamage(1, boss);
        }
    }
}
