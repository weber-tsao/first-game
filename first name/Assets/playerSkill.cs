using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class playerSkill : MonoBehaviour
{
    public GameObject player;
    int attackPower;
    int currentHealth;
    public playerHealth playerhealth;
    public GameObject slash;
    public GameObject deadCanvas;
    public playercontroll playercontrol;

    // Start is called before the first frame update
    void Start()
    {
        //print(player.transform.position.x);
        fireSkill();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void attack()
    {
        currentHealth = playerhealth.getCurrentHp();
        print("player take damage of " + attackPower);
        currentHealth -= attackPower;// damage the object

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Destroy(player);
            print("player dead");

            // create dead canvas above all layers
            GameObject dead = (GameObject)Instantiate(
            deadCanvas,
            new Vector3(0.55f, -0.17f, 0), new Quaternion(0, 0, 0, 0));

            // pause the game 
            Time.timeScale = 0f;
        }
    }

    void fireSkill()
    {
        float coorX = Random.Range(3.2f, -2.1f);
        

        GameObject playerSkill = (GameObject)Instantiate(
           slash,
           new Vector3(playercontrol.getPlayerPositionX(), 3.92f, 0), new Quaternion(0, 0, 180, 0));

        // Add velocity to the bullet
        playerSkill.GetComponent<Rigidbody2D>().velocity = playerSkill.transform.up * 10;
    }
}
