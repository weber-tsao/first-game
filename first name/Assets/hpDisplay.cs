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

    // Start is called before the first frame update
    void Start()
    {
        //hp = playerhealth.getMaxHp();
    }

    // Update is called once per frame
    void Update()
    {
        displayHP();
    }

    public void updateHP()
    {
        hp = playerhealth.getCurrentHp();
        hpText.text = hp.ToString();
    }

    public void displayHP()
    {
        hp = playerhealth.getCurrentHp();
        hpText.text = hp.ToString();
    }
}
