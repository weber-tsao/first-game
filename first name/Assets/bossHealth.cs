﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossHealth : MonoBehaviour
{
    // field
    public const int maxHealth = 20;
    public int currentHealth = maxHealth;

    // damage the object and destroy it when health reached 0
    public void TakeDamage(int attackPower, GameObject gameObject)
    {
        print("boss take damage of " + attackPower);
        currentHealth -= attackPower;// damage the object

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Destroy(gameObject);
            print("boss dead");
        }
    }

    public int getCurrentHp()
    {
        return currentHealth;
    }
}
