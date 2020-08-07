using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class bossControllor : MonoBehaviour
{
    public Rigidbody2D boss;
    public int blood;
    public float speed;
    int attackPower;
    int defense;
    int mode;
    int debuff;
    int bossAttack;

    // Start is called before the first frame update
    void Start()
    {
        boss = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
            //gameObject.transform.position -= new Vector3(speed, -speed, 0);
            //print("fuck you" + Screen.width);
    }

    public bossControllor(int Blood1,int Defense1,int Atttack1,float Speed1,int Mode1,int Debuff1)
    {
        blood = Blood1;
        defense = Defense1;
        bossAttack = Atttack1;
        speed = Speed1;
        mode = Mode1;
        debuff = Debuff1;

    }

    public void Hunt(int attack)
    {

        blood -= attack;
       // print(attack);
       // print(blood);
        if (blood <= 0)
        {
            Destroy(this.gameObject);
        }
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

    public void OnCollisionEnter2D()
    {
        
        print("collide"); 

    }

    public void hunt(GameObject boss, int Blood1, int attack)
    {
        //print("hunt");
        Blood1 -= attack;
        
        if (Blood1 <= 0)
        {
            Destroy(boss);
        }
       
    }
}
