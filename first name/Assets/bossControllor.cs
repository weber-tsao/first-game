using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class bossControllor : MonoBehaviour
{
    public Rigidbody2D boss;
    public int blood = 10;
    public float speed = 0.01f;
    int attackPower = 10;
    int defense = 0;
    int mode = 0;
    int debuff = 0;
    int bossAttack=0;

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
    void Hunt(int attack)
    {

        blood -= attack;
        print(attack);
        print(blood);
        if (blood <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void SetAttackPower(int x)
    {
        attackPower = x;
    }
    
    void OnCollisionEnter2D()
    {
        Hunt(attackPower);
        //print("collide"); //碰到碰撞器時印出"A"
        //Destroy(this.gameObject);

    }
}
