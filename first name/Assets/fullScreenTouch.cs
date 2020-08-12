using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class fullScreenTouch : MonoBehaviour
{
    public Rigidbody2D player;
    public float clickPositionX;
    public float clickPositionY;
    public float dragPositionX;
    public float dragPositionY;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        clickPositionX = Input.mousePosition.x;
        clickPositionY = Input.mousePosition.y;
    }

    void OnMouseUp()
    {
        dragPositionX = Input.mousePosition.x;
        dragPositionY = Input.mousePosition.y;
        if (player != null) {
            player.velocity = new Vector2((clickPositionX - dragPositionX) / 10, (clickPositionY - dragPositionY) / 10);
        }
    }
}
