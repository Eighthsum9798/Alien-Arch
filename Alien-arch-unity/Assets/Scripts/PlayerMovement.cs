using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D physicsBody = null;


    public float speed = 1;

    public float JumpSpeed = 10;


    public Collider2D GroundSensor = null;
    public LayerMask GroundLayer = 0;

    public void MoveLeft()
    {
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = -speed;

        physicsBody.velocity = newVelocity;
    }

    public void Moveright()
    {
        
            Vector2 newVelocity = physicsBody.velocity;

            newVelocity.x = speed;

            physicsBody.velocity = newVelocity;
        
    }

    public void Jump()
    {

        if (GroundSensor.IsTouchingLayers(GroundLayer))
        {
            Vector2 newVelocity = physicsBody.velocity;

            newVelocity.y = JumpSpeed;

            physicsBody.velocity = newVelocity;
        }

    }

    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }



}
