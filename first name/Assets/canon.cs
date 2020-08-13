using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class canon : MonoBehaviour
{
    float coorXUp;
    float coorXDown;
    float coorYLeft;
    float coorYRight;
    public GameObject bulletHorizontal;
    public GameObject bulletVertical;
    public GameObject warningVertical;
    public GameObject warningHorizontal;
    public fullScreenTouch fullscreentouch;
    public gameUI gameui;

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
        float coorY = Random.Range(4.0f, -4.2f);
        coorYLeft = coorY;

        GameObject warning = (GameObject)Instantiate(
           warningHorizontal,
           new Vector3(3.37f, coorY, 0), new Quaternion(0, 0, 180, 0));

        Destroy(warning, 0.8f);

        StartCoroutine(wait(3));

        /*GameObject bullet = (GameObject)Instantiate(
            bulletHorizontal,
            new Vector3(5, coorY, 0), new Quaternion(0, 0, 180, 0));

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right *6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2f);*/
    }

    // bullet fire form right
    void fireRight()
    {
        float coorY = Random.Range(4.0f, -4.2f);
        coorYRight = coorY;

        GameObject warning = (GameObject)Instantiate(
           warningHorizontal,
           new Vector3(-2.25f, coorY, 0), new Quaternion(0, 0, 0, 0));

        Destroy(warning, 0.8f);

        StartCoroutine(wait(1));

        /*GameObject bullet = (GameObject)Instantiate(
            bulletHorizontal,
            new Vector3(-3.5f, coorY, 0), new Quaternion(0, 0, 0, 0));

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2f);*/
    }

    // bullet fire form above
    void fireUp()
    {
        float coorX = Random.Range(3.2f, -2.1f);
        coorXUp = coorX;

        GameObject warning = (GameObject)Instantiate(
           warningVertical,
           new Vector3(coorX, -4.353f, 0), new Quaternion(0, 0, 0, 0));

        Destroy(warning, 0.8f);
   
        StartCoroutine(wait(0));

        
           /* GameObject bullet = (GameObject)Instantiate(
                bulletVertical,
                new Vector3(coorX, -4.0f, 0), new Quaternion(0, 0, 0, 0));

            // Add velocity to the bullet
            bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * 6;

            // Destroy the bullet after 2 seconds
            Destroy(bullet, 1.3f);*/
        
    }

    // bullet fire form below
    void fireDown()
    {
        float coorX = Random.Range(3.2f, -2.1f);
        coorXDown = coorX;

        GameObject warning = (GameObject)Instantiate(
           warningVertical,
           new Vector3(coorX, 3.92f, 0), new Quaternion(0, 0, 180, 0));

        Destroy(warning, 0.8f);

        StartCoroutine(wait(2));

        /*GameObject bullet = (GameObject)Instantiate(
            bulletVertical,
            new Vector3(coorX, 3.5f, 0), new Quaternion(0, 0, 180, 0));

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * 6;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 1.3f);*/
    }

    void traceFire()
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
        }
    }

    IEnumerator wait(int mode)
    {
        yield return new WaitForSeconds(1);
        createObject(mode);
    }

    void createObject(int objPos)
    {

        switch (objPos)
        {
            case 0:// up
                GameObject bulletUp = (GameObject)Instantiate(
                bulletVertical,
                new Vector3(coorXUp, -4.0f, 0), new Quaternion(0, 0, 0, 0));

                // Add velocity to the bullet
                bulletUp.GetComponent<Rigidbody2D>().velocity = bulletUp.transform.up * 100;

                // Destroy the bullet after 2 seconds
                Destroy(bulletUp, 1.3f);
                break;
            case 1:// right
                GameObject bulletRight = (GameObject)Instantiate(
                bulletHorizontal,
                new Vector3(-3.5f, coorYRight, 0), new Quaternion(0, 0, 0, 0));

                // Add velocity to the bullet
                bulletRight.GetComponent<Rigidbody2D>().velocity = bulletRight.transform.right * 100;

                // Destroy the bullet after 2 seconds
                Destroy(bulletRight, 2f);
                break;
            case 2:// down
                GameObject bulletDown = (GameObject)Instantiate(
                bulletVertical,
                new Vector3(coorXDown, 3.5f, 0), new Quaternion(0, 0, 180, 0));

                // Add velocity to the bullet
                bulletDown.GetComponent<Rigidbody2D>().velocity = bulletDown.transform.up * 100;

                // Destroy the bullet after 2 seconds
                Destroy(bulletDown, 1.3f);
                break;
            case 3:// left
                GameObject bulletLeft = (GameObject)Instantiate(
                bulletHorizontal,
                new Vector3(5, coorYLeft, 0), new Quaternion(0, 0, 180, 0));

                // Add velocity to the bullet
                bulletLeft.GetComponent<Rigidbody2D>().velocity = bulletLeft.transform.right * 100;

                // Destroy the bullet after 2 seconds
                Destroy(bulletLeft, 2f);
                break;
        }
    }
}
