using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossHealth : MonoBehaviour
{
    // field
    public const int maxHealth = 2;
    public int currentHealth = maxHealth;

    // damage the object and destroy it when health reached 0
    public void TakeDamage(int attackPower, GameObject gameObject)
    {
        print("boss take damage");
        currentHealth -= attackPower;// damage the object

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Destroy(gameObject);
            print("boss dead");
        }
    }
}
