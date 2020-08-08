using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHealth : MonoBehaviour
{
    public const int maxHealth = 2;
    public int currentHealth = maxHealth;

    public void TakeDamage(int attackPower, GameObject gameObject)
    {
        print("take damage");
        currentHealth -= attackPower;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Destroy(gameObject);
            print("dead");
        }
    }
}
