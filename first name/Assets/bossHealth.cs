using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHealth : MonoBehaviour
{
    public const int maxHealth = 2;
    public int currentHealth = maxHealth;

    public void TakeDamage(int attackPower)
    {
        currentHealth -= attackPower;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            print("dead");
        }
    }
}
