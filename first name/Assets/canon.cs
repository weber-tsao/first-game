using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour
{

    public GameObject bulletHorizontal;
    public GameObject bulletVertical;
    public Transform bulletSpawn;
    public fullScreenTouch fullscreentouch;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("randomFire", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    // bullet fire form left
    void fireLeft()
    {
        // Create the Bullet from the Bullet Prefab
        /*GameObject bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);*/

        float coorY = Random.Range(5.0f, -5.5f);
    
        GameObject bullet = (GameObject)Instantiate(
            bulletHorizontal,
            new Vector3(5, coorY, 0), new Quaternion(0, 0, 180, 0));

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right *6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2f);
    }

    // bullet fire form right
    void fireRight()
    {
        float coorY = Random.Range(5.0f, -5.5f);

        GameObject bullet = (GameObject)Instantiate(
            bulletHorizontal,
            new Vector3(-3.5f, coorY, 0), new Quaternion(0, 0, 0, 0));

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2f);
    }

    // bullet fire form above
    void fireUp()
    {
        float coorX = Random.Range(3.2f, -2.1f);

        GameObject bullet = (GameObject)Instantiate(
            bulletVertical,
            new Vector3(coorX, -6.7f, 0), new Quaternion(0, 0, 0, 0));

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.5f);
    }

    // bullet fire form below
    void fireDown()
    {
        float coorX = Random.Range(3.2f, -2.1f);

        GameObject bullet = (GameObject)Instantiate(
            bulletVertical,
            new Vector3(coorX, 6.4f, 0), new Quaternion(0, 0, 180, 0));

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.5f);
    }

    // determine which direction the bullet will fire from
    void randomFire()
    {
        int mode = Random.Range(0,4);

        switch (mode)
        {
            case 0:
                fireLeft();
                break;
            case 1:
                fireRight();
                break;
            case 2:
                fireUp();
                break;
            case 3:
                fireDown();
                break;
        }
    }

    // is Trigger collide event
    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collideObject = collision.gameObject;
    
        if (collision.gameObject.tag == "Player")
        {
            print("destroy player");
            Destroy(collideObject);
            Destroy(fullscreentouch.getObject());
        }
    }
}
