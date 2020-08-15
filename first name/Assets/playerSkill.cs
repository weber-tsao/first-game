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

    public void fireSkill(int mode)
    {

        switch (mode)
        {
            case 0:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0f), (playercontrol.getPlayerPositionY() + 1.0f), 5, 0f));
                break;
            case 1:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() - 1.2f), playercontrol.getPlayerPositionY(), 19, 0.5f));
                break;
            case 2:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() - 1.0f), (playercontrol.getPlayerPositionY() + 0.9f), 22, 1.0f));
                break;
            case 3:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.7f), (playercontrol.getPlayerPositionY() + 0.67f), -25, 1.29f));
                break;
            case 4:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() - 1.1f), (playercontrol.getPlayerPositionY() + 0.50f), 24, 1.48f));
                break;
            case 5:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.8f), (playercontrol.getPlayerPositionY() + 0.3f), -21, 1.65f));
                break;
            case 6:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() - 0.3f), (playercontrol.getPlayerPositionY() + 0.85f), 11, 1.84f));
                break;
            case 7:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.2f), (playercontrol.getPlayerPositionY() + 1.4f), -15, 2.01f));
                break;
            case 8:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() - 0.6f), (playercontrol.getPlayerPositionY() + 1.0f), 9, 2.25f));
                break;
            case 9:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.52f), (playercontrol.getPlayerPositionY() + 0.69f), -21, 2.48f));
                break;
            case 10:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() - 0.6f), (playercontrol.getPlayerPositionY() + 0.9f), 2, 2.62f));
                break;
            case 11:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.65f), (playercontrol.getPlayerPositionY() + 1.15f), -14, 2.75f));
                break;
            case 12:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() - 0.5f), (playercontrol.getPlayerPositionY() + 1.6f), 18, 2.82f));
                break;
            case 13:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.7f), (playercontrol.getPlayerPositionY() + 1.5f), -16, 2.89f));
                break;
            case 14:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() - 0.8f), (playercontrol.getPlayerPositionY() + 0.4f), 20, 2.95f));
                break;
            case 15:
                StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.69f), (playercontrol.getPlayerPositionY() + 0.6f), -9, 3.0f));
                break;
        }
    }

        void createSlash(float playerPosX, float playerPosY, int rotate)
    {
        Quaternion rotation = Quaternion.Euler(0, 0, rotate);

        GameObject playerSkill = (GameObject)Instantiate(
           slash,
           new Vector3(playerPosX, playerPosY, 0), rotation);

        playerSkill.transform.parent = transform;

        // Add velocity to the bullet
        playerSkill.GetComponent<Rigidbody2D>().velocity = playerSkill.transform.up * 5;

        Destroy(playerSkill, 0.2f);
    }

    public int getSlashTime()
    {
        return slashTime;
    }

    IEnumerator wait(float playerPosX, float playerPosY, int rotate, float time)
    {
        yield return new WaitForSeconds(time);
        createSlash(playerPosX, playerPosY, rotate);
    }
}
