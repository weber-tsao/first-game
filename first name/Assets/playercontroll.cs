using System;
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

    public float speedx, speedy;
    public int attackPower = 1;
    public healthBar bossHealthbar;
    public healthBar playerHealthbar;
    public playerHealth healthOfPlayer;



    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        healthOfPlayer = GetComponent<playerHealth>();// create bossHealth object
        
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth healthOfPlayer = GetComponent<playerHealth>();
        speedx = player.velocity.x*0.01f;
        speedy = player.velocity.y*0.01f;
        player.velocity = player.velocity * (1-speed);// to slow down 
        
    }


    // collide event
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //print(collision.gameObject.name);
        GameObject collideObject = collision.gameObject;
        bossHealth healthOfBoss = collideObject.GetComponent<bossHealth>();// create bossHealth object
        
        if (collision.gameObject.name == "boss") 
        {
            print("Boss Hp: " + healthOfBoss.getCurrentHp());
            healthOfBoss.TakeDamage(attackPower, collideObject);// call the function of damaging
            bossHealthbar.setHealth(healthOfBoss.getCurrentHp());// set health bar to the value of current boss hp
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collideObject = collision.gameObject;
        //playerHealth healthOfPlayer = GetComponent<playerHealth>();// create bossHealth object

        if (collision.gameObject.tag == "bullet")
        {
            print("Player Hp: " + healthOfPlayer.getCurrentHp());
            healthOfPlayer.TakeDamage(1, this.gameObject);// call the function of damaging
            playerHealthbar.setHealth(healthOfPlayer.getCurrentHp());// set health bar to the value of current boss hp
        }
    }

    // set player attack power
    void SetAttackPower(int attack)
    {
        attackPower = attack;
    }

    // get attack power
    int GetAttackPower()
    {
        return attackPower;
    }

    public Vector2 GetPlayerPosition()
    {
        return player.position;
    }

    public Rigidbody2D getGameObject()
    {
        return player;
    }

    public float getPlayerPositionX()
    {
        return player.transform.position.x;
    }

    public float getPlayerPositionY()
    {
        return player.transform.position.y;
    }
}
