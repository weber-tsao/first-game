﻿using System.Collections;
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
    float recordTime;
    public GameObject burstFace;

    void Start()
    {
        burstFace.SetActive(false);
    }

    /*public void fireSkill(int mode)
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
    }*/

    /*public void fireSkillwww()
    {
        
            StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0f), (playercontrol.getPlayerPositionY() + 1.0f), 5, 0f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() - 1.2f), playercontrol.getPlayerPositionY(), 19, 0.5f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() - 1.0f), (playercontrol.getPlayerPositionY() + 0.9f), 22, 1.0f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.7f), (playercontrol.getPlayerPositionY() + 0.67f), -25, 1.29f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() - 1.1f), (playercontrol.getPlayerPositionY() + 0.50f), 24, 1.48f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.8f), (playercontrol.getPlayerPositionY() + 0.3f), -21, 1.65f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() - 0.3f), (playercontrol.getPlayerPositionY() + 0.85f), 11, 1.84f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.2f), (playercontrol.getPlayerPositionY() + 1.4f), -15, 2.01f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() - 0.6f), (playercontrol.getPlayerPositionY() + 1.0f), 9, 2.25f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.52f), (playercontrol.getPlayerPositionY() + 0.69f), -21, 2.48f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() - 0.6f), (playercontrol.getPlayerPositionY() + 0.9f), 2, 2.62f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.65f), (playercontrol.getPlayerPositionY() + 1.15f), -14, 2.75f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() - 0.5f), (playercontrol.getPlayerPositionY() + 1.6f), 18, 2.82f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.7f), (playercontrol.getPlayerPositionY() + 1.5f), -16, 2.89f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() - 0.8f), (playercontrol.getPlayerPositionY() + 0.4f), 20, 2.95f));

            StartCoroutine(wait((playercontrol.getPlayerPositionX() + 0.69f), (playercontrol.getPlayerPositionY() + 0.6f), -9, 3.0f));

        
    }*/

    void slashFire()
    {
        int mode = Random.Range(0, 360);
        float playerPosX = getPositionX();
        float playerPosY = getPositionY();

        Quaternion rotation = Quaternion.Euler(0, 0, mode);

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

    /*IEnumerator wait(float playerPosX, float playerPosY, int rotate, float time)
    {
        yield return new WaitForSeconds(time);
        createSlash(playerPosX, playerPosY, rotate);
    }*/

    public void starBurstStream()
    {
        burstFace.SetActive(true);
        Invoke("slashFire", 0f);
        Invoke("slashFire", 0.5f);
        Invoke("slashFire", 1.0f);
        Invoke("slashFire", 1.29f);
        Invoke("slashFire", 1.48f);
        Invoke("slashFire", 1.65f);
        Invoke("slashFire", 1.84f);
        Invoke("slashFire", 2.01f);
        Invoke("slashFire", 2.25f);
        Invoke("slashFire", 2.48f);
        Invoke("slashFire", 2.62f);
        Invoke("slashFire", 2.75f);
        Invoke("slashFire", 2.82f);
        Invoke("slashFire", 2.89f);
        Invoke("slashFire", 2.95f);
        Invoke("slashFire", 3.0f);
        Invoke("faceDisappear", 3.2f);
    }

    public float getPositionX()
    {
        return playercontrol.getPlayerPositionX();
    }

    public float getPositionY()
    {
        return playercontrol.getPlayerPositionY();
    }

    void faceDisappear()
    {
        burstFace.SetActive(false);
    }
}
