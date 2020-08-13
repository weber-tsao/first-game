using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerHealth : MonoBehaviour
{
    // field
    public const int maxHealth = 5;
    public int currentHealth = maxHealth;
    public healthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        healthbar.setMaxHealth(maxHealth);// set health bar to max hp 
    }

    // damage the object and destroy it when health reached 0
    public void TakeDamage(int attackPower, GameObject gameObject)
    {
        print("player take damage of " + attackPower);
        currentHealth -= attackPower;// damage the object

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Destroy(gameObject);
            print("player dead");
        }
    }

    // get current hp
    public int getCurrentHp()
    {
        return currentHealth;
    }

    // get max hp
    public int getMaxHp()
    {
        return maxHealth;
    }
}

