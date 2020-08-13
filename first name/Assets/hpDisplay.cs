using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class hpDisplay : MonoBehaviour
{
    public int hp;
    public Text hpText;
    public playerHealth playerhealth;

    // Update is called once per frame
    void Update()
    {
        displayHP();
    }

    //display hp on the screen
    public void displayHP()
    {
        hp = playerhealth.getCurrentHp();
        hpText.text = hp.ToString();
    }
}
