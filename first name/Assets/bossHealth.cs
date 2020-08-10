using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossHealth : MonoBehaviour
{
    // field
    public const int maxHealth = 3;
    public int currentHealth = maxHealth;
    public healthBar healthbar;

    void Start()
    {
    }

    // damage the object and destroy it when health reached 0
    public void TakeDamage(int attackPower, GameObject gameObject)
    {
        print("boss take damage");
        currentHealth -= attackPower;// damage the object
        healthbar.setHealth(currentHealth);

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
