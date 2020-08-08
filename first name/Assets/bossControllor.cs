using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;


public class bossControllor : MonoBehaviour
{
    public Rigidbody2D boss;
    public int blood = 10;
    public float speed = 0.01f;
    int PlayerAttackPower=1;
    

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
    void Hunt(int attackpower)
    {
        blood -= attackpower;
        print(blood);
        if (blood <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void SetPlayerAttackPower(int x)
    {
        PlayerAttackPower = x;
    }
    void OnCollisionEnter2D()
    {
        Hunt(PlayerAttackPower);
        print("collide"); //碰到碰撞器時印出"A"
        //Destroy(this.gameObject);

    }
}
