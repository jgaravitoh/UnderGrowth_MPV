using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int healthPoints;
    private int strenghtPoints, dextertyPoints, constitutionPoints, intelligencePoints, wisdomPoints,
                charismaPoints, armorPoints, speedPoints;
    
    void Start()
    {
        healthPoints = 10;
    }

    public void Damage(int damagePoints)     // Applies damage to enemy
    {
        // Makes damage take effect.
        healthPoints -= damagePoints;
        // Keeps enemy health from going below zero.
        if (healthPoints < 0) healthPoints = 0;
        Debug.Log("Se hizo daño, la vida actual es: " + healthPoints);
        CheckKillEnemy();

    }
    
    private void CheckKillEnemy() // Checks if enemy needs to die.
    {
        // If enemy's health is 0 kill it.
        if (healthPoints <= 0)
        {
            Destroy(gameObject); // Rn this code only destroys the gameObject, no animation yet.
        }
    }
}
