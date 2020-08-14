using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerSkill : MonoBehaviour
{
    public GameObject player;
    int attackPower;
    int currentHealth;
    public playerHealth playerhealth;
    public GameObject slash;
    public GameObject deadCanvas;
    public playercontroll playercontrol;
    public int slashTime = 0;

    // Start is called before the first frame update
    void Start()
    {
            //fireSkill();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    /*public void attack(int attackPower, GameObject gameObject)
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
            //Time.timeScale = 0f;
        }
    }*/

    public void fireSkill()
    {
        float coorX = Random.Range(3.2f, -2.1f);

        GameObject playerSkill = (GameObject)Instantiate(
           slash,
           new Vector3(playercontrol.getPlayerPositionX(), playercontrol.getPlayerPositionY(), 0), new Quaternion(0, 0, 0, 0));

        // Add velocity to the bullet
        playerSkill.GetComponent<Rigidbody2D>().velocity = playerSkill.transform.up * 10;

        GameObject playerSkill1 = (GameObject)Instantiate(
           slash,
           new Vector3(playercontrol.getPlayerPositionX(), playercontrol.getPlayerPositionY(), 0), new Quaternion(0, 0, 0, 0));

        // Add velocity to the bullet
        playerSkill1.GetComponent<Rigidbody2D>().velocity = playerSkill1.transform.up * 10;
    }

    public int getSlashTime()
    {
        return slashTime;
    }
}
