using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{



    public int startingHealth = 3;

    private int currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void changeHealth(int changeAmount)
    {
        currentHealth = currentHealth + changeAmount;

        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        if (currentHealth == 0)
        {
            kill();
        }


    }

    public void kill()
    {
        //destroys game object that script is attached to

        Destroy(gameObject);
    }


    public int getHealth()
    {
        return currentHealth;
    }

}
