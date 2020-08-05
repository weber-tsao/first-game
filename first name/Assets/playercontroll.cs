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
       
        //playerVector.set(speedx * 0.01f, speedy * 0.01f);
       
        //print("velocity x " + player.velocity.x);
        //print("velocity y " + player.velocity.y);
        //print("speed x " + speedx);
        //print("speed y " + speedy);
    }

    

    void OnMouseDown()
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
}
