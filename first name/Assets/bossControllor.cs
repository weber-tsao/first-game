using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class bossControllor : MonoBehaviour
{
    // field
    public Rigidbody2D boss;
    public float speed;
    int attackPower;
    int defense;
    int mode;
    int debuff;
    int bossAttack;
    //public healthBar healthbar;

    // constructor
    public bossControllor(int Defense1, int Atttack1, float Speed1, int Mode1, int Debuff1)
    {
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

    public int getAttack()
    {
        return attackPower;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
    }
}

    

