using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRigidBody;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpHeight;
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRigidBody.velocity = new Vector2(horizontalInput * movementSpeed, playerRigidBody.velocity.y);

        if (Input.GetKey(KeyCode.Space))
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpHeight);
        }
    }
}
