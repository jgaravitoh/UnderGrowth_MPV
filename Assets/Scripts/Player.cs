using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int healthPoints;
    private int strenghtPoints, dextertyPoints, constitutionPoints, intelligencePoints, wisdomPoints,
                charismaPoints, armorPoints, speedPoints;

    public GameObject selectedGameObject;

    void Start()
    {   // Temporary values.
        healthPoints = 10;
        strenghtPoints = 2;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && selectedGameObject != null) {
            DoDamage(selectedGameObject);
        }
    }
    public void Damage(int damagePoints)     // Applies damage to player
    {
        // Makes damage take effect.
        healthPoints -= damagePoints;
        // Keeps enemy health from going below zero.
        if (healthPoints < 0) healthPoints = 0;
        CheckKillPlayer();

    }

    private void CheckKillPlayer() // Checks if enemy needs to die.
    {
        // If enemy's health is 0 kill it.
        if (healthPoints <= 0)
        {
            Destroy(gameObject); // Rn this code only destroys the gameObject, no animation yet.
        }
    }

    // Simple interaction
    private void DoDamage(GameObject enemyGameObject)
    {
        Enemy enemyScript = enemyGameObject.GetComponent<Enemy>();  // Gets enemy's script
        if (enemyScript != null)
        {
            enemyScript.Damage(strenghtPoints); // Applies damage to Enemy. ** Temporarily Damage Points are the Strenght Points **
        }
    }

}
