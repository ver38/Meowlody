using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamagePlayer : MonoBehaviour
{
    public int fullHealth;
    public int health;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        health = fullHealth;
        healthText.text = "Health: " + health.ToString();
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health.ToString();

    }

    public void DecreaseHealth(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
                Debug.Log("player dead game stops");
                Time.timeScale = 0;

        }
    }



}
