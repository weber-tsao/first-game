﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;


public class playerHealth : MonoBehaviour
{
    // field
    public const int maxHealth = 5;
    public int currentHealth = changeScene.playerMaxHealth;
    public healthBar healthbar;
    public GameObject deadCanvas;
    public bool damageflag = true;
    public float timer_f;
    public GameObject immortalObject;
    public GameObject defendButton;

    // Start is called before the first frame update
    void Start()
    {
        healthbar.setMaxHealth(5);// set health bar to max hp 
        immortalObject.SetActive(false);// set immortalObject invisible
        defendButton = GameObject.Find("defendButton");

    }

    // damage the object and destroy it when health reached 0
    public void TakeDamage(int attackPower, GameObject gameObject)
    {
        if (damageflag)
        {
            print("player take damage of " + attackPower);
            changeScene.playerMaxHealth -= attackPower;// damage the object

            if (changeScene.playerMaxHealth <= 0)
            {
                changeScene.playerMaxHealth = 0;
                Destroy(gameObject);
                print("player dead");

                // create dead canvas above all layers
                GameObject dead = (GameObject)Instantiate(
                deadCanvas,
                new Vector3(0.55f, -0.17f, 0), new Quaternion(0, 0, 0, 0));
            }
        }
    }

    // get current hp
    public int getCurrentHp()
    {
        //return currentHealth;
        return changeScene.playerMaxHealth;
    }

    // get max hp
    public int getMaxHp()
    {
        return maxHealth;
    }

    // parry attack for player
    public void HeathcliffShield()
    {
        damageflag = false;
        defendButton.SetActive(false);
        Invoke("shieldAppear", 0);
        Invoke("shieldDisappear", 2);
        Invoke("setDamageflag",2);
        Invoke("defendButtonShow", 5);
    }

    public void setDamageflag()
    {
        damageflag = true;
    }

    public bool getDamageflag()
    {
        return damageflag;
    }

    void shieldAppear()
    {
        immortalObject.SetActive(true);
    }

    void shieldDisappear()
    {
        immortalObject.SetActive(false);
    }
    void defendButtonShow()
    {
        defendButton.SetActive(true);
    }
}

