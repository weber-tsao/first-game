using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using UnityEngine;

public class playercontroll : MonoBehaviour

{  
    public Rigidbody2D player;  
    public float speed = 1f;
    public float downspeed = 0.001f;
    public float mousePositionX;
    public float mousePositionY;
    public float mousePositionZ;
    public Boolean flag = false;



    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position += new Vector3(speed, 0, 0);
        if (flag == true)
        {
            player.velocity = player.velocity * speed;
            speed -= downspeed;
            if(speed <= 0)
            {
                speed = 0;
            }
        }
    }

    

    void OnMouseDown() //點下
    {
        print("click");
        print(Input.mousePosition.x);
        print(Input.mousePosition.y);
        print(Input.mousePosition.z);
        mousePositionX = Input.mousePosition.x;
        mousePositionY = Input.mousePosition.y;
        mousePositionZ = Input.mousePosition.z;
    }
    
    void OnMouseUp() //放開
    {
        print("drag");
        print(Input.mousePosition.x);
        print(Input.mousePosition.y);
        print(Input.mousePosition.z);
        print("value from click: " + mousePositionX);
        player.velocity = new Vector2((mousePositionX-Input.mousePosition.x)/10, (mousePositionY-Input.mousePosition.y)/10);
        flag = true;
    }
}
