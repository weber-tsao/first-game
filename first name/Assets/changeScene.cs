using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene
{
    public static int playerMaxHealth = 5;
    public static int changeScenePlayerHealth;

    public int getPlayerHealth()
    {
        return playerMaxHealth;
    }

    public void setPlayerHealth(int health)
    {
        playerMaxHealth = health;
    }

    public void setChangeScenePlayerHealth(int health)
    {
        changeScenePlayerHealth = health;
    }

    public int getChangeScenePlayerHealth()
    {
        return changeScenePlayerHealth;
    }
}
