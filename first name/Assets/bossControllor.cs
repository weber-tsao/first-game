using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;


public class bossControllor : MonoBehaviour
{
    // field
    public Rigidbody2D boss;
    public int blood;
    public float speed;
    int attackPower;
    int defense;
    int mode;
    int debuff;
    int bossAttack;

    // constructor
    public bossControllor(int Blood1, int Defense1, int Atttack1, float Speed1, int Mode1, int Debuff1)
    {
        blood = Blood1;
        defense = Defense1;
        bossAttack = Atttack1;
        speed = Speed1;
        mode = Mode1;
        debuff = Debuff1;
    }

    // Start is called before the first frame update
    void Start()
    {
        boss = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void SetAttackPower(int x)
    {
        attackPower = x;
    }

    public int getBlood()
    {
        return blood;
    }

    public int getAttack()
    {
        return attackPower;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {


    }
}

    

