using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LinkStart : MonoBehaviour
{
    //playercontroll p1;
    public bossControllor boss1;
    public GameObject bossObject;
    public int bossBlood;
    public int attack;

    // Start is called before the first frame update
    void Start()
    {
        boss1 = new bossControllor(2, 0, 0, 0f, 0, 0);
        print("new boss");
        boss1.SetAttackPower(1);
        bossBlood = boss1.getBlood();
        attack = boss1.getAttack();

    }

    // Update is called once per frame
    void Update()
    {
        //boss1.hunt(bossObject, bossBlood, attack);
        //print("adfa"+bossBlood);
        //print("adfa" + attack);
        //boss1.OnCollisionEnter2D();
        boss1.hunt(bossObject, bossBlood, attack);
    }

    public void OnCollisionEnter2D()
    {
        //boss1.hunt(bossObject, bossBlood, attack);
        //print("destroy");
        //Destroy(bossObject);
    }

}
