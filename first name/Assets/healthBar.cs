using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class healthBar : MonoBehaviour
{
    Vector3 localScale;

    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        localScale.x = bossHealth.currentHealth;
        transform.localScale = localScale;
    }
}
