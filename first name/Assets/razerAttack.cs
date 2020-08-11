using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class razerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D razer;
    public playercontroll playerControll;
    void Start()
    {
        razer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        razer.velocity = new Vector2(5, 0);
        print(GetComponent<Rigidbody2D>().position);
        /*if(GetComponent<Rigidbody2D>().position.Equals(playerControll.GetPlayerPosition()))
        {
            Destroy(razer);
        }*/
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collideObject = collision.gameObject;

        if (collision.gameObject.tag == "Player")
        {
            print("asdfasdf");
            Destroy(collideObject);
        }
    }

}