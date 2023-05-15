using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {

        
        //if statement to check if player has touched the object
        if (collision.gameObject.CompareTag("Player"))
        {
            //destroy the game object
            Destroy(gameObject);

        }




    }



}
