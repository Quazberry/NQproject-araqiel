using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Referebce Health Bar
    public HealthValues healthBar;

    // Declare Health Variables
    public int maxHealth = 100;
    public int currentHealth;

    // Load in Current Health
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    // Damage test
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            damageTaken(20);
        }
    }

    // Function for damage taken
    void damageTaken(int damage)
    {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);
    }


}
