using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bossHealth : MonoBehaviour
{
    // field
    public const int maxHealth = 20;
    public int currentHealth = maxHealth;
    public healthBar healthbar;
    public GameObject clearCanvas;
    public playerHealth playerhealth;

    // Start is called before the first frame update
    void Start()
    {
        healthbar.setMaxHealth(maxHealth);// set health bar to max hp 
    }

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

            // create clear canvas above all layers
            GameObject clear= (GameObject)Instantiate(
            clearCanvas,
            new Vector3(0.50352f, -0.33f, 0), new Quaternion(0, 0, 0, 0));

            changeScene.changeScenePlayerHealth = playerhealth.getCurrentHp();

            SceneManager.LoadScene("scene2");
            // pause the game 
            //Time.timeScale = 0f;
        }
    }

    // starBurstStream damage function
    public void takeDamageFromSlash(int attackPower, GameObject gameObject)
    {
        print("boss take damage of " + attackPower);
        currentHealth -= attackPower;// damage the object

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Destroy(gameObject);
            print("boss dead");

            // create clear canvas above all layers
            GameObject clear = (GameObject)Instantiate(
            clearCanvas,
            new Vector3(0.50352f, 1.33f, 0), new Quaternion(0, 0, 0, 0));

            changeScene.changeScenePlayerHealth = playerhealth.getCurrentHp();

            SceneManager.LoadScene("scene2");

            // pause the game 
            //Time.timeScale = 0f;
        }
    }

    // get current hp
    public int getCurrentHp()
    {
        return currentHealth;
    }

}
