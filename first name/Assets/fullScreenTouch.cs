using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class fullScreenTouch : MonoBehaviour
{
    public Rigidbody2D player;
    public GameObject arrow;
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
      
    }

    // Update is called once per frame
    void Update()
    {
      
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
            Destroy(arrow1);
            isDrag = true;
        }
    }

    void OnMouseDrag() //拖曳
    {
        if (player != null && isDrag == true)
        {
            arrow1 = (GameObject)Instantiate(arrow, pc.GetPlayerPosition(), new Quaternion(0, 90, 180, 0));
            isDrag = false;
        }
    }
    
}
