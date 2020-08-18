using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerSkill : MonoBehaviour
{
    // field
    public GameObject player;
    int attackPower;
    int currentHealth;
    public playerHealth playerhealth;
    public GameObject slash;
    public GameObject deadCanvas;
    public playercontroll playercontrol;
    public GameObject burstFace;
    public GameObject starburstButton;
    bool isSkillFired = false;

    // start the game
    void Start()
    {
        burstFace.SetActive(false);
        starburstButton = GameObject.Find("starBurstStream");
    }

    // fire slash
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

        // Add velocity to the slash
        playerSkill.GetComponent<Rigidbody2D>().velocity = playerSkill.transform.up * 5;

        Destroy(playerSkill, 0.2f);
    }

    // onclick event which trigger starBurstStream
    public void starBurstStream()
    {
        starburstButton.SetActive(false);
        if (isSkillFired == false)
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
            isSkillFired = true;
        }
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
