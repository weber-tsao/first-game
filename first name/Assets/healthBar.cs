using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Slider slider;

    // set health
    public void setHealth(int hp)
    {
        slider.value = hp;
    }

    // set max health
    public void setMaxHealth(int hp)
    {
        slider.maxValue = hp;
        slider.value = hp;
    }
}
