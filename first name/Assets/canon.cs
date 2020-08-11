using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Fire();
    }

    // Update is called once per frame
    void Update()
    {
        //InvokeRepeating("Fire", 2f, 1000f); 
    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        GameObject bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right * 20;

        // Destroy the bullet after 2 seconds
        //Destroy(bullet, 0.5f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collideObject = collision.gameObject;
        print("asdfasdf");
        if (collision.gameObject.tag == "Player")
        {
            print("asdfasdf");
            Destroy(collideObject);
        }
    }
}
