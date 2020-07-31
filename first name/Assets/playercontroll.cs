using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class playercontroll : MonoBehaviour
{   //public RigidBody2D player;

    
    

    public float speed = 0.01f;


    // Start is called before the first frame update
    void Start()
    {
        //player = getComponent<RigidBody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //gameObject.transform.position += new Vector3(speed, 0, 0);
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position -= new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position -= new Vector3(0, speed, 0);
        }
    }

    

    void OnMouseDown()
    {
        print("working");
        gameObject.transform.position -= new Vector3(0, 0.5f, 0);
    }
}
