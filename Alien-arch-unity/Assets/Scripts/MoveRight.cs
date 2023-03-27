using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class MoveRight : MonoBehaviour
{
    private Rigidbody2D physicsBody = null;


    public void MoveLeft()
    {
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = 1;

        physicsBody.velocity = newVelocity;
    }




    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }
}
