using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Security.Cryptography;
using UnityEngine;

public class fullScreenTouch : MonoBehaviour
{
    // field
    public Rigidbody2D player;
    public GameObject arrow2;
    public GameObject arrow1;
    public float clickPositionX;
    public float clickPositionY;
    public float dragPositionX;
    public float dragPositionY;
    public playercontroll pc;
    public bool isDrag = true;

    // Start is called before the first frame update
    void Start()
    {
        arrow2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        arrowMove();
    }

    void OnMouseDown() //點擊
    {
        clickPositionX = Input.mousePosition.x;
        clickPositionY = Input.mousePosition.y;
    }

    void OnMouseUp() //放開
    {
        dragPositionX = Input.mousePosition.x;
        dragPositionY = Input.mousePosition.y;
        if (player != null) 
        {
            player.velocity = new Vector2((clickPositionX - dragPositionX) / 50, (clickPositionY - dragPositionY) / 50);
            //Destroy(arrow1);
            isDrag = true;
            //print("2c2c");
            arrow2.SetActive(false);
        }
    }

    void OnMouseDrag() //拖曳
    {
        if (player != null && isDrag == true)
        {
            //arrow1 = (GameObject)Instantiate(arrow, new Vector3(pc.getPlayerPositionX(), pc.getPlayerPositionY(), 0), new Quaternion(0, 0, 180, 0));
            isDrag = false;
            //print("FW AD");
            arrow2.SetActive(true);
        }
    }

    void arrowMove()
    {
        if (player != null)
        {
            var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(-dir.y, -dir.x) * Mathf.Rad2Deg;
            arrow2.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
